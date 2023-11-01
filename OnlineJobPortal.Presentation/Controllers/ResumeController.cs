using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineJobPortal.Presentation.Controllers
{
    //[Authorize(Roles = "Candidate")]
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateResume()
        {
            return View();
        }

        public IActionResult EditResume()
        {
            return View();
        }
    }
}
