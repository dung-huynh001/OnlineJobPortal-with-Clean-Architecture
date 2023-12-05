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
    public class GetTitleToNotifyQuery : IRequest<List<GetNotificationDto>>
    {
        public GetTitleToNotifyQuery(string userId)
        {
            UserId = userId;
        }
        public string UserId { get; }
    }

    public class GetTitleToNotifyQueryHandler : IRequestHandler<GetTitleToNotifyQuery, List<GetNotificationDto>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetTitleToNotifyQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<GetNotificationDto>> Handle(GetTitleToNotifyQuery request, CancellationToken cancellationToken)
        {
            var unReadNotifications = await unitOfWork.Repository<Notification>().GetAll
                .Where(n => n.UserId.Equals(request.UserId) && n.IsRead == false)
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

            int totalUnReadNotifications = unReadNotifications.Count;
            if(totalUnReadNotifications < 8) 
            {
                var ReadedNotifications = await unitOfWork.Repository<Notification>().GetAll
                .Where(n => n.UserId.Equals(request.UserId) && n.IsRead == true)
                .OrderByDescending(n => n.CreateAt)
                .Take(8 - totalUnReadNotifications)
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

                unReadNotifications = unReadNotifications.Concat(ReadedNotifications).ToList();
            }
            else
            {
                unReadNotifications = unReadNotifications.Take(8).ToList();
            }

            

            foreach (var notification in unReadNotifications)
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

            return unReadNotifications;
        }
    }
}
