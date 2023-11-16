using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.DTOs.ApplicationUserDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Application.Models.Identity;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Domain.Enums;
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
        private readonly IApplicationDbContext context;

        public ApplicationUserRepository(UserManager<ApplicationUser> userManager, IApplicationDbContext context)
        {
            _userManager = userManager;
            this.context = context;
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

        public async Task<UserWithAvatarDto> GetAvatarUser(string userId)
        {
            var user = await context.ApplicationUsers.FindAsync(userId);
            var result = new UserWithAvatarDto();
            switch (user.UserType)
            {
                case UserType.Employer:
                    var employer = context.Employers.Include(e => e.Company)
                        .FirstOrDefault(e => e.UserId.Equals(userId));
                    result.UserId = user.Id;
                    result.AvatarUrl = employer.Company.LogoUrl;
                    return result;
                case UserType.Admin:
                    var admin = context.Admins.FirstOrDefault(a => a.UserId.Equals(user.Id));
                    result.UserId = user.Id;
                    result.AvatarUrl = "";
                    return result;
                case UserType.Candidate:
                    var candidate = context.Candidates.FirstOrDefault(a => a.UserId.Equals(user.Id));
                    result.UserId = user.Id;
                    result.AvatarUrl = candidate.AvatarUrl;
                    return result;
            }
            throw new NotImplementedException();
        }
    }
}
