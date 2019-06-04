using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(object id);
    }
}
