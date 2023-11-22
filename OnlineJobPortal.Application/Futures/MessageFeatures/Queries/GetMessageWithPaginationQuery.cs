using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.MessageFeatures.Queries
{
    public record GetMessageWithPaginationQuery : IRequest<PaginatedResult<Message>>
    {
        public GetMessageWithPaginationQuery(int conversationId, string userId, int pageNumber, int pageSize)
        {
            ConversationId = conversationId;
            UserId = userId;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        public int ConversationId { get; }
        public string UserId { get; }
        public int PageNumber { get; }
        public int PageSize { get; }
    }
    public class GetMessageWithPaginationQueryHandler : IRequestHandler<GetMessageWithPaginationQuery, PaginatedResult<Message>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetMessageWithPaginationQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<PaginatedResult<Message>> Handle(GetMessageWithPaginationQuery request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.Repository<Message>().GetAll
                .Where(m => m.UserId.Equals(request.UserId) && m.ConversationId == request.ConversationId)
                .OrderByDescending(m => m.CreateAt)
                .ToPaginatedListAsync(request.PageNumber, request.PageSize, cancellationToken);

            return result;
        }
    }
}
