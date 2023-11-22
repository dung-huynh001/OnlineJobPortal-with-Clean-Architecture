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

namespace OnlineJobPortal.Application.Futures.StatisticalFeatures.Queries
{
    public class EmployerStatisticalQuery : IRequest<List<int>>
    {
        public EmployerStatisticalQuery(int employerId)
        {
            EmployerId = employerId;
        }

        public int EmployerId { get; }
    }

    public class EmployerStatisticalQueryHandler : IRequestHandler<EmployerStatisticalQuery, List<int>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public EmployerStatisticalQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<int>> Handle(EmployerStatisticalQuery request, CancellationToken cancellationToken)
        {
            var result = new List<int>();
            var totalJobPost = await unitOfWork.Repository<JobPost>().GetAll
                .Where(e => e.EmployerId == request.EmployerId)
                .CountAsync();

            var totalCvs = await unitOfWork.Repository<Apply>().GetAll
                .Include(a => a.JobPost)
                .Where(j => j.JobPost.EmployerId.Equals(request.EmployerId))
                .CountAsync();

            var viewedCvs = await unitOfWork.Repository<Apply>().GetAll
                .Include(a => a.JobPost)
                .Where(a => a.JobPost.EmployerId == request.EmployerId && !a.Status.ToLower().Contains("pending"))
                .CountAsync();

            var passedCvs = await unitOfWork.Repository<Apply>().GetAll
                .Include(a => a.JobPost)
                .Where(a => a.JobPost.EmployerId == request.EmployerId && a.Status.ToLower().Contains("passed"))
                .CountAsync();

            var totalCandidate = await unitOfWork.Repository<Candidate>().GetAll
                .Include(c => c.Applies).ThenInclude(a => a.JobPost)
                .Where(c => c.Applies.Any(a => a.JobPost.EmployerId.Equals(request.EmployerId)))
                .CountAsync();

            result.Add(totalJobPost);
            result.Add(totalCvs);
            result.Add(viewedCvs);
            result.Add(passedCvs);
            result.Add(totalCandidate);

            return result;
        }
    }
}
