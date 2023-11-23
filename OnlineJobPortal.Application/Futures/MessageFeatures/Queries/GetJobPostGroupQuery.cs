using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.MessageFeatures.Queries
{
    public class GetJobPostGroupQuery : IRequest<List<int>>
    {
        public GetJobPostGroupQuery(int employerId)
        {
            EmployerId = employerId;
        }
        public int EmployerId { get; }
    }

    public class GetJobPostGroupQueryHandler : IRequestHandler<GetJobPostGroupQuery, List<int>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetJobPostGroupQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<int>> Handle(GetJobPostGroupQuery request, CancellationToken cancellationToken)
        {
            var jobPosts = await unitOfWork.Repository<JobPost>().GetAll
               .Where(j => j.EmployerId == request.EmployerId)
               .Select(j => j.Id)
               .ToListAsync();
            return jobPosts;
        }
    }
}
