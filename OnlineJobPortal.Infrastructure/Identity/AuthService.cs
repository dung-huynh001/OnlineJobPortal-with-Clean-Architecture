using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OnlineJobPortal.Application.Contracts.Identity;
using OnlineJobPortal.Application.DTOs.ApplicationDto;
using OnlineJobPortal.Application.DTOs.CandidateDto;
using OnlineJobPortal.Application.DTOs.CompanyDto;
using OnlineJobPortal.Application.DTOs.EmployerDto;
using OnlineJobPortal.Application.Futures.AdminFeatures.Commands;
using OnlineJobPortal.Application.Futures.CandidateFeatures.Commands;
using OnlineJobPortal.Application.Futures.EmployerFeatures.Commands;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Models.Identity;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Identity
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IMediator mediator;

        public AuthService(UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager,
            IConfiguration configuration, IMapper mapper, IMediator mediator)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _mapper = mapper;
            this.mediator = mediator;
        }

        public async Task<ApiResponse> LoginAsync(AuthRequest request)
        {
            var result = await _signInManager.PasswordSignInAsync(request.Email, request.Password, false, false);
            if (!result.Succeeded)
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Login Failed!"
                };
            }

            var user = await _userManager.FindByNameAsync(request.Email);
            var userType = user.UserType;

            await _signInManager.SignInAsync(user, true);

            var userRoles = await _userManager.GetRolesAsync(user);

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            foreach (var role in userRoles) 
            {
                authClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            var authKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"]));
            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:ValidIssuer"],
                audience: _configuration["JwtSettings:ValidAudience"],
                expires: DateTime.UtcNow.AddHours(2),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authKey,
                    SecurityAlgorithms.HmacSha512Signature)
            );

            return new ApiResponse
            {
                Success = true,
                Message = "Login Successfully!",
                Data = userType
            };
        }

        public async Task<ApiResponse> RegisterAsync(RegistrationRequest request)
        {
            var userExists = await _userManager.FindByNameAsync(request.Email);

            if (userExists != null)
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "UserName already exist!"
                };
            }

            if (!request.Password.Equals(request.PasswordConfirm))
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Confirm password does not match password"
                };
            }

            var user = new ApplicationUser
            {
                UserName = request.Email,
                Email = request.Email,
                UserType = request.UserType,
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "User creation failed!"
                };
            }

            var role = request.UserType.ToString();

            if (!await _roleManager.RoleExistsAsync(role))
            {
                await _roleManager.CreateAsync(new IdentityRole(role));
            }

            if(await _roleManager.RoleExistsAsync(role))
            {
                await _userManager.AddToRoleAsync(user, role);
            }

            switch (user.UserType)
            {
                case (UserType.Candidate):
                    var candidatedto = new CreateCandidateDto();
                    var createCandidateCommand = new CreateCandidateCommand();

                    candidatedto.UserId = user.Id;
                    candidatedto.FullName = request.FullName;

                    createCandidateCommand.CreateCandidateDto = candidatedto;
                    var createCandidateResponse = await mediator.Send(createCandidateCommand);

                    if (!createCandidateResponse.Success)
                    {
                        return new ApiResponse
                        {
                            Success = false,
                            Message = "Create candidate failed!"
                        };
                    }
                    break;
                case (UserType.Employer):
                    var employerdto = new CreateEmployerDto();
                    var createEmployerCommand = new CreateEmployerCommand();

                    employerdto.UserId = user.Id;
                    employerdto.FullName = request.FullName;

                    createEmployerCommand.CreateEmployerDto = employerdto;
                    var createEmployerResponse = await mediator.Send(createEmployerCommand);

                    if (!createEmployerResponse.Success)
                    {
                        return new ApiResponse
                        {
                            Success = false,
                            Message = "Create employer failed!"
                        };
                    }

                    break;
                default:
                    var admindto = new CreateAdminDto();
                    var createAdminCommand = new CreateAdminCommand();

                    admindto.UserId = user.Id;
                    admindto.FullName = request.FullName;

                    createAdminCommand.Admin = admindto;
                    var createAdminResponse = await mediator.Send(createAdminCommand);

                    if (!createAdminResponse.Success)
                    {
                        return new ApiResponse
                        {
                            Success = false,
                            Message = "Create admin failed!"
                        };
                    }

                    break;
            }

            return new ApiResponse
            {
                Success = true,
                Message = "User created successfully!"
            };
        }

        public async Task<ApiResponse> RegisterEmployerAsync(RegistrationEmployerRequest request)
        {
            try
            {
                var userExists = await _userManager.FindByNameAsync(request.Email);

                if (userExists != null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "UserName already exist!"
                    };
                }

                if (!request.Password.Equals(request.PasswordConfirm))
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Confirm password does not match password"
                    };
                }

                var user = new ApplicationUser
                {
                    UserName = request.Email,
                    Email = request.Email,
                    UserType = request.UserType,
                };

                var result = await _userManager.CreateAsync(user, request.Password);

                if (!result.Succeeded)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "User creation failed!"
                    };
                }

                var role = request.UserType.ToString();

                if (!await _roleManager.RoleExistsAsync(role))
                {
                    await _roleManager.CreateAsync(new IdentityRole(role));
                }

                if (await _roleManager.RoleExistsAsync(role))
                {
                    await _userManager.AddToRoleAsync(user, role);
                }

                var employerDto = _mapper.Map<CreateEmployerDto>(request);
                var companyDto = _mapper.Map<CreateCompanyDto>(request);
                var createEmployerCommand = new CreateEmployerCommand();
                createEmployerCommand.CreateEmployerDto = employerDto;
                createEmployerCommand.CreateCompanyDto = companyDto;

                employerDto.UserId = user.Id;

                var createEmployerResponse = await mediator.Send(createEmployerCommand);

                if (!createEmployerResponse.Success)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Create employer failed!"
                    };
                }

                return new ApiResponse
                {
                    Success = true,
                    Message = "User created successfully!"
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "User create failed!"
                };
            }
        }
        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
