using OnlineJobPortal.Domain.Enums;

namespace OnlineJobPortal.Presentation.Models
{
    public class RegisterEmployerViewModel
    {
        // Employer Info
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public UserType UserType { get; set; }

        // Company Info
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string WebsiteUrl { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
    }
}
