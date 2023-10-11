﻿using Microsoft.AspNetCore.Identity;
using OnlineJobPortal.Application.Models.Identity;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Contracts.Identity
{
    public interface IAuthService
    {
        Task<ApiResponse> LoginAsync(AuthRequest request);
        Task<ApiResponse> RegisterAsync(RegistrationRequest request);
    }
}
