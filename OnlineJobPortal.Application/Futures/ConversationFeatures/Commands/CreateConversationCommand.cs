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
    public class CreateConversationCommand : IRequest<int>
    {
        public CreateConversationCommand(int applyId)
        {
            this.ApplyId = applyId;
        }

        public int ApplyId { get; }
    }

    public class CreateConversationCommandHandler : IRequestHandler<CreateConversationCommand, int>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateConversationCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(CreateConversationCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var conversation = new Conversations();
                conversation.ApplyId = request.ApplyId;

                await unitOfWork.Repository<Conversations>().AddAsync(conversation);

                unitOfWork.Commit();
                return conversation.Id;
            }
            catch
            {
                unitOfWork.Rollback();
                return 0;
            }
        }
    }
}
