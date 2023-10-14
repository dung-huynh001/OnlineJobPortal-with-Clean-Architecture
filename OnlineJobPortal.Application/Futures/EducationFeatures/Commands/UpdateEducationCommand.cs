using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.EducationFeatures.Commands
{
    public class UpdateEducationCommand : IRequest<ApiResponse>
    {
    }
    public class UpdateEducationCommandHandler : IRequestHandler<UpdateEducationCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(UpdateEducationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
