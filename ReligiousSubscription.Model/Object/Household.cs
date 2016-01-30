using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReligiousSubscription.Model.Person;
using ReligiousSubscription.Model.Generic_Repository.Implementation;

namespace ReligiousSubscription.Model.Object
{
    public class Household : AuditableEntity<Int32>
    {
        public String HouseholdName { get; set; }

        public Member Carrier { get; set; }

        public IList<Member> Members { get; set; }

        public Payment Payments { get; set; }
    }
}
