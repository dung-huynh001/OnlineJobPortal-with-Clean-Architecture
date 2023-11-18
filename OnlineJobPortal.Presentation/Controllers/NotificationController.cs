using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using OnlineJobPortal.Application.Futures.EmployerFeatures.Queries;
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
            return View();
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

        public async Task<IActionResult> SaveMessageAsync(string senderId, int conversationId, string content)
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
