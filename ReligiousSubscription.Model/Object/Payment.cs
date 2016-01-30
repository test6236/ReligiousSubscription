using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReligiousSubscription.Model.Person;
using ReligiousSubscription.Model.Generic_Repository.Implementation;

namespace ReligiousSubscription.Model.Object
{
    public class Payment : AuditableEntity<Int32>
    {
        public Collector ColectorId { get; set; }

        public String PaimentDate { get; set; }
        public PaymentType Price { get; set; }

        public String ReasonForFreeing { get; set; }
        public Boolean isFreeFromPaiment { get; set; }
    }
}
