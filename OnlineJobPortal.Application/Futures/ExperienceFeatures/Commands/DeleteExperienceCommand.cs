using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ExperienceFeatures.Commands
{
    public class DeleteExperienceCommand : IRequest<ApiResponse>
    {
    }
    public class DeleteExperienceCommandHandler : IRequestHandler<DeleteExperienceCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(DeleteExperienceCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
