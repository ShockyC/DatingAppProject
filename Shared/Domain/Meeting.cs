using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Meeting : BaseDomainModel
    {
        public DateTime MeetingTime { get; set; }
        public string Location { get; set; }
        public int HostId { get; set; }
        public virtual Customer Customer { get; set; }
        public int ParticipantId { get; set; }
    }
}
