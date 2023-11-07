using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.DTOs.CandidateDto;
using OnlineJobPortal.Application.Futures.CandidateFeatures.Commands;
using OnlineJobPortal.Application.Futures.CandidateFeatures.Queries;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;

namespace OnlineJobPortal.Presentation.Controllers
{

    public class ProfileController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;
        private readonly ICurrentUserService currentUserService;
        public ProfileController(IMapper mapper, IMediator mediator, ICurrentUserService currentUserService)
        {
            this.mapper = mapper;
            this.mediator = mediator;
            this.currentUserService = currentUserService;
        }
        public IActionResult Index()
        {
            var candidateId = currentUserService.GetActorId();
            var result = mediator.Send(new GetCandidateProfileQuery(candidateId)).GetAwaiter().GetResult();
            return View(result);
        }

        public async Task<IActionResult> UpdateProfile(Candidate candidate){
            try{
                var candidateDto = mapper.Map<UpdateCandidateDto>(candidate);
                var res = await mediator.Send(new UpdateCandidateCommand(candidateDto));
                return RedirectToAction("Index");
            }
            catch{
                return View();
            }
        }

        public IActionResult CreateOnlineProfile(){
            return View();
        }
    }
}
