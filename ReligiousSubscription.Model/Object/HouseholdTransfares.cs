using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReligiousSubscription.Model.Person;
using ReligiousSubscription.Model.Generic_Repository.Implementation;

namespace ReligiousSubscription.Model.Object
{
    public class HouseholdTransfares : AuditableEntity<Int32>
    {
        public Member Who { get; set; }
        public Household From { get; set; }
        public Household To { get; set; }

        public String Reason { get; set; }

        public String DateTransfared { get; set; }
    }
}
