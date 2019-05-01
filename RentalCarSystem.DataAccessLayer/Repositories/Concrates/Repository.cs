using RentalCarSystem.DataAccessLayer.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;

namespace RentalCarSystem.DataAccessLayer.Repositories.Concrates
{
    /// <summary>
    /// EntityFramework için hazırlıyor olduğumuz bu repositoriyi daha önceden tasarladığımız generic repositorimiz olan IRepository arayüzünü implemente ederek tasarladık.
    /// Bu şekilde tasarlamamızın ana sebebi ise veritabanına independent(bağımsız) bir durumda kalabilmek. Örneğin MongoDB için ise ilgili provider'ı aracılığı ile MongoDBRepository tasarlayabiliriz.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(CustomerContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext can not be null.");

            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        #region IRepository Members
        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).SingleOrDefault();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            // Eğer sizlerde genelde bir kayıtı silmek yerine IsDelete şeklinde bool bir flag alanı tutuyorsanız,
            // Küçük bir refleciton kodu yardımı ile bunuda otomatikleştirebiliriz.
            if (entity.GetType().GetProperty("IsDelete") != null)
            {
                TEntity _entity = entity;

                _entity.GetType().GetProperty("IsDelete").SetValue(_entity, true);

                this.Update(_entity);
            }
            else
            {
                // Önce entity'nin state'ini kontrol etmeliyiz.
                 DbEntityEntry dbEntityEntry = _dbContext.Entry(entity);

                if (dbEntityEntry.State != EntityState.Deleted)
                {
                    dbEntityEntry.State = EntityState.Deleted;
                }
                else
                {
                    _dbSet.Attach(entity);
                    _dbSet.Remove(entity);
                }
            }
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity == null) return;
            else
            {
                if (entity.GetType().GetProperty("IsDelete") != null)
                {
                    TEntity _entity = entity;
                    _entity.GetType().GetProperty("IsDelete").SetValue(_entity, true);

                    this.Update(_entity);
                }
                else
                {
                    Delete(entity);
                }
            }
        }
        #endregion
    }
}


