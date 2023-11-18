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

namespace OnlineJobPortal.Application.Futures.JobPostFeatures.Queries
{
    public record GetAllJobPostByEmployerIdQuery : IRequest<List<JobPost>?>
    {
        public GetAllJobPostByEmployerIdQuery(int employerId)
        {
            EmployerId = employerId;
        }

        public int EmployerId { get; }
    }

    public class GetAllJobPostByEmployerIdQueryHandler : IRequestHandler<GetAllJobPostByEmployerIdQuery, List<JobPost>?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllJobPostByEmployerIdQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<JobPost>?> Handle(GetAllJobPostByEmployerIdQuery request, CancellationToken cancellationToken)
        {
            var jobPosts = await unitOfWork.Repository<JobPost>().GetAll
                .Include(jp => jp.Applications)
                .Where(j => j.EmployerId.Equals(request.EmployerId))
                .OrderByDescending(j => j.Applications.Count)
                .ToListAsync();
            return jobPosts;
        }
    }
}
