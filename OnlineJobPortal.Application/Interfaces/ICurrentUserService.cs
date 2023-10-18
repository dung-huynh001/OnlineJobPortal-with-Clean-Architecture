using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Interfaces
{
    public interface ICurrentUserService
    {
        string? UserId { get; }
        public string GetFullNameById();
    }
}
