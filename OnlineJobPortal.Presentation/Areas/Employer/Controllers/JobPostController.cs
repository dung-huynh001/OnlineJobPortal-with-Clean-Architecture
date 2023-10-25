using Microsoft.AspNetCore.Mvc;

namespace OnlineJobPortal.Presentation.Areas.Employer.Controllers
{
    [Area("Employer")]
    public class JobPostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PostANewJob()
        {
            return View();
        }
    }
}
