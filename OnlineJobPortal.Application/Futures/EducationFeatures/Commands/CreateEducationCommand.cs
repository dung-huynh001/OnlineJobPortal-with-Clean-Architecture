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

namespace OnlineJobPortal.Application.Futures.EducationFeatures.Commands
{
    public class CreateEducationCommand : IRequest<Education?>
    {
        public CreateEducationCommand(Education education)
        {
            Education = education;
        }

        public Education Education { get; }
    }
    public class CreateEducationCommandHandler : IRequestHandler<CreateEducationCommand, Education?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateEducationCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<Education?> Handle(CreateEducationCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var education = request.Education;
                await unitOfWork.Repository<Education>().AddAsync(education);
                unitOfWork.Commit();
                return education;
            }
            catch
            {
                unitOfWork.Rollback();
                return null;
            }
        }
    }
}
