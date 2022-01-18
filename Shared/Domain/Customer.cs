using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Race { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EducationLevel { get; set; }
        public string Occupation { get; set; }
        public int Contact { get; set; }
    }
}
