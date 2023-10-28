using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Implementation
{
    public class CurrentUserSevice : ICurrentUserService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IApplicationDbContext applicationDbContext;

        public CurrentUserSevice(IHttpContextAccessor httpContextAccessor, IApplicationDbContext applicationDbContext)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.applicationDbContext = applicationDbContext;
        }
        public string? UserId => httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        public string? UsrType => httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Role);

        public int GetActorId()
        {
            var userId = this.UserId;
            var userType = applicationDbContext.ApplicationUsers.FirstOrDefault(a => a.Id.Equals(userId))!.UserType;

            int actorId = 0;
            switch (userType)
            {
                case UserType.Admin:
                    var admin = applicationDbContext.Admins.FirstOrDefault(e => e.UserId.Equals(userId));
                    actorId = admin!.Id;
                    break;
                case UserType.Candidate:
                    var candidate = applicationDbContext.Candidates.FirstOrDefault(e => e.UserId.Equals(userId));
                    actorId = candidate!.Id;
                    break;
                default:
                    var employer = applicationDbContext.Employers.FirstOrDefault(e => e.UserId.Equals(userId));
                    actorId = employer!.Id;
                    break;
            }
            return actorId;
        }

        public string GetFullNameById()
        {
            var userId = this.UserId;
            var userType = applicationDbContext.ApplicationUsers.FirstOrDefault(a => a.Id.Equals(userId))!.UserType;

            string fullname = "";
            switch (userType)
            {
                case UserType.Admin:
                    var admin = applicationDbContext.Admins.FirstOrDefault(e => e.UserId.Equals(userId));
                    fullname = admin!.FullName;
                    break;
                case UserType.Candidate:
                    var candidate = applicationDbContext.Candidates.FirstOrDefault(e => e.UserId.Equals(userId));
                    fullname = candidate!.FullName;
                    break;
                default:
                    var employer = applicationDbContext.Employers.FirstOrDefault(e => e.UserId.Equals(userId));
                    fullname = employer!.FullName;
                    break;
            }
            return fullname;
        }
    }
}
