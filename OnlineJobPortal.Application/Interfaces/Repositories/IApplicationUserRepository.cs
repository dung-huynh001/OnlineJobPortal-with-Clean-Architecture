using OnlineJobPortal.Application.Models.Identity;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public interface IApplicationUserRepository
    {
        Task<bool> ChangePassword(ChangePasswordRequest request);
    }
}
