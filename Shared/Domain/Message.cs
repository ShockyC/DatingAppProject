using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Message : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Title does not meet length requirements")]
        public string MessageTitle { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime MessageDate { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must have typed in a message.")]
        public string MessageContent { get; set; }
        public int? SenderId { get; set; }
        public virtual Customer Sender { get; set; }
        public int? ReceiverId { get; set; }
        public virtual Customer Receiver { get; set; }
    }
}
