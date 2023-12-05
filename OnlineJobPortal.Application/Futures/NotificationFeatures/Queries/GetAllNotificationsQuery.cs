using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.DTOs.NotificationDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.NotificationFeatures.Queries
{
    public class GetAllNotificationsQuery :  IRequest<List<GetNotificationDto>>
    {
        public GetAllNotificationsQuery(string userId)
        {
            UserId = userId;
        }
        public string UserId { get; }
    }

    public class GetAllNotificationsQueryHandler : IRequestHandler<GetAllNotificationsQuery, List<GetNotificationDto>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllNotificationsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<GetNotificationDto>> Handle(GetAllNotificationsQuery request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var allNotifications = await unitOfWork.Repository<Notification>().GetAll
                .Where(n => n.UserId.Equals(request.UserId))
                .ToListAsync();
                allNotifications.ForEach(c => c.IsRead = true);

                foreach (var notification in allNotifications)
                {
                    await unitOfWork.Repository<Notification>().UpdateAsync(notification);
                }
                unitOfWork.Commit();
            }
            catch
            {
                unitOfWork.Rollback();
            }

            var notifications = await unitOfWork.Repository<Notification>().GetAll
                .Where(n => n.UserId.Equals(request.UserId))
                .OrderByDescending(n => n.CreateAt)
                .Select(n => new GetNotificationDto
                {
                    Title = n.Title,
                    Content = n.Content,
                    IsRead = n.IsRead,
                    UserId = request.UserId,
                    ResourceId = n.ResourceId,
                    ResourceName = n.ResourceName,
                    CompanyName = "",
                    CompanyLogoUrl = "",
                    CreateAt = n.CreateAt
                })
                .ToListAsync();

            foreach(var notification in notifications)
            {
                var jobPost = await unitOfWork.Repository<JobPost>().GetAll
                    .Where(j => j.Id == notification.ResourceId)
                    .Include(j => j.Employer.Company)
                    .Select(j => new
                    {
                        CompanyName = j.Employer.Company.CompanyName,
                        ResourceName = j.Title,
                        CompanyLogoUrl = j.Employer.Company.LogoUrl
                    })
                    .FirstOrDefaultAsync();
                notification.ResourceName = jobPost!.ResourceName;
                notification.CompanyName = jobPost!.CompanyName;
                notification.CompanyLogoUrl = jobPost!.CompanyLogoUrl;
            }

            return notifications;
        }
    }
}
