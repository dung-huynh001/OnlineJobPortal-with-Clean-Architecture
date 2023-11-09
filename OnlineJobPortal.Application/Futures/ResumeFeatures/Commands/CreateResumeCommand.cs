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

namespace OnlineJobPortal.Application.Futures.ResumeFeatures.Commands
{
    public class CreateResumeCommand : IRequest<ApiResponse>
    {
        public int CandidateId { get; set; }
        public CreateResumeCommand(int candidateId)
        {
            CandidateId = candidateId;
        }
    }
    public class CreateResumeCommandHandler : IRequestHandler<CreateResumeCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateResumeCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(CreateResumeCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                Resume resume = new Resume();
                resume.CandidateId = request.CandidateId;
                await unitOfWork.Repository<Resume>().AddAsync(resume);
                unitOfWork.Commit();
                return new ApiResponse
                {
                    Success = true,
                    Message = "Created resume successfully"
                };
            }
            catch
            {
                unitOfWork.Rollback();
                return new ApiResponse
                {
                    Success = false,
                    Message = "Create resume failed"
                };
            }
        }
    }
}
