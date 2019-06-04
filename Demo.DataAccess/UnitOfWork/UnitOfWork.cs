using Demo.DataAccess.Contracts;
using Demo.DataAccess.GenericRepository;
using Demo.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DemoDbContext _context;
        public DemoDbContext Context { get { return _context; }  }
        private IDbContextTransaction _objTrans;
        private Dictionary<string, object> _repositories;
        private bool _disposed;

        // Custom repositories
        public AuthorRepository AuthorRepository { get; }
        public UserRepository UserRepository { get; }

        public UnitOfWork(DemoDbContext context)
        {
            this._context = context;
            this.AuthorRepository = new AuthorRepository(_context);
            this.UserRepository = new UserRepository(_context);
        }

        public void Commit()
        {
            _objTrans.Commit();
        }

        public void CreateTransaction()
        {
            _objTrans = _context.Database.BeginTransaction();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Rollback()
        {
            _objTrans.Rollback();
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _context.Dispose();
                    _disposed = true;
        }

        public GenericRepository<T> GenericRepository<T>() where T : class
        {
            //if (_repositories == null)
            //    _repositories = new Dictionary<string, object>();
            //var type = typeof(T).Name;
            //if (!_repositories.ContainsKey(type))
            //{
            //    var repositoryType = typeof(GenericRepository<T>);
            //    var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
            //    _repositories.Add(type, repositoryInstance);
            //}
            return new GenericRepository<T>(_context);
        }

    }
}
