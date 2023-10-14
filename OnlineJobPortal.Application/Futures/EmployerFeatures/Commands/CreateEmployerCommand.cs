using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.EmployerDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.EmployerFeatures.Commands
{
    public class CreateEmployerCommand : IRequest<ApiResponse>
    {
        public CreateEmployerDto CreateEmployerDto { get; set; }
    }
    public class CreateEmployerCommandHandler : IRequestHandler<CreateEmployerCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CreateEmployerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(CreateEmployerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var employer = mapper.Map<Employer>(request.CreateEmployerDto);

                await unitOfWork.Repository<Employer>().AddAsync(employer);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse 
                {
                    Success = true,
                    Message = "Created employer successfully.",
                    Data = employer
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Create employer failed! Something went wrong.",
                };
            }
        }
    }
}
