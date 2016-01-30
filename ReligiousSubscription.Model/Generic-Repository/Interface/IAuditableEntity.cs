using System;

namespace ReligiousSubscription.Model.Generic_Repository.Interface
{
    public interface IAuditableEntity
    {
        DateTime CreatedDate { get; set; }
        String CreatedBy { get; set; }

        DateTime UpdatedDate { get; set; }
        String UpdatedBy { get; set; }
    }
}
