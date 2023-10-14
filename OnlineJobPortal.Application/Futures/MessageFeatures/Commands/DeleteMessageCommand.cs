using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.MessageFeatures.Commands
{
    public class DeleteMessageCommand : IRequest<ApiResponse>
    {
    }
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
