using Demo.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DataAccess
{
    public class DemoDbContext: DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options):base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<User> User { get; set; }

    }
}
