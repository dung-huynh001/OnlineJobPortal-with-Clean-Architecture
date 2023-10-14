using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.EducationFeatures.Commands
{
    public class DeleteEducationCommand : IRequest<ApiResponse>
    {
    }
    public class DeleteEducationCommandHandler : IRequestHandler<DeleteEducationCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(DeleteEducationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
