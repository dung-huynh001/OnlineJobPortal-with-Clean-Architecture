using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.MessageFeatures.Commands
{
    public class UpdateMessageCommand : IRequest<ApiResponse>
    {
    }
    public class UpdateMessageCommandHandler : IRequestHandler<UpdateMessageCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(UpdateMessageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
