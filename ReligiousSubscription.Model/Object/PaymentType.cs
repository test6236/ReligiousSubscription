using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReligiousSubscription.Model.Generic_Repository.Implementation;

namespace ReligiousSubscription.Model.Object
{
    public class PaymentType : AuditableEntity<Int32>
    {
        public String Name { get; set; }

        public Decimal Amount { get; set; }

        public String Date { get; set; }
        public String Description { get; set; }
    }
}
