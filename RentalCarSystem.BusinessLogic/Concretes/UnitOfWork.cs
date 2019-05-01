using RentalCarSystem.BusinessLogic.Abstactions;
using RentalCarSystem.DataAccessLayer;
using RentalCarSystem.DataAccessLayer.Repositories.Abstractions;
using RentalCarSystem.DataAccessLayer.Repositories.Concrates;
using RentalCarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace RentalCarSystem.BusinessLogic.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CustomerContext _dbContext;

        public UnitOfWork(CustomerContext dbContext)
        {
            Database.SetInitializer<CustomerContext>(null);

            if (dbContext == null)
                throw new ArgumentException("dbContext can not be null");

            _dbContext = dbContext;
        }

    
        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(_dbContext);
        }

        public int SaveChanges()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch
            {
                throw new Exception("Veriler kaydedilemedi!");
            }
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



    }
}
