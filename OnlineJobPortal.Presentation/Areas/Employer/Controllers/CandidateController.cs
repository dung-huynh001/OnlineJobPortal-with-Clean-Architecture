using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.ResumeFeatures.Queries;
using OnlineJobPortal.Application.Interfaces;

namespace OnlineJobPortal.Presentation.Areas.Employer.Controllers
{
    [Area("Employer")]
    public class CandidateController : Controller
    {
        private readonly IMediator mediator;
        private readonly ICurrentUserService currentUserService;

        public CandidateController(IMediator mediator, ICurrentUserService currentUserService)
        {
            this.mediator = mediator;
            this.currentUserService = currentUserService;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ViewCandidateDetail()
        {
            return View();
        }

        public IActionResult AllCandidates() 
        {
            var data = mediator.Send(new GetAllCandidateSearchingJobsQuery()).GetAwaiter().GetResult();
            return View(data);
        }

        public IActionResult SavedCandidates()
        {
            return View();
        }
    }
}
