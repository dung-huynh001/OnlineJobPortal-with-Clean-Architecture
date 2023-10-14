using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.SkillFeatures.Commands
{
    public class DeleteSkillCommand : IRequest<ApiResponse>
    {
    }
    public class DeleteSkillCommandHandler : IRequestHandler<DeleteSkillCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(DeleteSkillCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
