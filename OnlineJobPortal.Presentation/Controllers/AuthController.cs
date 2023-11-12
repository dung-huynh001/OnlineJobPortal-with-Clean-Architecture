using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlineJobPortal.Application.Contracts.Identity;
using OnlineJobPortal.Application.DTOs.CompanyDto;
using OnlineJobPortal.Application.DTOs.LocationDto;
using OnlineJobPortal.Application.Futures.CandidateFeatures.Queries;
using OnlineJobPortal.Application.Futures.CompanyFeatures.Commands;
using OnlineJobPortal.Application.Futures.DistrictFeatures.Commands;
using OnlineJobPortal.Application.Futures.LocationFeatures.Commands;
using OnlineJobPortal.Application.Futures.ProvinceFeatures.Commands;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Models.Identity;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Domain.Enums;
using OnlineJobPortal.Infrastructure.Identity;
using OnlineJobPortal.Presentation.Models;
using System.Net.Http;
using System.Net.Http.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OnlineJobPortal.Presentation.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> logger;
        private readonly HttpClient httpClient;
        private readonly ICurrentUserService currentUserService;
        private readonly IAuthService authService;
        private readonly IMapper mapper;
        private readonly IMediator mediator;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IUploadService uploadService;

        public AuthController(ILogger<AuthController> logger, 
            HttpClient httpClient, ICurrentUserService currentUserService, 
            IAuthService authService, IMapper mapper, IMediator mediator, 
            IWebHostEnvironment webHostEnvironment, IUploadService uploadService)
        {
            this.logger = logger;
            this.httpClient = httpClient;
            this.currentUserService = currentUserService;
            this.authService = authService;
            this.mapper = mapper;
            this.mediator = mediator;
            this.webHostEnvironment = webHostEnvironment;
            this.uploadService = uploadService;
            this.httpClient.BaseAddress = new Uri("https://localhost:7143");
        }

        [TempData]
        public string SuccessMessage { get; set; }


        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(AuthRequest request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await authService.LoginAsync(request);

                    if (!result.Success)
                    {
                        throw new Exception();
                    }

                    switch (result.Data)
                    {
                        case UserType.Candidate:
                            return RedirectToAction("Index", "Home");
                        case UserType.Employer :
                            return RedirectToAction("Index", "Home", new { area = "Employer" });
                        case UserType.Admin:
                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        default:
                            throw new Exception();
                    }
                }
                throw new Exception();
            }
            catch
            {
                ViewBag.ErrorMessage = "Vui lòng kiểm tra lại thông tin đăng nhập.";
                return View();
            }
            
        }

        [Route("/register")]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegistrationRequest request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await authService.RegisterAsync(request);
                    if (!result.Success)
                    {
                        if(result.Message.Equals("UserName already exist!"))
                        {
                            ViewBag.ErrorMessage = "Địa chỉ email đã được sử dụng.";
                            return View();
                        }
                        throw new Exception();
                    }
                    SuccessMessage = "Đăng ký ứng viên thành công";
                    return RedirectToAction("Login");
                }
                throw new Exception();
            }
            catch
            {
                ViewBag.ErrorMessage = "Vui lòng kiểm tra lại thông tin đăng ký.";
                return View();
            }
        }

        [HttpGet]
        public IActionResult RegisterEmployer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterEmployer([FromForm] RegisterEmployerViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/CompanyImg");
                    string logoUrl = await uploadService.UploadImageAsync(model.CompanyLogo, uploadsFolder);

                    model.LogoUrl = logoUrl;

                    var location = mapper.Map<CreateLocationDto>(model);
                    CreateLocationCommand createLocationCommand = new CreateLocationCommand();
                    createLocationCommand.Location = location;

                    var createLocationResponse = await mediator.Send(createLocationCommand);

                    var registerDto = mapper.Map<RegistrationEmployerRequest>(model);
                    var registerEmployerResponse = await authService.RegisterEmployerAsync(registerDto);

                    if (!registerEmployerResponse.Success)
                    {
                        if(registerEmployerResponse.Message.Equals("UserName already exist!"))
                        {
                            ViewBag.ErrorMessage = "Địa chỉ email đã được sử dụng";
                            return View(model);
                        }
                        throw new Exception();
                    }

                    SuccessMessage = "Đăng ký nhà tuyển dụng thành công.";
                    return RedirectToAction("Index", "Home", new { area = "Employer" });
                }
                throw new Exception();
            }
            catch
            {
                ViewBag.ErrorMessage = "Vui lòng kiểm tra lại thông tin đăng ký.";
                return View(model);
            }
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = currentUserService.UserId;
                var request = new ChangePasswordRequest();
                request.CurrentPassword = model.CurrentPassword;
                request.NewPassword = model.NewPassword;
                request.Id = userId;
                var result = await authService.ChangePassword(request);
                if (result)
                {
                    SuccessMessage = "Đổi mật khẩu thành công. Vui lòng đăng nhập lại";
                    await authService.Logout();
                    return RedirectToAction("Login"); ;
                }
                else
                {
                    ViewBag.PasswordChangeFailed = true;
                    return View();
                }
            }
            return View();
        }

        public async Task<IActionResult> GetInfo()
        {
            var actorId = currentUserService.GetActorId();
            var result = await mediator.Send(new GetCandidateProfileQuery(actorId));
            return Json(result);
        }

        public async Task<IActionResult> Logout()
        {
            await authService.Logout();
            return RedirectToAction("Index", "Home");
        }
    }
}
