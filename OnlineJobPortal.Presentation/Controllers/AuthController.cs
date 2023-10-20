using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Contracts.Identity;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Models.Identity;
using OnlineJobPortal.Application.Responses;
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

        public AuthController(ILogger<AuthController> logger, HttpClient httpClient, ICurrentUserService currentUserService, IAuthService authService)
        {
            this.logger = logger;
			this.httpClient = httpClient;
            this.currentUserService = currentUserService;
            this.authService = authService;
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
                var response = await httpClient.PostAsJsonAsync("api/Auth/Register", request);
                if (response.IsSuccessStatusCode)
                {
                    // Xử lý dữ liệu từ API ở đây
                    var result = await response.Content.ReadFromJsonAsync<ApiResponse>();
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.ErrorMessage = "Vui lòng kiểm tra lại thông tin đăng ký.";
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            try
            {
                await authService.Logout();
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
