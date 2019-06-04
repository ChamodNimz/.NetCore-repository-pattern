using Demo.DataAccess.Models;
using Demo.Utilities.Vms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DataAccess.Contracts
{
    public interface IAuthorRepository: IGenericRepository<Author>
    {
       IEnumerable<Author> GetAllAuthorsWithBooks();
    }
}
