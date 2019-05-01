using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace RentalCarSystem.DataAccessLayer.Repositories.Abstractions
{
    public interface IRepository<TEntity> where TEntity:class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate); 
        TEntity GetById(int id);
        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int id);
    }
}
