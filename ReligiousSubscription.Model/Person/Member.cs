using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReligiousSubscription.Model.Generic_Repository.Implementation;

namespace ReligiousSubscription.Model.Person
{
    public class Member : AuditableEntity<Int32> 
    {
        public String Name { get; set; }
        public String FathersName { get; set; }
        public String LastName { get; set; }
        
        public String DateOfBirth { get; set; }
        public String PlaceOfBirth { get; set; }

        public String JMBG { get; set; }
        public String Address { get; set; }

        public String Email { get; set; }
        public String Phone { get; set; }

        public String MemberCardId { get; set; }
    }
}
