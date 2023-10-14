using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ExperienceFeatures.Commands
{
    public class CreateExperienceCommand : IRequest<ApiResponse>
    {
    }
    public class CreateExperienceCommandHandler : IRequestHandler<CreateExperienceCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(CreateExperienceCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
