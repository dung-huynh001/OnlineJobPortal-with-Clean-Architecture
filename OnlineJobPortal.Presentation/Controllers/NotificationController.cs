using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using OnlineJobPortal.Application.Futures.EmployerFeatures.Queries;
using OnlineJobPortal.Application.Futures.MessageFeatures.Queries;
using OnlineJobPortal.Application.Futures.NotificationFeatures.Queries;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Presentation.Models;
using OnlineJobPortal.Presentation.SignalR;

namespace OnlineJobPortal.Presentation.Controllers
{
    [Authorize]
    public class NotificationController : Controller
    {
        private readonly IHubContext<ITJobsHub> hubContext;
        private readonly IMediator mediator;
        private readonly ICurrentUserService currentUserService;

        public NotificationController(IHubContext<ITJobsHub> hubContext, 
            IMediator mediator, 
            ICurrentUserService currentUserService)
        {
            this.hubContext = hubContext;
            this.mediator = mediator;
            this.currentUserService = currentUserService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Notifies()
        {
            string userId = currentUserService.UserId!;
            var notifications = mediator.Send(new GetAllNotificationsQuery(userId)).Result;
            return View(notifications);
        }

        public IActionResult Chat()
        {
            return View();
        }

        public async Task<IActionResult> GetAllAppliedEmployers()
        {
            var candidateId = currentUserService.GetActorId();
            var data = await mediator.Send(new GetAllAppliedEmployersQuery(candidateId));
            return Json(data);
        }

        [HttpGet]
        public async Task<IActionResult> GetAppliedJobGroup()
        {
            int candidateId = currentUserService.GetActorId();
            var jobPostIds = await mediator.Send(new GetAppliedJobGroupQuery(candidateId));
            return Json(jobPostIds);
        }

        [HttpGet]
        [Authorize(Roles = "Employer")]
        public async Task<IActionResult> GetJobPostGroup()
        {
            int employerId = currentUserService.GetActorId();
            var jobPostIds = await mediator.Send(new GetJobPostGroupQuery(employerId));
            return Json(jobPostIds);
        }

        [HttpGet]
        public async Task<IActionResult> GetTitleOfNotification()
        {
            string userId = currentUserService.UserId!;
            var notificaitons = await mediator.Send(new GetTitleToNotifyQuery(userId));
            return Json(notificaitons);
        }

        [HttpGet]
        public async Task<IActionResult> GetNumberOfUnreadNotifications()
        {
            string userId = currentUserService.UserId!;
            var numberOfUnread = await mediator.Send(new GetTotalUnReadNotificationQuery(userId));
            return Json(numberOfUnread);
        }

        /*[HttpPost]
        [Authorize]
        public async Task<IActionResult> SendMessage(string message)
        {
            var currentUser = User.Identity.Name;
            var announcement = new AnnouncementViewModel { Content = message };

            // Gửi tin nhắn tới tất cả người dùng
            ITJobsHub.PushToAllUsers(announcement, _hubContext);

            // Gửi tin nhắn riêng tới người gửi
            ITJobsHub.PushToUser(currentUser, announcement, _hubContext);

            return RedirectToAction("Index");
        }*/
    }

}
