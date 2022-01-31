using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Complaint : BaseDomainModel
    {
        [Required]
        public string ComplaintTitle { get; set; }
        [Required]
        public string ComplaintType { get; set; }
        [Required]
        public string ComplaintDescription { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [Required]
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
