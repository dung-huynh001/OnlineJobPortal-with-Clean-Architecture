using Microsoft.AspNetCore.Mvc;

namespace OnlineJobPortal.Presentation.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
