using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ExperienceFeatures.Commands
{
    public class UpdateExperienceCommand : IRequest<ApiResponse>
    {
    }
    public class UpdateExperienceCommandHandler : IRequestHandler<UpdateExperienceCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(UpdateExperienceCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
