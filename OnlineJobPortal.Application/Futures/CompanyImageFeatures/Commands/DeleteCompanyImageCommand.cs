using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CompanyImageFeatures.Commands
{
    public class DeleteCompanyImageCommand : IRequest<ApiResponse>
    {
    }
    public class DeleteCompanyImageCommandHandler : IRequestHandler<DeleteCompanyImageCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(DeleteCompanyImageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
