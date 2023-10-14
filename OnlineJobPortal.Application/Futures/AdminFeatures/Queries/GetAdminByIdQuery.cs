using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.AdminDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.AdminFeatures.Queries
{
    public class GetAdminByIdQuery : IRequest<ApiResponse>
    {
        public int Id { get; set; }
    }

    public class GetAdminByIdQueryHandler : IRequestHandler<GetAdminByIdQuery, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAdminByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(GetAdminByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var admin = await unitOfWork.Repository<Admin>().GetByIdAsync(request.Id);

                var admindto = mapper.Map<AdminDto>(admin);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Got a admin with id",
                    Data = admindto
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = true,
                    Message = "Can't get a admin by id! Something went wrong.",
                };
            }
        }
    }
}
