using Microsoft.AspNetCore.Mvc;

namespace OnlineJobPortal.Presentation.Areas.Employer.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ViewCandidateDetail()
        {
            return View();
        }
    }
}
