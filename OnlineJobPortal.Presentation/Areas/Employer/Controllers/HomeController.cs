using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.StatisticalFeatures.Queries;
using OnlineJobPortal.Application.Interfaces;

namespace OnlineJobPortal.Presentation.Areas.Employer.Controllers
{
    [Area("Employer")]
    [Authorize]
    [Authorize(Roles = "Employer")]
    public class HomeController : Controller
    {
        private readonly IMediator mediator;
        private readonly ICurrentUserService currentUserService;
        public HomeController(IMediator mediator, ICurrentUserService currentUserService)
        {
            this.mediator = mediator;
            this.currentUserService = currentUserService;
        }
        public IActionResult Index()
        {
            var employerId = currentUserService.GetActorId();
            var data = mediator.Send(new EmployerStatisticalQuery(employerId)).Result;
            return View(data);
        }

    }
}
