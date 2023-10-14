using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CompanyFeatures.Commands
{
    public class DeleteCompanyCommand : IRequest<ApiResponse>
    {
    }

    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
