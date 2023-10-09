using Microsoft.AspNetCore.Identity;
using OnlineJobPortal.Application.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Contracts.Identity
{
    public interface IAuthService
    {
        Task<string> LoginAsync(AuthRequest request);
        Task<IdentityResult> RegisterAsync(RegistrationRequest request);
    }
}
