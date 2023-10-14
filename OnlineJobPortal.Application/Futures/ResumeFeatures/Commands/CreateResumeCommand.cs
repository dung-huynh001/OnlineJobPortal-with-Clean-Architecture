using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ResumeFeatures.Commands
{
    public class CreateResumeCommand : IRequest<ApiResponse>
    {
    }
    public class CreateResumeCommandHandler : IRequestHandler<CreateResumeCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(CreateResumeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
