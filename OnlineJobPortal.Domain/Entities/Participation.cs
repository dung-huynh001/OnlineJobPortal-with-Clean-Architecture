using Microsoft.VisualBasic;
using OnlineJobPortal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Domain.Entities
{
    public class Participation : BaseEntity
    {

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public int ConversationId { get; set; }
        public virtual Conversations Conversations { get; set; }
    }
}
