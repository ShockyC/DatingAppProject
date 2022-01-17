using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Complaint : BaseDomainModel
    {
        public string ComplaintTitle { get; set; }
        public string ComplaintType { get; set; }
        public string ComplaintDescription { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
