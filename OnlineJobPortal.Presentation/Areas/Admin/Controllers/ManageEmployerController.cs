using Microsoft.AspNetCore.Mvc;

namespace OnlineJobPortal.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManageEmployerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
