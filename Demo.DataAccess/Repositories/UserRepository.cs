using Demo.DataAccess.Contracts.Repositories;
using Demo.DataAccess.GenericRepository;
using Demo.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.DataAccess.Repositories
{
    public class UserRepository: GenericRepository<User>, IUserRepository
    {
        public UserRepository(DemoDbContext context) : base(context)
        {
            
        }
        
        public bool IsExist(string username, string password)
        {
            return table.SingleOrDefault(o => o.Username.Equals(username) && o.Password.Equals(password))!=null;
;        }

    }
}
