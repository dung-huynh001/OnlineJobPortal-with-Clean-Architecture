using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Models.Identity;

namespace OnlineJobPortal.Presentation.Models
{
	public class AuthViewModel
	{
		public AuthRequest AuthRequest { get; set; }

		public RegistrationRequest RegistrationRequest { get; set; }

    }
}
