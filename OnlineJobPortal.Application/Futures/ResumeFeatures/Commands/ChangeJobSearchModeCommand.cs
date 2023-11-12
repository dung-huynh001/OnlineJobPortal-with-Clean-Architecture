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
    public class ChangeJobSearchModeCommand : IRequest<ApiResponse>
    {
        public ChangeJobSearchModeCommand(int resumeId, bool isSearching)
        {
            ResumeId = resumeId;
            IsSearching = isSearching;
        }

        public int ResumeId { get; }
        public bool IsSearching { get; }
    }

    public class ChangeJobSearchModeCommandHandler : IRequestHandler<ChangeJobSearchModeCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public ChangeJobSearchModeCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(ChangeJobSearchModeCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var resume = await unitOfWork.Repository<Resume>().GetByIdAsync(request.ResumeId);
                if (resume == null) throw new Exception(); 

                resume.JobSearchMode = request.IsSearching;
                unitOfWork.Commit();
                return new ApiResponse
                {
                    Success = true,
                    Message = "Updated search mode successfully"
                };
            }
            catch
            {
                unitOfWork.Rollback();
                return new ApiResponse
                {
                    Success = false,
                    Message = "Updated search mode successfully"
                };
            }
        }
    }
}
