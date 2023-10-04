using Microsoft.AspNetCore.Identity;
using OnlineJobPortal.Domain.Enums;

namespace OnlineJobPortal.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public UserType UserType { get; set; }
    }
}
