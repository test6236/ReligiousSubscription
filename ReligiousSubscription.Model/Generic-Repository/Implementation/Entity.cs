using ReligiousSubscription.Model.Generic_Repository.Interface;

namespace ReligiousSubscription.Model.Generic_Repository.Implementation
{
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public virtual T Id { get; set; }
    }
}
