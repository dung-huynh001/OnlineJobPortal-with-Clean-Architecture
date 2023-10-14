using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.MessageFeatures.Commands
{
    public class CreateMessageCommand : IRequest<ApiResponse>
    {
    }
    public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
