using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class CustomerPreference
    {
        public int CustPrefId { get; set; }
        public string CustomerPrefValue { get; set; }
        public int CustomerId { get; set; }
        public int PrefId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Preference Preference { get; set; }
    }
}
