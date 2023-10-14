using AutoMapper;
using MediatR;
using Microsoft.VisualBasic;
using OnlineJobPortal.Application.DTOs.ApplicationDto;
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
    public record CreateBussinessIndustryCommand : IRequest<ApiResponse>
    {
        public string BussinessName { get; set; }
    }
    public class CreateBussinessIndustryCommandHandler : IRequestHandler<CreateBussinessIndustryCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateBussinessIndustryCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse> Handle(CreateBussinessIndustryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var bussiness = new BussinessIndustry
                {
                    BussinessName = request.BussinessName,
                };

                await unitOfWork.Repository<BussinessIndustry>().AddAsync(bussiness);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Created bussiness industry successfully.",
                    Data = bussiness
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Create bussiness industry failed! Something went wrong."
                };
            }
        }
    }
}
