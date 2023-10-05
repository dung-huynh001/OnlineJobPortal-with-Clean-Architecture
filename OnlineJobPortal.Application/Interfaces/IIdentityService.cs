using Microsoft.AspNetCore.Identity;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Interfaces
{
    public interface IIdentityService
    {
        Task<IdentityResult> CreateUserAsync(string username, string password);
        Task<SignInResult> SignInAsync(string username, string password, bool rememberMe);
        Task SignOutAsync();
        Task<ApplicationUser> GetUserByNameAsync(string username);
        Task<ApplicationUser> GetUserByIdAsync(string userId);
        Task<IEnumerable<Claim>> GetClaimsAsync(ApplicationUser user);
        Task<IdentityResult> AddClaimAsync(ApplicationUser user, Claim claim);
        Task<IdentityResult> RemoveClaimAsync(ApplicationUser user, Claim claim);
        Task<IdentityResult> ChangePasswordAsync(ApplicationUser user, string currentPassword, string newPassword);
    }
}
