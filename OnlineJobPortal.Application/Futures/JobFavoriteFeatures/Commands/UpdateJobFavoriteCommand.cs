using MediatR;
using OnlineJobPortal.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Commands
{
    public class UpdateJobFavoriteCommand : IRequest<ApiResponse>
    {
    }
    public class UpdateJobFavoriteCommandHandler : IRequestHandler<UpdateJobFavoriteCommand, ApiResponse>
    {
        public Task<ApiResponse> Handle(UpdateJobFavoriteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
