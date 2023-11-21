using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ConversationFeatures.Commands
{
    public class CreateConversationCommand : IRequest<bool>
    {
        public CreateConversationCommand(int applyId)
        {
            this.ApplyId = applyId;
        }

        public int ApplyId { get; }
    }

    public class CreateConversationCommandHandler : IRequestHandler<CreateConversationCommand, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateConversationCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(CreateConversationCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var conversation = new Conversations();
                conversation.ApplyId = request.ApplyId;

                await unitOfWork.Repository<Conversations>().AddAsync(conversation);

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
