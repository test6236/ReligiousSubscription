using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReligiousSubscription.Model.Generic_Repository.Implementation;

namespace ReligiousSubscription.Model.Person
{
    public class Collector : AuditableEntity<Int32>
    {
        public String Name { get; set; }
        public String Lastname { get; set; }
    }
}
