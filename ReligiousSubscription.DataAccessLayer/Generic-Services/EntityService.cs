using System;
using System.Collections.Generic;

using ReligiousSubscription.DataAccessLayer.Interfaces;
using ReligiousSubscription.Model.Generic_Repository;

namespace ReligiousSubscription.DataAccessLayer.Services
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        IGenericRepository<T> _repository;

        public EntityService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Create Failed.");
            }
            _repository.Add(entity);
            _repository.Save();
        }

        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Update Failed.");
            _repository.Edit(entity);
            _repository.Save();
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Delete Failed.");
            _repository.Delete(entity);
            _repository.Save();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
