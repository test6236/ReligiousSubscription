using System.Collections.Generic;
using ReligiousSubscription.Model.Generic_Repository;

namespace ReligiousSubscription.DataAccessLayer.Interfaces
{
    public interface IEntityService<Model> : IService where Model : BaseEntity
    {
        void Create(Model entity);
        void Delete(Model entity);
        void Update(Model entity);

        IEnumerable<Model> GetAll();
    }
}
