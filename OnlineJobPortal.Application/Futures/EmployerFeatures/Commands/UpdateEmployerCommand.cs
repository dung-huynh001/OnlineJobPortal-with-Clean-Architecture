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
    public class UpdateEmployerCommand : IRequest<ApiResponse>
    {
        public UpdateEmployerDto UpdateEmployerDto { get; set; }
    }
    public class UpdateEmployerCommandHandler : IRequestHandler<UpdateEmployerCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateEmployerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(UpdateEmployerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var employer = await unitOfWork.Repository<Employer>().GetByIdAsync(request.UpdateEmployerDto.Id);
                if(employer == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found employer to update"
                    };
                }

                employer = mapper.Map<Employer>(request.UpdateEmployerDto);
                await unitOfWork.Repository<Employer>().UpdateAsync(employer);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = false,
                    Message = "Updated employer successfully.",
                    Data = employer
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Update employer failed! Something went wrong."
                };
            }
        }
    }
}
