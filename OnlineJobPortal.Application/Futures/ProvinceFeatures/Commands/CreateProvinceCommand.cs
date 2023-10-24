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

namespace OnlineJobPortal.Application.Futures.ProvinceFeatures.Commands
{
    public class CreateProvinceCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }
        public string ProvinceName { get; set; }
    }

    public class CreateProvinceCommandHandler : IRequestHandler<CreateProvinceCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateProvinceCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(CreateProvinceCommand request, CancellationToken cancellationToken)
        {
            var province = mapper.Map<Province>(request);
            var exist = await unitOfWork.Repository<Province>().GetByIdAsync(province.Id);

            if (exist != null) return new ApiResponse
            {
                Success = false,
                Message = "Province already exist."
            };

            await unitOfWork.Repository<Province>().AddAsync(province);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ApiResponse
            {
                Success = true,
                Message = "Created province successfully.",
                Data = province
            };
        }
    }
}
