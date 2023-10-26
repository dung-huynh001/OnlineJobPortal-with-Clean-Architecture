using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Presentation.Areas.Employer.Models;

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

        [HttpPost]
        public IActionResult PostANewJob(JobPostViewModel model)
        {
            return View();
        }
    }
}
