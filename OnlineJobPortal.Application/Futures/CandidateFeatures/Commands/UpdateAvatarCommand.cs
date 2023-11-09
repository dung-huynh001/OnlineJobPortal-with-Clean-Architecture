using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CandidateFeatures.Commands
{
    public class UpdateAvatarCommand : IRequest<Candidate>
    {
        public int Id { get; set; }
        public string AvatarUrl { get; set; }
        public UpdateAvatarCommand(int id, string avatarUrl)
        {
            Id = id;
            this.AvatarUrl = avatarUrl;
        }
    }
    public class UpdateAvatarCommandHandler : IRequestHandler<UpdateAvatarCommand, Candidate>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public UpdateAvatarCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<Candidate?> Handle(UpdateAvatarCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var candidate = await unitOfWork.Repository<Candidate>().GetByIdAsync(request.Id);
                if (candidate == null) throw new Exception();
                candidate.AvatarUrl = request.AvatarUrl;
                unitOfWork.Commit();
                return candidate;
            }
            catch
            {
                unitOfWork.Rollback();
                return null;
            }
        }
    }
}
