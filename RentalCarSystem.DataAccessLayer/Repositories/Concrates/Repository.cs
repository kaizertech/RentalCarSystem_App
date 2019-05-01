using RentalCarSystem.DataAccessLayer.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.DataAccessLayer.Repositories.Concrates
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext _contentext;
        private DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _contentext = context;
            _dbSet = _contentext.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(int id)
        {
            _dbSet.Remove(GetById(id));
        }
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}
