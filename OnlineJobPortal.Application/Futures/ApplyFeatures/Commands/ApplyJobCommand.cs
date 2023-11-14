using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.DTOs.ApplicationDto;
using OnlineJobPortal.Application.DTOs.ApplyDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ApplyFeatures.Commands
{
    public record ApplyJobCommand : IRequest<ApiResponse>
    {
        public CreateApplyDto CreateApplyDto { get; set; }
        public ApplyJobCommand(CreateApplyDto createApplyDto)
        {
            CreateApplyDto = createApplyDto;
        }
    }
    public class CreateApplyCommandHandler : IRequestHandler<ApplyJobCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateApplyCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse> Handle(ApplyJobCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var apply = mapper.Map<Apply>(request.CreateApplyDto);
                var exist = await unitOfWork.Repository<Apply>().GetAll
                    .FirstOrDefaultAsync(
                    e => e.CandidateId.Equals(request.CreateApplyDto.CandidateId) 
                    && e.JobPostId.Equals(request.CreateApplyDto.JobPostId));

                if (exist != null)
                {
                    throw new Exception();
                }
                await unitOfWork.Repository<Apply>().AddAsync(apply);

                unitOfWork.Commit();
                return new ApiResponse
                {
                    Success = true,
                    Message = "Applied Job successfully."
                };
            }catch
            {
                unitOfWork.Rollback();
                return new ApiResponse
                {
                    Success = false,
                    Message = "Apply Job failed! Something went wrong."
                };
            }
        }
    }
}
