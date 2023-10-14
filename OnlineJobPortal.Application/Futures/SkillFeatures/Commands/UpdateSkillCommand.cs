using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.SkillFeatures.Commands
{
    public class UpdateSkillCommand : IRequest<ApiResponse>
    {
    }
    public class UpdateSkillCommandHandler : IRequestHandler<UpdateSkillCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(UpdateSkillCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
