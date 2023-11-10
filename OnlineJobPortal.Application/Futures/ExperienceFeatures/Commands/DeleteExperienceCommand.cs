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

namespace OnlineJobPortal.Application.Futures.ExperienceFeatures.Commands
{
    public class DeleteExperienceCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }

        public DeleteExperienceCommand(int id)
        {
            Id = id;
        }
    }
    public class DeleteExperienceCommandHandler : IRequestHandler<DeleteExperienceCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public DeleteExperienceCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(DeleteExperienceCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var result = await unitOfWork.Repository<Experience>().DeleteByIdAsync(request.Id);
                if (result == 0)
                {
                    throw new Exception();
                }

                unitOfWork.Commit();

                return new ApiResponse
                {
                    Success = true,
                    Message = "Deleted experience successfully",
                    Data = request.Id
                };
            }
            catch
            {
                unitOfWork.Rollback();
                return new ApiResponse
                {
                    Success = false,
                    Message = "Delete experience failed",
                };
            }         
        }
    }
}
