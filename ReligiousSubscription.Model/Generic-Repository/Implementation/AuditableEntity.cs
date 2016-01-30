using System;
using System.ComponentModel.DataAnnotations;

using ReligiousSubscription.Model.Generic_Repository.Interface;

namespace ReligiousSubscription.Model.Generic_Repository.Implementation
{
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public String CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdatedDate { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public String UpdatedBy { get; set; }
    }
}
