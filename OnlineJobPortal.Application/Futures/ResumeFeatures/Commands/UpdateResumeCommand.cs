using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ResumeFeatures.Commands
{
    public class UpdateResumeCommand : IRequest<ApiResponse>
    {
    }
    public class UpdateResumeCommandHandler : IRequestHandler<UpdateResumeCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(UpdateResumeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
