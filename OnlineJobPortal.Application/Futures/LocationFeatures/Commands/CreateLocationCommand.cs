using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.LocationDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.LocationFeatures.Commands
{
    public class CreateLocationCommand : IRequest<ApiResponse>
    {
        public CreateLocationDto Location { get; set; }
    }

    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateLocationCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            var province = mapper.Map<Province>(request.Location);
            var district = mapper.Map<District>(request.Location);

            var existProvince = await unitOfWork.Repository<Province>().GetByIdAsync(province.Id);
            var existDistrict = await unitOfWork.Repository<District>().FindWeakEntityAsync(district.Id, district.ProvinceId);

            if(existProvince == null)
            {
                await unitOfWork.Repository<Province>().AddAsync(province);
            }
            if(existDistrict == null)
            {
                await unitOfWork.Repository<District>().AddAsync(district);
            }

            await unitOfWork.SaveAsync(cancellationToken);

            return new ApiResponse
            {
                Success = true,
                Message = "Created location successfully."
            };
        }
    }
}
