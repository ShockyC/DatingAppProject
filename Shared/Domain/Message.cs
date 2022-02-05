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
        public string MessageTitle { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime MessageDate { get; set; }
        [Required]
        public string MessageContent { get; set; }
        [Required]
        public int? SenderId { get; set; }
        public virtual Customer Sender { get; set; }
        [Required]
        public int? ReceiverId { get; set; }
        public virtual Customer Receiver { get; set; }
    }
}
