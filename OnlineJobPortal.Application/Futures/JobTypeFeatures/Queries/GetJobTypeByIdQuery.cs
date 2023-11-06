using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobTypeFeatures.Queries
{
    public class GetJobTypeByIdQuery : IRequest<JobType>
    {
        public int Id { get; set; }
        public GetJobTypeByIdQuery(int id)
        {
            Id = id;
        }
    }

    public class GetJobTypeByIdQueryHandler : IRequestHandler<GetJobTypeByIdQuery, JobType>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetJobTypeByIdQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<JobType> Handle(GetJobTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.Repository<JobType>().GetByIdAsync(request.Id);
            return result;
        }
    }
}
