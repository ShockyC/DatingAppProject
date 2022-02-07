using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Meeting : BaseDomainModel
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime MeetingTime { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Location does not meet length requirements")]
        public string Location { get; set; }
        [Required]
        public int? HostId { get; set; }
        public virtual Customer Host { get; set; }
        [Required]
        public int? ParticipantId { get; set; }
        public virtual Customer Participant { get; set; }
    }
}
