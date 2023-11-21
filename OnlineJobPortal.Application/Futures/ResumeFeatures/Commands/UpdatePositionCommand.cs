using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ResumeFeatures.Commands
{
    public class UpdatePositionCommand : IRequest<bool>
    {
        public UpdatePositionCommand(int resumeId, string position, string yearOfExperiences)
        {
            ResumeId = resumeId;
            Position = position;
            YearOfExperiences = yearOfExperiences;
        }

        public int ResumeId { get; }
        public string Position { get; }
        public string YearOfExperiences { get; }
    }

    public class UpdatePositionCommandHandler : IRequestHandler<UpdatePositionCommand, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public UpdatePositionCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(UpdatePositionCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var resume = await unitOfWork.Repository<Resume>().GetByIdAsync(request.ResumeId);
                if (resume == null) throw new Exception();

                resume.Position = request.Position;
                resume.YearOfExperiences = request.YearOfExperiences;

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
