using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using OnlineJobPortal.Application.DTOs.CandidateDto;
using OnlineJobPortal.Application.Futures.CandidateFeatures.Commands;
using OnlineJobPortal.Application.Futures.CandidateFeatures.Queries;
using OnlineJobPortal.Application.Futures.ExperienceFeatures.Commands;
using OnlineJobPortal.Application.Futures.ResumeFeatures.Commands;
using OnlineJobPortal.Application.Futures.ResumeFeatures.Queries;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Presentation.Models;

namespace OnlineJobPortal.Presentation.Controllers
{

    public class ProfileController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;
        private readonly ICurrentUserService currentUserService;
        private readonly IUploadService uploadService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProfileController(IMapper mapper,
        IMediator mediator,
        ICurrentUserService currentUserService,
        IUploadService uploadService, IWebHostEnvironment webHostEnvironment)
        {
            this.mapper = mapper;
            this.mediator = mediator;
            this.currentUserService = currentUserService;
            this.uploadService = uploadService;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var candidateId = currentUserService.GetActorId();
            var result = mediator.Send(new GetCandidateProfileQuery(candidateId)).GetAwaiter().GetResult();
            return View(result);
        }

        public async Task<IActionResult> UpdateProfile(Candidate candidate)
        {
            try
            {
                var candidateDto = mapper.Map<UpdateCandidateDto>(candidate);
                var res = await mediator.Send(new UpdateCandidateCommand(candidateDto));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> UpdateAvatar(IFormFile avatarFile)
        {
            try
            {
                int actorId = currentUserService.GetActorId();
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/CandidateImg");
                string logoUrl = await uploadService.UploadImageAsync(avatarFile, uploadsFolder);

                var request = new UpdateAvatarCommand(actorId, logoUrl);
                var result = await mediator.Send(request);

                return Json(logoUrl);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }

        public IActionResult CreateOnlineProfile()
        {
            var model = new OnlineProfileViewModel();
            var candidateId = currentUserService.GetActorId();
            var candidate = mediator.Send(new GetCandidateProfileQuery(candidateId)).GetAwaiter().GetResult();

            var resume = mediator.Send(new GetResumeQuery(candidateId)).GetAwaiter().GetResult();

            model.Resume = resume;
            model.Candidate = candidate;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSummary(int id, string careerGoal)
        {
            var result = await mediator.Send(new UpdateCareerGoalCommand(id, careerGoal));
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSkills(int id, List<int> skillList)
        {
            var result = await mediator.Send(new UpdateResumeSkillCommand(id, skillList));
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddExperience(int resumeId, List<int>Skills, Experience experience)
        {
            var result = await mediator.Send(new CreateExperienceCommand(resumeId, Skills, experience));
            return Json(result);
        }
    }
}
