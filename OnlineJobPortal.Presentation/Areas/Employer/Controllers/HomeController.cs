using Microsoft.AspNetCore.Mvc;

namespace OnlineJobPortal.Presentation.Areas.Employer.Controllers
{
    [Area("Employer")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
