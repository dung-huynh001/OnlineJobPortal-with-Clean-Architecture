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
    public class UpdateCareerGoalCommand : IRequest<string?>
    {
        public int Id { get; set; }
        public string CareerGoal { get; set; }

        public UpdateCareerGoalCommand(int id, string careerGoal)
        {
            Id = id;
            CareerGoal = careerGoal;
        }
    }

    public class UpdateCareerGoalCommandHandler : IRequestHandler<UpdateCareerGoalCommand, string?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public UpdateCareerGoalCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<string?> Handle(UpdateCareerGoalCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var resume = await unitOfWork.Repository<Resume>().GetByIdAsync(request.Id);
                resume.CareerGoal = request.CareerGoal;
                await unitOfWork.Repository<Resume>().UpdateAsync(resume);
                unitOfWork.Commit();
                return resume.CareerGoal;
            }
            catch
            {
                unitOfWork.Rollback();
                return null;
            }
        }
    }
}
