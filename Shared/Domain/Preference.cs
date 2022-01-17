using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Preference : BaseDomainModel
    {
        public string PrefName { get; set; }
        public string PrefDescription { get; set; }
    }
}
