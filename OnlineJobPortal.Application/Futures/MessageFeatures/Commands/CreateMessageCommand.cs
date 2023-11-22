using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.MessageFeatures.Commands
{
    public class CreateMessageCommand : IRequest<bool>
    {
        public CreateMessageCommand(string userId, int conversationId, string content)
        {
            UserId = userId;
            ConversationId = conversationId;
            Content = content;
        }
        public string UserId { get; }
        public int ConversationId { get; }
        public string Content { get; }
    }
    public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateMessageCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var message = new Message();
                message.UserId = request.UserId;
                message.ConversationId = request.ConversationId;
                message.Content = request.Content;
                message.Timestamp = DateTime.Now;

                await unitOfWork.Repository<Message>().AddAsync(message);

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
