﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using OnlineJobPortal.Application.Futures.AdminFeatures.Queries;
using OnlineJobPortal.Application.Futures.CandidateFeatures.Queries;
using OnlineJobPortal.Application.Futures.NotificationFeatures.Commands;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Presentation.SignalR;

namespace OnlineJobPortal.Presentation.Areas.Employer.Controllers
{
    [Area("Employer")]
    [Authorize]
    public class NotificationController : Controller
    {
        private readonly IMediator mediator;
        private readonly ICurrentUserService currentUserService;
        private readonly IHubContext<ITJobsHub> hub;

        public NotificationController(IMediator mediator,
            ICurrentUserService currentUserService,
            IHubContext<ITJobsHub> hub)
        {
            this.mediator = mediator;
            this.currentUserService = currentUserService;
            this.hub = hub;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveMessageAsync(string senderId, int conversationId, string content)
        {
            var message = new Message()
            {
                UserId = senderId,
                Content = content,
                ConversationId = conversationId,
                Timestamp = DateTime.Now
            };

            return Json(message);
        }

        [HttpPost]
        public async Task<IActionResult> SaveNotification(int candidateId, string title, string content, int resourceId)
        {
            string resourceName = "JobPost";
            var success = await mediator.Send(new CreateNotificationCommand(candidateId, title, content, resourceId, resourceName));
            return Json(success);
        }

        public async Task<IActionResult> GetAllAppliedCandidates()
        {
            var employerId = currentUserService.GetActorId();
            var data = await mediator.Send(new GetAllAppliedCandidatesQuery(employerId)) ;
            return Json(data);
        }
    }
}
