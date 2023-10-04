using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Interfaces
{
    public interface IIdentityService
    {
        Task<string?> GetUserNameAsync(string userId);

        Task<bool> IsInRoleAsync(string userId, string role);

        Task<bool> AuthorizeAsync(string userId, string policyName);

        Task<(bool Success, string UserId)> CreateUserAsync(string userName, string password);

        Task<bool> DeleteUserAsync(string userId);
    }
}
