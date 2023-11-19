using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Presentation.Models;

namespace OnlineJobPortal.Presentation.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SaveMessage(MessageViewModel model)
        {
            return Ok(model);
        }
    }
}
