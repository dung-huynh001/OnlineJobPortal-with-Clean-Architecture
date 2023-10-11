using AutoMapper;
using MediatR;
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
    public record CreateAdminCommand : IRequest<ApiResponse>
    {
        public AdminDto Admin { get; set; }
    }

    public class CreateAdminCommandHandler : IRequestHandler<CreateAdminCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateAdminCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse> Handle(CreateAdminCommand request, CancellationToken cancellationToken)
        {
            var admin = mapper.Map<Admin>(request.Admin);

            await unitOfWork.Repository<Admin>().AddAsync(admin);

            return new ApiResponse
            {
                Success = true,
                Message = "Admin Creation Success!"
            };
        }
    }
}
