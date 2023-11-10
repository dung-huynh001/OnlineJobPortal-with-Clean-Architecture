using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ProjectFeatures.Commands
{
    public class AddExperienceProjectCommand : IRequest<Project?>
    {
        public AddExperienceProjectCommand(int experienceId, Project project)
        {
            ExperienceId = experienceId;
            Project = project;
        }

        public int ExperienceId { get; }
        public Project Project { get; }
    }
    public class AddExperienceProjectCommandHandler : IRequestHandler<AddExperienceProjectCommand, Project?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public AddExperienceProjectCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<Project?> Handle(AddExperienceProjectCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var project = request.Project;
                project.ExperienceId = request.ExperienceId;

                await unitOfWork.Repository<Project>().AddAsync(project);

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