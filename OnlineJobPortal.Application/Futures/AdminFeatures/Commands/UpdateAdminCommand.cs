using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.AdminDto;
using OnlineJobPortal.Application.DTOs.ApplicationDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.AdminFeatures.Commands
{
    public class UpdateAdminCommand : IRequest<ApiResponse>
    {
        public UpdateAdminDto Admin { get; set; }
    }

    public class UpdateAdminCommandHandler : IRequestHandler<UpdateAdminCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateAdminCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(UpdateAdminCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var admin = await unitOfWork.Repository<Admin>().GetByIdAsync(request.Admin.Id);

                if(admin == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found admin to update."
                    };
                }

                admin = mapper.Map<Admin>(admin);
                await unitOfWork.Repository<Admin>().UpdateAsync(admin);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Updated admin successfully.",
                    Data = admin
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Update admin failed! Something went wrong."
                };
            }
        }
    }
}
