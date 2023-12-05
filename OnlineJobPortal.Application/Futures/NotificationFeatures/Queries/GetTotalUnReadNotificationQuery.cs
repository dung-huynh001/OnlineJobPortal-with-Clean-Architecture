using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.NotificationFeatures.Queries
{
    public class GetTotalUnReadNotificationQuery : IRequest<int>
    {
        public GetTotalUnReadNotificationQuery(string userId)
        {
            UserId = userId;
        }

        public string UserId { get; }
    }

    public class GetTotalUnReadNotificationQueryHandler : IRequestHandler<GetTotalUnReadNotificationQuery, int>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetTotalUnReadNotificationQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(GetTotalUnReadNotificationQuery request, CancellationToken cancellationToken)
        {
            return await unitOfWork.Repository<Notification>().GetAll
                .Where(n => n.IsRead == false && n.UserId.Equals(request.UserId))
                .CountAsync();
        }
    }
}
