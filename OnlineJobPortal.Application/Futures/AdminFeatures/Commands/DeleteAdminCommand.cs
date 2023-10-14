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

namespace OnlineJobPortal.Application.Futures.AdminFeatures.Commands
{
    public class DeleteAdminCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }
    }

    public class DeleteAdminCommandHandler : IRequestHandler<DeleteAdminCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DeleteAdminCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(DeleteAdminCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var admin = await unitOfWork.Repository<Admin>().GetByIdAsync(request.Id);

                if (admin == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found admin to delete."
                    };
                }

                await unitOfWork.Repository<Admin>().DeleteAsync(admin);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Deleted admin successfully.",
                    Data = admin
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Delete admin failed! Something went wrong."
                };
            }
        }
    }
}
