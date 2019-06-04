using Demo.DataAccess.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Demo.DataAccess.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        protected DemoDbContext _context = null;
        protected DbSet<TEntity> table = null;
        private bool _isDisposed;

        public GenericRepository(DemoDbContext context)
        {
            this._context = context;
            table = _context.Set<TEntity>();
            _isDisposed = false;
        }

        public void Delete(object obj)
        {
            TEntity existing = table.Find(obj);
            table.Remove(existing);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return table;
        }

        //public IEnumerable<TEntity> GetAlls()
        //{
        //    //return table.Include();
        //}

        public TEntity GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(TEntity obj)
        {
            table.Add(obj);
        }

        //public void Save()
        //{
        //    throw new NotImplementedException();
        //}

        public void Update(TEntity obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

    }
}
