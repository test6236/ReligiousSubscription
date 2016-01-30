using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using ReligiousSubscription.DataAccessLayer.Interfaces;
using ReligiousSubscription.Model.Generic_Repository;

namespace ReligiousSubscription.DataAccessLayer.Generic_Repository
{
    public abstract class GenericRepository<Model> : IGenericRepository<Model> where Model : BaseEntity
    {
        protected DbContext _entities;
        protected readonly IDbSet<Model> _dbset;

        public GenericRepository(DbContext context)
        {
            _entities = context;
            _dbset = context.Set<Model>();
        }

        public virtual IEnumerable<Model> GetAll()
        {
            return _dbset.AsEnumerable<Model>();
        }

        public IEnumerable<Model> FindBy(System.Linq.Expressions.Expression<Func<Model, bool>> predicate)
        {
            IEnumerable<Model> query = _dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual Model Add(Model entity)
        {
            return _dbset.Add(entity);
        }

        public virtual Model Delete(Model entity)
        {
            return _dbset.Remove(entity);
        }

        public virtual void Edit(Model entity)
        {
            _entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
