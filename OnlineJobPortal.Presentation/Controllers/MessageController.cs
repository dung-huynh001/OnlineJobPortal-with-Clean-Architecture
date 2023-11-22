using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;
using OnlineJobPortal.Application.Futures.MessageFeatures.Commands;
using OnlineJobPortal.Application.Futures.MessageFeatures.Queries;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Presentation.Models;

namespace OnlineJobPortal.Presentation.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMapper mapper;
        private readonly ICurrentUserService currentUserService;
        private readonly IMediator mediator;
        private readonly IUploadService uploadService;

        public MessageController(IMapper mapper, 
            ICurrentUserService currentUserService, 
            IMediator mediator,
            IUploadService uploadService)
        {
            this.mapper = mapper;
            this.currentUserService = currentUserService;
            this.mediator = mediator;
            this.uploadService = uploadService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LoadMessages(int totalMessages, int conversationId, string recipientId)
        {
            string senderId = currentUserService.UserId!;
            int pageSize = 10;
            int pageNumber = totalMessages / pageSize + 1;
            var senderMessages = await mediator.Send(new GetMessageWithPaginationQuery(conversationId, senderId, pageNumber, pageSize));
            var recipientMessages = await mediator.Send(new GetMessageWithPaginationQuery(conversationId, recipientId, pageNumber, pageSize));
            var messages = senderMessages.Items.Concat(recipientMessages.Items).OrderBy(i => i.Timestamp).ToList();
            return Json(messages);
        }

        [HttpPost]
        public async Task<IActionResult> SaveMessage(int conversationId, string content)
        {
            var userId = currentUserService.UserId!;
            var success = await mediator.Send(new CreateMessageCommand(userId, conversationId, content));
            return Json(success);
        }
    }
}
