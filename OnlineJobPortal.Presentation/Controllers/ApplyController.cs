using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.DTOs.ApplyDto;
using OnlineJobPortal.Application.Futures.ApplyFeatures.Commands;
using OnlineJobPortal.Application.Futures.ApplyFeatures.Queries;
using OnlineJobPortal.Application.Futures.CandidateFeatures.Queries;
using OnlineJobPortal.Application.Futures.ConversationFeatures.Commands;
using OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Commands;
using OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Queries;
using OnlineJobPortal.Application.Futures.ParticipationFeatures.Commands;
using OnlineJobPortal.Application.Futures.ResumeFeatures.Queries;
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
        private readonly IUploadService uploadService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ApplyController(IMapper mapper, 
            IMediator mediator, 
            ICurrentUserService currentUserService, 
            IUploadService uploadService,
            IWebHostEnvironment webHostEnvironment)
        {
            this.mapper = mapper;
            this.mediator = mediator;
            this.currentUserService = currentUserService;
            this.uploadService = uploadService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        public IActionResult ApplyJob(int jobPostId, string? coverLetter, IFormFile? cv)
        {
            try
            {
                int candidateId = currentUserService.GetActorId();
                string? cvUrl = mediator.Send(new GetCvUrlQuery(candidateId)).GetAwaiter().GetResult();

                if (cv != null)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/CVs");
                    cvUrl = uploadService.UploadImageAsync(cv, uploadsFolder).GetAwaiter().GetResult();
                }

                if (cvUrl == null)
                {
                    throw new Exception();
                }

                var applyJobDto = new CreateApplyDto();
                applyJobDto.JobPostId = jobPostId;
                applyJobDto.CandidateId = candidateId;
                applyJobDto.Status = "pending";
                applyJobDto.CoverLetter = coverLetter ?? "";
                applyJobDto.CvUrl = cvUrl;
                var applyId = mediator.Send(new ApplyJobCommand(applyJobDto)).Result;
                var conversationId = mediator.Send(new CreateConversationCommand(applyId)).Result;
                if ( applyId == 0 || conversationId == 0) throw new Exception();

                string userId = currentUserService.UserId!;
                var participation = mediator.Send(new CreateParticipationCommand(userId, conversationId)).Result;
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        public async Task<IActionResult> IsValidCandidateInfo()
        {
            int candidateId = currentUserService.GetActorId();
            var isValid = await mediator.Send(new IsValidCandidateInfoQuery(candidateId));
            return Json(isValid);
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
            var data = mediator.Send(new GetAllAppliedJobsQuery(candidateId)).GetAwaiter().GetResult();
            return View(data);
        }

        public async Task<IActionResult> CancelJob(int id) 
        {
            var result = await mediator.Send(new CancelJobCommand(id));
            return Json(new { success = result });
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
