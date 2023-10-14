using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ForeignLangugeFeatures.Commands
{
    public class DeleteForeignLanguageCommand : IRequest<ApiResponse>
    {
    }
    public class DeleteForeignLanguageCommandHandler : IRequestHandler<DeleteForeignLanguageCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(DeleteForeignLanguageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
