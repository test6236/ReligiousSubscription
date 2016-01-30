using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReligiousSubscription.Model.Generic_Repository.Implementation;

namespace ReligiousSubscription.Model.Person
{
    public class User : AuditableEntity<Int32>
    {
        public String Username { get; set; }
        public String Password { get; set; }

        public Treasurer TreasurerId { get; set; }
        public Member MemberId { get; set; }
        public Collector CollectorId { get; set; }
    }
}
