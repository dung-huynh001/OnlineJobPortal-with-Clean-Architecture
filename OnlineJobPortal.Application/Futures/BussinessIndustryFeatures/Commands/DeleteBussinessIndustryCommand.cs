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

namespace OnlineJobPortal.Application.Futures.BussinessIndustryFeatures.Commands
{
    public class DeleteBussinessIndustryCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }
    }

    public class DeleteBussinessIndustryCommandHandler : IRequestHandler<DeleteBussinessIndustryCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DeleteBussinessIndustryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(DeleteBussinessIndustryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var bussiness = await unitOfWork.Repository<BussinessIndustry>().GetByIdAsync(request.Id);

                if (bussiness == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found bussiness industry to delete."
                    };
                }

                await unitOfWork.Repository<BussinessIndustry>().DeleteAsync(bussiness);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Deleted bussiness industry successfully.",
                    Data = bussiness
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Delete bussiness industry failed! Something went wrong."
                };
            }
        }
    }
}
