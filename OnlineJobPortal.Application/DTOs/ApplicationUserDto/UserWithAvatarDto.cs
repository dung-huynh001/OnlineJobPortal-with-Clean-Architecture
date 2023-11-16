using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.ApplicationUserDto
{
    public class UserWithAvatarDto
    {
        public string UserId { get; set; }
        public string AvatarUrl { get; set; }
    }
}
