using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.EducationFeatures.Commands
{
    public class CreateEducationCommand : IRequest<ApiResponse>
    {
    }
    public class CreateEducationCommandHandler : IRequestHandler<CreateEducationCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(CreateEducationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
