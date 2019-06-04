using Demo.DataAccess.Contracts;
using Demo.DataAccess.GenericRepository;
using Demo.DataAccess.Models;
using Demo.Utilities.Vms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.DataAccess.Repositories
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(DemoDbContext context):base(context)
        {

        }
        public IEnumerable<Author> GetAllAuthorsWithBooks()
        {
            return table
                .Include(e => e.Books)
                .Where(l => l.Books.Count > 2)
                .OrderByDescending(l => l.Id)
                .Distinct();
        }
    }
}
