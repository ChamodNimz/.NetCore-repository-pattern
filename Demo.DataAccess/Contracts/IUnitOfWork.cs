using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DataAccess.Contracts
{
    public interface IUnitOfWork
    {
        void CreateTransaction();
        void Rollback();
        void Commit();
        void Save();
    }
}
