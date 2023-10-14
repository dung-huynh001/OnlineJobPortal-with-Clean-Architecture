using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CompanyFeatures.Commands
{
    public class UpdateCompanyCommand : IRequest<ApiResponse>
    {
    }

    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
