using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Models.Identity
{
    public class RegistrationRequest
    {
        [Required]
        public UserType UserType { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(6), MaxLength(50)]
        public string Password { get; set; } 
        
        [Required, MinLength(6), MaxLength(50)]
        public string PasswordConfirm { get; set; }


    }
}
