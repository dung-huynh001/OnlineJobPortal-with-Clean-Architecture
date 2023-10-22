using Microsoft.AspNetCore.Mvc;

namespace OnlineJobPortal.Presentation.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CompanyDetail(int id) 
        {
            return View();
        }

        public IActionResult TopCompany() 
        { 
            return View();
        }
    }
}
