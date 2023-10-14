using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ForeignLangugeFeatures.Commands
{
    public class UpdateForeignLanguageCommand : IRequest<ApiResponse>
    {
    }
    public class UpdateForeignLanguageCommandHandler : IRequestHandler<UpdateForeignLanguageCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(UpdateForeignLanguageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
