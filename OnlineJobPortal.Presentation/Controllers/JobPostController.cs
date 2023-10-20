using Microsoft.AspNetCore.Mvc;

namespace OnlineJobPortal.Presentation.Controllers
{
    public class JobPostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FindJob()
        {
            return View();  
        }

        [HttpGet]
        public IActionResult JobDetail(int id)
        {
            return View();
        }

        public IActionResult JobList() 
        { 
            return View(); 
        }
    }
}
