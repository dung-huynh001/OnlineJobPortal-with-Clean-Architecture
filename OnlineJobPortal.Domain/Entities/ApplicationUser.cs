using Microsoft.AspNetCore.Identity;
using OnlineJobPortal.Domain.Enums;

namespace OnlineJobPortal.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public UserType UserType { get; set; }
        public virtual ICollection<Participation>? Participations { get; set; }
        public virtual ICollection<Message>? Messages { get; set; }
        public virtual ICollection<Notification>? Notifications { get; set; }

    }
}
