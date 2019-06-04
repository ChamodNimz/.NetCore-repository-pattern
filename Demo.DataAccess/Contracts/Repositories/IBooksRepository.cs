using Demo.DataAccess.GenericRepository;
using Demo.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DataAccess.Contracts.Repositories
{
    public interface IBooksRepository: IGenericRepository<Book>
    {
        IEnumerable<Book> GetBooksByAuthor();
    }
}
