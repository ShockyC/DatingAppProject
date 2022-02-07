using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Title does not meet length requirements")]
        public string ReviewTitle { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Comment does not meet length requirements")]
        public string Comment { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
        public int? ReviewerId { get; set; }
        public virtual Customer Reviewer { get; set; }
        public int? RevieweeId { get; set; }
        public virtual Customer Reviewee { get; set; }
        public int? MeetingId { get; set; }
        public virtual Meeting Meeting { get; set; }
    }
}
