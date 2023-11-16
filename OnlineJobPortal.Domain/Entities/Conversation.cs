using OnlineJobPortal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Domain.Entities
{
    public class Conversations : BaseEntity
    {
        public virtual ICollection<Participation> Participations { get; set; } = new List<Participation>();
        public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}
