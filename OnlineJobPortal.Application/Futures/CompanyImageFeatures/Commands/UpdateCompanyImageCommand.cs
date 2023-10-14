using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CompanyImageFeatures.Commands
{
    public class UpdateCompanyImageCommand : IRequest<ApiResponse>
    {
    }
    public class UpdateCompanyImageCommandHandler : IRequestHandler<UpdateCompanyImageCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(UpdateCompanyImageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
