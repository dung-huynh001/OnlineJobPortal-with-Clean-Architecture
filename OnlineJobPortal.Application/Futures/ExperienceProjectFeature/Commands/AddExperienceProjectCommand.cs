using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ExperienceProjectFeature.Commands
{
    public class AddExperienceProjectCommand : IRequest<ExperienceProject?>
    {
        public AddExperienceProjectCommand(int experienceId, ExperienceProject project)
        {
            ExperienceId = experienceId;
            Project = project;
        }

        public int ExperienceId { get; }
        public ExperienceProject Project { get; }
    }
    public class AddExperienceProjectCommandHandler : IRequestHandler<AddExperienceProjectCommand, ExperienceProject?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public AddExperienceProjectCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ExperienceProject?> Handle(AddExperienceProjectCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var project = request.Project;
                project.ExperienceId = request.ExperienceId;

                await unitOfWork.Repository<ExperienceProject>().AddAsync(project);

                unitOfWork.Commit();
                return project;
            }
            catch
            {
                unitOfWork.Rollback();
                return null;
            }
        }
    }
}
