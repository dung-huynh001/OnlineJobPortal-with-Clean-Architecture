using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.BussinessIndustryDto;
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
    public class UpdateBussinessIndustryCommand : IRequest<ApiResponse>
    {
        public UpdateBussinessIndustryDto UpdateBussinessIndustryDto { get; set; }
    }

    public class UpdateBussinessIndustryCommandHandler : IRequestHandler<UpdateBussinessIndustryCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateBussinessIndustryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(UpdateBussinessIndustryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var bussiness = await unitOfWork.Repository<BussinessIndustry>().GetByIdAsync(request.UpdateBussinessIndustryDto.Id);

                if(bussiness == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found bussiness industry to update."
                    };
                }

                bussiness = mapper.Map<BussinessIndustry>(request.UpdateBussinessIndustryDto);
                await unitOfWork.Repository<BussinessIndustry>().UpdateAsync(bussiness);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Updated bussiness industry successfully.",
                    Data = bussiness
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Update bussiness industry failed.",
                };
            }
        }
    }
}
