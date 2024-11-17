using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MVC_Assignment.Models;
using MVC_Assignment.Interfaces;

namespace MVC_Assignment.Data
{
    // create an interface for this below class and provide Dbset both props form that and mock that interface in the unit test case file
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        //public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MVC_Assignment.Models.BookReadingEventModel> BookReadingEventModel { get; set; }
        public DbSet<MVC_Assignment.Models.CommentModel> Comment { get; set; }
    }
}
