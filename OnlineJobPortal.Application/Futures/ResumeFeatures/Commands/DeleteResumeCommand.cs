using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ResumeFeatures.Commands
{
    public class DeleteResumeCommand : IRequest<ApiResponse>
    {
    }
    public class DeleteResumeCommandHandler : IRequestHandler<DeleteResumeCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(DeleteResumeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
