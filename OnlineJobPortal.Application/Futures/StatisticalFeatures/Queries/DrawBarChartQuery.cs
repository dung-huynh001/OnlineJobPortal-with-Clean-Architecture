using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.DTOs.ApplyDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.StatisticalFeatures.Queries
{
    public class DrawBarChartQuery : IRequest<List<ColumnBarChartDto>>
    {
        public DrawBarChartQuery(int employerId)
        {
            EmployerId = employerId;
        }

        public int EmployerId { get; }
    }

    public class DrawBarChartQueryHandler : IRequestHandler<DrawBarChartQuery, List<ColumnBarChartDto>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public DrawBarChartQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<ColumnBarChartDto>> Handle(DrawBarChartQuery request, CancellationToken cancellationToken)
        {
            var jobPostIdList = await unitOfWork.Repository<JobPost>().GetAll
                .Where(j => j.EmployerId == request.EmployerId)
                .Select(j => j.Id)
                .ToListAsync();

            DateTime startDateOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            DateTime endDateOfWeek = startDateOfWeek.AddDays(6);

            var dataForChart = new List<ColumnBarChartDto>();

            var daysOfWeek = Enumerable.Range(0, 7)
                .Select(offset => startDateOfWeek.AddDays(offset))
                .ToList();

            var appliedInWeek = await unitOfWork.Repository<Apply>().GetAll
                .Where(a => a.CreateAt >= startDateOfWeek && a.CreateAt <= endDateOfWeek && jobPostIdList.Contains(a.JobPostId))
                .OrderBy(a => a.CreateAt)
                .ToListAsync();

            foreach (var day in daysOfWeek)
            {
                var dailyData = appliedInWeek.Where(a => a.CreateAt.Date.Equals(day));
                int totalJobPost = dailyData.Count();
                int viewedJobPost = dailyData.Count(a => !a.Status.ToLower().Equals("pending"));
                int newJobPost = dailyData.Count(a => a.Status.ToLower().Equals("pending"));

                dataForChart.Add(new ColumnBarChartDto
                {
                    Date = day,
                    Total = totalJobPost,
                    ViewedJobs = viewedJobPost,
                    PendingJobs = newJobPost
                });
            }

            return dataForChart;
        }
    }
}
