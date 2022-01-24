using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime MessageDate { get; set; }
        public string MessageContent { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
