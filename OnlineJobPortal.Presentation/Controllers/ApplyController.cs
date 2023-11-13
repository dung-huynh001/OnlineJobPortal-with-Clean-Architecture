using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Commands;
using OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Queries;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;

namespace OnlineJobPortal.Presentation.Controllers
{
    [Authorize(Roles = "Candidate")]   
    
    public class ApplyController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;
        private readonly ICurrentUserService currentUserService;

        public ApplyController(IMapper mapper, IMediator mediator, ICurrentUserService currentUserService)
        {
            this.mapper = mapper;
            this.mediator = mediator;
            this.currentUserService = currentUserService;
        }
        public IActionResult ApplyJob(int jobId)
        {
            return View();
        }

        public IActionResult SavedJobs()
        {
            var candidateId = currentUserService.GetActorId();
            var data = mediator.Send(new GetAllJobFavoriteQuery(candidateId)).GetAwaiter().GetResult();
            return View(data);
        }

        public IActionResult AppliedJobs()
        {
            var candidateId = currentUserService.GetActorId();
            return View();
        }

        public async Task<IActionResult> FavoriteJob(int jobId)
        {
            var candidateId = currentUserService.GetActorId();
            var result = await mediator.Send(new FavoriteJobCommand(jobId, candidateId));
            return Json(result);
        }

        public async Task<IActionResult> DeleteFavorite(int jobId)
        {
            var candidateId = currentUserService.GetActorId();
            var result = await mediator.Send(new DeleteJobFavoriteCommand(jobId, candidateId));
            return Json(result);
        }
    }
}
