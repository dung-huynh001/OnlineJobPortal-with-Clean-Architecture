using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlineJobPortal.Application.Contracts.Identity;
using OnlineJobPortal.Application.DTOs.CompanyDto;
using OnlineJobPortal.Application.DTOs.LocationDto;
using OnlineJobPortal.Application.Futures.CompanyFeatures.Commands;
using OnlineJobPortal.Application.Futures.DistrictFeatures.Commands;
using OnlineJobPortal.Application.Futures.LocationFeatures.Commands;
using OnlineJobPortal.Application.Futures.ProvinceFeatures.Commands;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Models.Identity;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Identity;
using OnlineJobPortal.Presentation.Models;
using System.Net.Http;
using System.Net.Http.Json;

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

        public AuthController(ILogger<AuthController> logger, HttpClient httpClient, ICurrentUserService currentUserService, IAuthService authService, IMapper mapper, IMediator mediator)
        {
            this.logger = logger;
            this.httpClient = httpClient;
            this.currentUserService = currentUserService;
            this.authService = authService;
            this.mapper = mapper;
            this.mediator = mediator;
            this.httpClient.BaseAddress = new Uri("https://localhost:7143");
        }

        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(AuthRequest request)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await authService.LoginAsync(request);

                    if (!result.Success)
                    {
                        ViewBag.ErrorMessage = "Vui lòng kiểm tra lại thông tin đăng nhập.";
                        return View();
                    }

                    return RedirectToAction("Index", "Home");
                }
                catch
                {
                    return View();
                }
            }
            ViewBag.ErrorMessage = "Vui lòng kiểm tra lại thông tin đăng nhập.";
            return View();
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
                        throw new Exception();
                    }
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
        public async Task<IActionResult> RegisterEmployer(RegisterEmployerViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var location = mapper.Map<CreateLocationDto>(model);
                    CreateLocationCommand createLocationCommand = new CreateLocationCommand();
                    createLocationCommand.Location = location;

                    var createLocationResponse = await mediator.Send(createLocationCommand);

                    var registerDto = mapper.Map<RegistrationEmployerRequest>(model);
                    var registerEmployerResponse = await authService.RegisterEmployerAsync(registerDto);

                    if (!registerEmployerResponse.Success)
                    {
                        throw new Exception();
                    }

                    return RedirectToAction("Index", "Home", new {area = "Employer"});
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

        public async Task<IActionResult> Logout()
        {
            await authService.Logout();
            return RedirectToAction("Index", "Home");
        }
    }
}
