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
    public class UpdateEducationCommand : IRequest<Education?>
    {
        public UpdateEducationCommand(int resumeId, Education education)
        {
            ResumeId = resumeId;
            Education = education;
        }

        public int ResumeId { get; }
        public Education Education { get; }
    }
    public class UpdateEducationCommandHandler : IRequestHandler<UpdateEducationCommand, Education?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public UpdateEducationCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public Task<Education?> Handle(UpdateEducationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
