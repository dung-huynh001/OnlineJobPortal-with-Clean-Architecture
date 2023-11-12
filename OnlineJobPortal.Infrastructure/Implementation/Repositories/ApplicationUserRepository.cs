using Microsoft.AspNetCore.Identity;
using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Application.Models.Identity;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Implementation.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUserRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> ChangePassword(ChangePasswordRequest request)
        {
            var user = await _userManager.FindByIdAsync(request.Id);

            if (user != null)
            {
                var changePasswordResult = await _userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);

                if (changePasswordResult.Succeeded)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
