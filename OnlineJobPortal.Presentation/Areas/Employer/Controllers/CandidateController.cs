using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.ResumeFeatures.Queries;
using OnlineJobPortal.Application.Futures.SaveCandidateFeatures.Commands;
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

        public async Task<IActionResult> GetResumeByCandidateId(int candidateId)
        {
            var data = await mediator.Send(new GetResumeQuery(candidateId));
            return Json(data);
        }

        public async Task<IActionResult> SavedCandidates()
        {
            var data = await mediator.Send(new GetAllSavedCandidateQuery());
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> SaveCandidate(int candidateId)
        {
            int employerId = currentUserService.GetActorId();
            var success = await mediator.Send(new SaveCandidateCommand(candidateId, employerId));
            return Json(success);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSaveCandidate(int candidateId)
        {
            int employerId = currentUserService.GetActorId();
            var success = await mediator.Send(new DeleteSaveCandidateCommand(candidateId, employerId));
            return Json(success);
        }
    }
}
