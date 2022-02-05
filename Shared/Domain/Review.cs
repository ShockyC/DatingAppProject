using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public string ReviewTitle { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public DateTime ReviewDate { get; set; }
        public int? ReviewerId { get; set; }

        public virtual Customer Reviewer { get; set; }
        public int? RevieweeId { get; set; }
        public virtual Customer Reviewee { get; set; }
        public int? MeetingId { get; set; }
        public virtual Meeting Meeting { get; set; }
    }
}
