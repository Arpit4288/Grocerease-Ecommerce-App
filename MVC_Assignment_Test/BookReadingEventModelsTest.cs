using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MVC_Assignment.Controllers;
using MVC_Assignment.Data;
using MVC_Assignment.Interfaces;
using MVC_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;



namespace MVC_Assignment_Test
{
    [TestClass]
    public class BookReadingEventModelsTest
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly BookReadingEventModelsController _controller;
        private readonly IEventRepository _repository;
        private Mock<IEventRepository> _mockRepository;
        public BookReadingEventModelsTest()
        {
            _repository = new Mock<IEventRepository>().Object;

            _userManager = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(), null, null, null, null, null, null, null, null).Object;
            _controller = new BookReadingEventModelsController(_repository, _userManager);
            _mockRepository = new Mock<IEventRepository>();
        }



        // Test Cases For Create Action >>>>>>>>>>>>>>>>>>


        // First Scenario Invalid User and returns a Error Storing in the Database Failed, Please try again!
        [TestMethod]
        public void Create_InvalidUser_ReturnsError()
        {
            var data = new BookReadingEventModel();

            data.Date = new DateTime();


            var response = _controller.Create(data);
            Assert.IsNotNull(response);
        }



        // Second Scenario 
        [TestMethod]
        public async Task Create_ValidInput_ReturnsRedirectToActionResult()
        {
            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
            new Claim(ClaimTypes.NameIdentifier, "xyz")
            }));

            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = user }
            };

            var data = new BookReadingEventModel()
            {
                CreatedBy = "xyz",
                Title = "Test Title",
                Date = new DateTime(),
                Location = "Test Location",
                StartTime = 2,
                Type = "Test Type",
                Duration = 2,
                Description = "Test Description",
                OtherDetails = "Test Details",
                InviteByEmail = "test@gmail.com"
            };

            _mockRepository.Setup(r => r.AddBookReadingEvent(data))
                .ReturnsAsync(1);

            var response = await _controller.Create(data);

            Assert.IsInstanceOfType(response, typeof(RedirectToActionResult));
            Assert.AreEqual(nameof(Index), ((RedirectToActionResult)response).ActionName);
        }


        // Third Scenario
        [TestMethod]
        public async Task Create_ExceptionThrown_ReturnsViewResultWithErrorMessage()
        {
            var data = new BookReadingEventModel()
            {
                CreatedBy = "xyz",
                Title = "Test Title",
                Date = new DateTime(),
                Location = "Test Location",
                StartTime = 2,
                Type = "Test Type",
                Duration = 2,
                Description = "Test Description",
                OtherDetails = "Test Details",
                InviteByEmail = "test@gmail.com"
            };
            _mockRepository.Setup(r => r.AddBookReadingEvent(It.IsAny<BookReadingEventModel>()))
                .ThrowsAsync(new Exception("Database error"));

            var response = await _controller.Create(data);

            Assert.IsInstanceOfType(response, typeof(ViewResult));
            Assert.IsInstanceOfType((response as ViewResult).Model, typeof(BookReadingEventModel));

        }




        // Test Case for Details  >>>>>>>>>>>>>


        // Scenario  Test when id is null
        [TestMethod]
        public async Task Details_IdIsNull_ReturnsNotFound()
        {
            int? id = null;

            var response = await _controller.Details(id);

            Assert.IsInstanceOfType(response, typeof(NotFoundResult));
        }




        // Test Case for Edit Get Eddit 
        [TestMethod]
        public async Task Edit_IdIsNull_ReturnsNotFound()
        {
            int? id = null;

            var response = await _controller.Edit(id);

            Assert.IsInstanceOfType(response, typeof(NotFoundResult));
        }


        // Test Case for Delete 
        [TestMethod]
        public async Task Delete_NullId_ReturnsNotFoundResult()
        {
            int? id = null;

            var response = await _controller.Delete(id);

            Assert.IsInstanceOfType(response, typeof(NotFoundResult));
        }




    }
}
