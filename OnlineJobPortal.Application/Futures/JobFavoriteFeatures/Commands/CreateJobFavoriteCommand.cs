using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Commands
{
    public class CreateJobFavoriteCommand : IRequest<ApiResponse>
    {
    }
    public class CreateJobFavoriteCommandHandler : IRequestHandler<CreateJobFavoriteCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(CreateJobFavoriteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
