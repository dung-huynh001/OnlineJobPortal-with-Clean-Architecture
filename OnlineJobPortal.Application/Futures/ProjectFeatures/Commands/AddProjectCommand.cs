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
    public class AddProjectCommand : IRequest<Project?>
    {
        public AddProjectCommand(Project project)
        {
            Project = project;
        }

        public Project Project { get; }
    }
    public class AddProjectCommandHandler : IRequestHandler<AddProjectCommand, Project?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public AddProjectCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<Project?> Handle(AddProjectCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var project = request.Project;

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