using MediatR;
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
    public class DeleteEmployerCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }
    }

    public class DeleteEmployerCommandHandler : IRequestHandler<DeleteEmployerCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteEmployerCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(DeleteEmployerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var employer = await unitOfWork.Repository<Employer>().GetByIdAsync(request.Id);
                if(employer == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found employer to delete"
                    };
                }

                await unitOfWork.Repository<Employer>().DeleteAsync(employer);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Deleted employer successfully.",
                    Data = employer
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Delete employer failed! Something went wrong.",
                };
            }
        }
    }
}
