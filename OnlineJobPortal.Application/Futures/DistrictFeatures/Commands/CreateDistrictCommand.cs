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

namespace OnlineJobPortal.Application.Futures.DistrictFeatures.Commands
{
    public class CreateDistrictCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public int ProvinceId { get; set; }
    }

    public class CreateDistrictCommandHandler : IRequestHandler<CreateDistrictCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateDistrictCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(CreateDistrictCommand request, CancellationToken cancellationToken)
        {
            var district = mapper.Map<District>(request);
            var exist = await unitOfWork.Repository<District>().FindWeakEntityAsync(district.Id, district.ProvinceId);
            if (exist != null) 
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "District already exist."
                };
            }

            await unitOfWork.Repository<District>().AddAsync(district);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ApiResponse
            {
                Success = true,
                Message = "Created district successfully.",
                Data = district
            };
        }
    }
}
