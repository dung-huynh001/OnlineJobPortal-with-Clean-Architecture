using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.NotificationFeatures.Commands
{
    public class CreateNotificationCommand : IRequest<bool>
    {
        public CreateNotificationCommand(int actorId, string title, string content, int resourceId, string resourceName)
        {
            ActorId = actorId;
            Title = title;
            Content = content;
            ResourceId = resourceId;
            ResourceName = resourceName;
        }
        public int ActorId { get; }
        public string Title { get; }
        public string Content { get; }
        public int ResourceId { get; }
        public string ResourceName { get; }
    }

    public class CreateNotificationCommandHandler : IRequestHandler<CreateNotificationCommand, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateNotificationCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(CreateNotificationCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var user = await unitOfWork.Repository<Candidate>().GetByIdAsync(request.ActorId);

                var notification = new Notification();
                notification.UserId = user!.UserId;
                notification.Title = request.Title;
                notification.Content = request.Content;
                notification.ResourceId = request.ResourceId;
                notification.ResourceName = request.ResourceName;

                await unitOfWork.Repository<Notification>().AddAsync(notification);

                unitOfWork.Commit();
                return true;
            }
            catch
            {
                unitOfWork.Rollback();
                return false;
            }
        }
    }
}
