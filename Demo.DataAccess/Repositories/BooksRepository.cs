using Demo.DataAccess.Contracts.Repositories;
using Demo.DataAccess.GenericRepository;
using Demo.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.DataAccess.Repositories
{
    public class BooksRepository : GenericRepository<Book>, IBooksRepository
    {
        public BooksRepository(DemoDbContext context): base(context)
        {

        }

        public IEnumerable<Book> GetBooksByAuthor()
        {
            //table.Include(t=>t.);
            return null;
        }
    }
}
