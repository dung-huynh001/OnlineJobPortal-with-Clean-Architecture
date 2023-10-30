using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineJobPortal.Application.Futures.JobPostFeatures.Queries;

namespace OnlineJobPortal.Presentation.Controllers
{
    public class JobPostController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public JobPostController(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetJobWithPagination(int currentItems, string sortBy)
        {
            try
            {
                int pageSize = 10;
                int pageNumber = currentItems / pageSize + 1;

                if (currentItems % pageSize == 0)
                {
                    pageNumber = currentItems / pageSize + 1;
                }
                else
                {
                    pageNumber = currentItems / pageSize + 2;
                }

                if (currentItems > 0 && currentItems < pageSize)
                {
                    throw new Exception();
                }

                GetJobPostWithPaginationQuery request = new GetJobPostWithPaginationQuery(pageNumber, pageSize);
                var items = mediator.Send(request).GetAwaiter().GetResult();
                if(sortBy != null)
                {
                    switch (sortBy.ToLower())
                    {
                        case "all":
                            items.Items = items.Items.OrderByDescending(i => i.CreateAt).ToList();
                            break;
                        case "fulltime":
                            items.Items = items.Items.Where(i => i.EmploymentType.Equals("FullTime")).ToList();
                            break;
                        case "parttime":
                            items.Items = items.Items.Where(i => i.EmploymentType.Equals("PartTime")).ToList();
                            break;
                        case "remote":
                            items.Items = items.Items.Where(i => i.EmploymentType.Equals("Remote")).ToList();
                            break;
                        case "freelancer":
                            items.Items = items.Items.Where(i => i.EmploymentType.Equals("Freelancer")).ToList();
                            break;
                    }
                }
                items.Items = items.Items.OrderByDescending(i => i.CreateAt).ToList();
                return Json(items);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
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


        public IActionResult JobList() 
        { 
            return View(); 
        }

        public IActionResult FresherJob()
        {
            return View();
        }
    }
}
