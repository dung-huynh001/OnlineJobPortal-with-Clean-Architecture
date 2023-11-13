using AutoMapper;
using Humanizer;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineJobPortal.Application;
using OnlineJobPortal.Application.DTOs.JobPostDto;
using OnlineJobPortal.Application.Futures.CompanyFeatures.Queries;
using OnlineJobPortal.Application.Futures.JobPostFeatures.Queries;
using OnlineJobPortal.Application.Futures.JobTypeFeatures.Queries;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Enums;
using OnlineJobPortal.Presentation.Models;
using System.Globalization;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace OnlineJobPortal.Presentation.Controllers
{
    public class JobPostController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;
        private readonly ICurrentUserService currentUserService;

        public JobPostController(IMapper mapper, IMediator mediator, ICurrentUserService currentUserService)
        {
            this.mapper = mapper;
            this.mediator = mediator;
            this.currentUserService = currentUserService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetJobWithPagination(ConditionViewModel condition)
        {
            try
            {
                int candidateId = 0;
                if (User.Identity.IsAuthenticated)
                {
                    candidateId = currentUserService.GetActorId();
                }

                int pageSize = 5;
                int pageNumber = condition.pageNumber ?? 0;
                var request = new GetAllJobPostQuery(candidateId);
                var response = mediator.Send(request).GetAwaiter().GetResult();

                if (condition.sortBy != null)
                {
                    switch (condition.sortBy.ToLower())
                    {
                        case "fulltime":
                            response = response.Where(i => i.EmploymentType.ToLower().Equals("fulltime")).ToList();
                            break;
                        case "parttime":
                            response = response.Where(i => i.EmploymentType.ToLower().Equals("parttime")).ToList();
                            break;
                        case "remote":
                            response = response.Where(i => i.EmploymentType.ToLower().Equals("remote")).ToList();
                            break;
                        case "freelancer":
                            response = response.Where(i => i.EmploymentType.ToLower().Equals("freelancer")).ToList();
                            break;
                    }
                }


                response = response.OrderByDescending(i => i.CreateAt).ToList();
                string? keyword = condition.keyword?.ToLower();
                string? level = condition.level?.ToLower();
                level = (level != null && (level.Contains("kinh nghiệm") || level.Contains("tất cả"))) ? "" : level;
                
                string? provinceName = condition.provinceName?.Trim().ToLower();
                provinceName = (provinceName != null && provinceName.Contains("tất cả thành phố")) ? "" : provinceName;
                int? salary = condition.salary;

                //Lọc theo các điều kiện
                response = response.Where(i => (i.Title.ToLower().Contains(keyword ?? "") 
                || i.Title.ToLower().Contains(keyword ?? "") 
                || i.CompanyName.ToLower().Contains(keyword ?? "")
                || i.Skills.Any(s => s.ToLower().Contains(keyword ?? "")))
                    && i.Province.ToLower().Contains(provinceName ?? "") 
                    && isSalaryInRange(salary, i.Salary)
                    && i.Level.ToLower().Contains(level ?? ""))
                    .ToList();

                var data = response.ToPaginatedListAsync(pageNumber, pageSize, new CancellationToken()).GetAwaiter().GetResult();
                return Json(data);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }

        private bool isSalaryInRange(int? salary, string range)
        {
            if (salary == null) return true;
            range = range.Replace("triệu", "");
            range = range.ToLower().Trim();
            if (range.Equals("thỏa thuận"))
                return true;

            if (range.Contains("-"))
            {
                int min;
                Int32.TryParse(range.Substring(0, range.IndexOf(" ")).Trim(), out min);
                int max;
                Int32.TryParse(range.Substring(range.LastIndexOf(" ")).Trim(), out max);
                switch (salary)
                {
                    case 0:
                        return true;
                    case 1:
                        return max <= 10;
                    case 2:
                        return (max < 10 || 15 < min) ? false : true;
                    case 3:
                        return (max < 15 || 20 < min) ? false : true;
                    case 4:
                        return (max < 20 || 25 < min) ? false : true;
                    case 5:
                        return (max > 25 || min > 25);
                    default:
                        return true;
                }
            }
            else
            {
                int about;
                Int32.TryParse(range.Trim(), out about);
                switch (salary)
                {
                    case 0:
                        return true;
                    case 1:
                        return about <= 10;
                    case 2:
                        return (about > 10 && about <= 15);
                    case 3:
                        return (about > 15 || about <= 20);
                    case 4:
                        return (about > 20 || about <= 25);
                    case 5:
                        return (about >= 25);
                    default:
                        return true;
                }
            }
        }

        [HttpGet]
        public IActionResult GetPagingPartial(int currentPage, int countPages)
        {
            var pagingModel = new PagingSPAModel();
            pagingModel.currentPage = currentPage;
            pagingModel.countPages = countPages;
            return PartialView("_PagingSPAPartial", pagingModel);
        }

        public IActionResult FindJob()
        {
            return View();
        }

        [HttpGet]
        public IActionResult JobDetail(int id)
        {
            var data = mediator.Send(new GetJobPostDetailQuery(id)).GetAwaiter().GetResult();
            return View(data);
        }

        public IActionResult FresherJob()
        {
            try
            {
                var request = new GetCompanyWithPaginationQuery(0, 10);
                var data = mediator.Send(request).GetAwaiter().GetResult();

                data.Items = data.Items.OrderByDescending(i => i.TotalJob).ToList();
                return View(data);
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> JobByCategory(int categoryId) 
        {
            var request = new GetJobTypeByIdQuery(categoryId);
            var result = await mediator.Send(request); 
            return View(result);
        }

        [HttpGet]
        public IActionResult GetJobByCategory(int categoryId, ConditionViewModel condition)
        {
            try
            {
                int pageSize = 5;
                int pageNumber = condition.pageNumber ?? 0;
                var request = new GetJobPostByCategoryQuery(categoryId);
                var response = mediator.Send(request).GetAwaiter().GetResult();

                if (condition.sortBy != null)
                {
                    switch (condition.sortBy.ToLower())
                    {
                        case "fulltime":
                            response = response.Where(i => i.EmploymentType.ToLower().Equals("fulltime")).ToList();
                            break;
                        case "parttime":
                            response = response.Where(i => i.EmploymentType.ToLower().Equals("parttime")).ToList();
                            break;
                        case "remote":
                            response = response.Where(i => i.EmploymentType.ToLower().Equals("remote")).ToList();
                            break;
                        case "freelancer":
                            response = response.Where(i => i.EmploymentType.ToLower().Equals("freelancer")).ToList();
                            break;
                    }
                }


                response = response.OrderByDescending(i => i.CreateAt).ToList();
                string? keyword = condition.keyword?.ToLower();
                string? level = condition.level?.ToLower();
                level = (level != null && (level.Contains("kinh nghiệm") || level.Contains("tất cả"))) ? "" : level;

                string? provinceName = condition.provinceName?.Trim().ToLower();
                provinceName = (provinceName != null && provinceName.Contains("tất cả thành phố")) ? "" : provinceName;
                int? salary = condition.salary;

                //Lọc theo các điều kiện
                response = response.Where(i => (i.Title.ToLower().Contains(keyword ?? "")
                || i.Title.ToLower().Contains(keyword ?? "")
                || i.CompanyName.ToLower().Contains(keyword ?? "")
                || i.Skills.Any(s => s.ToLower().Contains(keyword ?? "")))
                    && i.Province.ToLower().Contains(provinceName ?? "")
                    && isSalaryInRange(salary, i.Salary)
                    && i.Level.ToLower().Contains(level ?? ""))
                    .ToList();

                var data = response.ToPaginatedListAsync(pageNumber, pageSize, new CancellationToken()).GetAwaiter().GetResult();
                return Json(data);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }
    }
}
