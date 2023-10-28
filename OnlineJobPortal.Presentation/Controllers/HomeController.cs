using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Presentation.Models;
using System.Diagnostics;

namespace OnlineJobPortal.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICurrentUserService currentUserService;

        public HomeController(ILogger<HomeController> logger, ICurrentUserService currentUserService)
        {
            _logger = logger;
            this.currentUserService = currentUserService;
        }

        public IActionResult Index()
        {
            if (HttpContext.User.Identity!.IsAuthenticated)
            {
                ViewBag.FullName = currentUserService.GetFullNameById();
                var useType = currentUserService.UsrType;
                switch(useType.ToLower()) 
                {
                    case "admin":
                        return RedirectToAction("Index", "Home", new {area = "Admin"});
                    case "employer":
                        return RedirectToAction("Index", "Home", new { area = "Employer" });
                    default:
                        break;
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}