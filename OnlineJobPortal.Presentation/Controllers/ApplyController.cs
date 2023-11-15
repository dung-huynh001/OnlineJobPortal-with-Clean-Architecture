﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.DTOs.ApplyDto;
using OnlineJobPortal.Application.Futures.ApplyFeatures.Commands;
using OnlineJobPortal.Application.Futures.ApplyFeatures.Queries;
using OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Commands;
using OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Queries;
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
        public IActionResult ApplyJob(int jobPostId, string? coverLetter, IFormFile? cv)
        {
            try
            {
                int candidateId = currentUserService.GetActorId();
                string? cvUrl = mediator.Send(new GetCvUrlQuery(candidateId)).GetAwaiter().GetResult();
                if (cvUrl == null)
                {
                    throw new Exception();
                }

                if(cv != null)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/CVs");
                    cvUrl = uploadService.UploadImageAsync(cv, uploadsFolder).GetAwaiter().GetResult();
                }

                var applyJobDto = new CreateApplyDto();
                applyJobDto.JobPostId = jobPostId;
                applyJobDto.CandidateId = candidateId;
                applyJobDto.Status = "pending";
                applyJobDto.CoverLetter = coverLetter ?? "";
                applyJobDto.CvUrl = cvUrl;
                var result = mediator.Send(new ApplyJobCommand(applyJobDto)).GetAwaiter().GetResult();
                if (!result.Success) throw new Exception();
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
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