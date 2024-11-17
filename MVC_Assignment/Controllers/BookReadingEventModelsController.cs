using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Assignment.Data;
using MVC_Assignment.Interfaces;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    [Authorize]
    public class BookReadingEventModelsController : Controller
    {
        private readonly IEventRepository _repository;
        private readonly UserManager<ApplicationUser> _userManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;

        public BookReadingEventModelsController(IEventRepository repository, UserManager<ApplicationUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
            //_signInManager = signInManager;
        }

        // GET: BookReadingEventModels
        public async Task<IActionResult> Index()
        {
            List<BookReadingEventModel> books = await _repository.GetBookReadingEventModelsCreatedByUser(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if(User.IsInRole("Admin"))
            {
                books = await _repository.GetAllBookReadingEventModels();
            }
            return View(books);
        }

        public async Task<IActionResult> EventInvitedTo()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            List<BookReadingEventModel> events = await _repository.GetAllBookReadingEventModels();  // it is returning Task<model Type>
            var filteredEvents = events.Where(e =>
            e.InviteByEmail != null &&
            e.InviteByEmail.Split(',').Select(s => s.Trim()).Contains(currentUser.Email)
            );
            Console.WriteLine(filteredEvents);


            return View(filteredEvents);
        }

        // GET: BookReadingEventModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookReadingEventModel bookReadingEventModel = await _repository.GetBookReadingEventModelById(id);
            List<CommentModel> comments = await _repository.GetAllComments();
            ViewBag.comments = comments;
            if (bookReadingEventModel == null)
            {
                return NotFound();
            }

            return View(bookReadingEventModel);
        }

        // GET: BookReadingEventModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookReadingEventModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Date,Location,StartTime,Type,Duration,Description,OtherDetails,InviteByEmail")] BookReadingEventModel bookReadingEventModel)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    bookReadingEventModel.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    await _repository.AddBookReadingEvent(bookReadingEventModel);
                    // await _eventService.AddEvent(bookReadingEventModel, User);
                    //int result =  await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    ModelState.AddModelError("Error", "Storing in the Database Failed, Please try again!");
                    return View(bookReadingEventModel);
                }
            }
            // Adding a custom error message for every field to the model state
            ModelState.AddModelError("Error", "Creating an Event Failed, Please try again!");
            return View(bookReadingEventModel);
        }

        // GET: BookReadingEventModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookReadingEventModel bookReadingEventModel = await _repository.FindById(id);
            if (bookReadingEventModel == null)
            {
                return NotFound();
            }
            return View(bookReadingEventModel);
        }

        // POST: BookReadingEventModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Date,Location,StartTime,Type,Duration,Description,OtherDetails,InviteByEmail")] BookReadingEventModel bookReadingEventModel)
        {
            if (id != bookReadingEventModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    bookReadingEventModel.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    await _repository.UpdateBookReadingEventModelAndSave(bookReadingEventModel);
                }
                catch (Exception)
                {
                    bool exist = await BookReadingEventModelExists(bookReadingEventModel.Id);
                    if (!exist)
                    {
                        return NotFound();
                    }
                    else
                    {
                        ModelState.AddModelError("Error", "Updating the Database Failed, Please try again!");
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            // Adding a custom error message for every field to the model state

            ModelState.AddModelError("Error", "Updating an Event Failed, Please try again!");
            return View(bookReadingEventModel);
        }

        // GET: BookReadingEventModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookReadingEventModel bookReadingEventModel = await _repository.GetBookReadingEventModelById(id);
            if (bookReadingEventModel == null)
            {
                return NotFound();
            }

            return View(bookReadingEventModel);
        }

        // POST: BookReadingEventModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            BookReadingEventModel bookReadingEventModel = await _repository.FindById(id);
            await _repository.DeleteBookReadingEventModelAndSave(bookReadingEventModel);
            return RedirectToAction(nameof(Index));
        }

        private Task<bool> BookReadingEventModelExists(int id)
        {
            Task<bool> result = _repository.BookReadingEventExists(id);
            return result;
        }
        [HttpPost]
        public async Task<IActionResult> AddCommentAsync(CommentModel newComment)
        {
            if (ModelState.IsValid)
            {
                // Set the PostedDate to the current date and time
                newComment.PostedDate = DateTime.Now;



                // Save the comment to the database (assuming you have a DbContext named "YourDbContext")

                await _repository.AddComment(newComment);

                return RedirectToAction("Details", "BookReadingEventModels", new { id = newComment.EventId }); // Redirect to the current event details page 
            }



            return View(newComment);
        }
    }
}
