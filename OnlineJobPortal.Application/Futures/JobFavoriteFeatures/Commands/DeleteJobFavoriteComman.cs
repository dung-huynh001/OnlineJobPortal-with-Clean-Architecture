using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Commands
{
    public class DeleteJobFavoriteCommand : IRequest<ApiResponse>
    {
    }
    public class DeleteJobFavoriteCommandHandler : IRequestHandler<DeleteJobFavoriteCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(DeleteJobFavoriteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
