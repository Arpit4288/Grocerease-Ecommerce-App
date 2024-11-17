using Microsoft.EntityFrameworkCore;
using MVC_Assignment.Data;
using MVC_Assignment.Interfaces;
using MVC_Assignment.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class EventRepository : IEventRepository
{

    private readonly ApplicationDbContext _context;

    public EventRepository(ApplicationDbContext context) {
        _context = context;
    }

    async Task<int> IEventRepository.AddBookReadingEvent(BookReadingEventModel bookReadingEventModel)
    {
        _context.Add(bookReadingEventModel);
        int result = await _context.SaveChangesAsync();
        return result;
    }

    async Task<BookReadingEventModel> IEventRepository.FindById(int? id)
    {
        var bookReadingEventModel = await _context.BookReadingEventModel.FindAsync(id);
        return bookReadingEventModel;
    }

    async Task<List<CommentModel>> IEventRepository.GetAllComments()
    {
        var comments = await _context.Comment.ToListAsync();
        return comments;
    }

    async Task<BookReadingEventModel> IEventRepository.GetBookReadingEventModelById(int? id)
    {
        var bookReadingEventModel = await _context.BookReadingEventModel
            .FirstOrDefaultAsync(m => m.Id == id);
        return bookReadingEventModel;
    }

    async Task<List<BookReadingEventModel>> IEventRepository.GetBookReadingEventModelsCreatedByUser(string userId)
    {
        var books = await _context.BookReadingEventModel
            .Where(x => x.CreatedBy == userId)
            .ToListAsync();
        return books;
    }


    async Task<List<BookReadingEventModel>> IEventRepository.GetAllBookReadingEventModels()
    {
        var books = await _context.BookReadingEventModel.ToListAsync();
        return books;
    }



    async Task IEventRepository.UpdateBookReadingEventModelAndSave(BookReadingEventModel bookReadingEventModel)
    {
        _context.Update(bookReadingEventModel);
        await _context.SaveChangesAsync();
    }




    async Task IEventRepository.DeleteBookReadingEventModelAndSave(BookReadingEventModel bookReadingEventModel)
    {
        _context.BookReadingEventModel.Remove(bookReadingEventModel);
        await _context.SaveChangesAsync();
    }


    async Task<bool> IEventRepository.BookReadingEventExists(int id)
    {
        var result = await _context.BookReadingEventModel.AnyAsync(e => e.Id == id);
        return result;
    }



    async Task IEventRepository.AddComment(CommentModel newComment)
    {
        _context.Comment.Add(newComment);
        await _context.SaveChangesAsync();
    }



}