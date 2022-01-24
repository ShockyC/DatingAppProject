using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class ReviewOnCustomer
    {
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int ReviewerId { get; set; }
        public int RevieweeId { get; set; }
        public int MeetingId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Meeting Meeting { get; set; }
    }
}
