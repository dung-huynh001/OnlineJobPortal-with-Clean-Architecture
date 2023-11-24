using OnlineJobPortal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Domain.Entities
{
    public class Notification : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; } = false;
        public string UserId { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public ApplicationUser User { get; set; }
    }
}
