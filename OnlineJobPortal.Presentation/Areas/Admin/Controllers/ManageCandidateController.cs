using Microsoft.AspNetCore.Mvc;

namespace OnlineJobPortal.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManageCandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
