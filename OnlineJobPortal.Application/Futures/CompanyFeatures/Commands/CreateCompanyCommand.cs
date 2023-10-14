using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CompanyFeatures.Commands
{
    public class CreateCompanyCommand : IRequest<ApiResponse>
    {
    }

    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
