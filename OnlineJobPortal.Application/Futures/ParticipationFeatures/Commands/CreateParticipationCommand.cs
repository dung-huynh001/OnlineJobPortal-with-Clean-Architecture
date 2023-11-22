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

namespace OnlineJobPortal.Application.Futures.ParticipationFeatures.Commands
{
    public class CreateParticipationCommand : IRequest<int>
    {
        public CreateParticipationCommand(string userId, int coversationId)
        {
            UserId = userId;
            CoversationId = coversationId;
        }

        public string UserId { get; }
        public int CoversationId { get; }
    }

    public class CreateParticipationCommandHandler : IRequestHandler<CreateParticipationCommand, int>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateParticipationCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(CreateParticipationCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var participation = new Participation();
                participation.UserId = request.UserId;
                participation.ConversationId = request.CoversationId;

                var exist = await unitOfWork.Repository<Participation>().GetAll
                    .FirstOrDefaultAsync(p => p.UserId == request.UserId && p.ConversationId == request.CoversationId);

                if (exist != null)
                {
                    return 0;
                }

                await unitOfWork.Repository<Participation>().AddAsync(participation);
                unitOfWork.Commit();
                return participation.Id;
            }
            catch
            {
                unitOfWork.Rollback();
                return 0;
            }
        }
    }
}
