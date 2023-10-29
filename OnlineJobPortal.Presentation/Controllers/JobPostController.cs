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
        public IActionResult GetJobWithPagination(int currentItems)
        {
            try
            {
                int pageSize = 10;
                int pageNumber = currentItems / pageSize;
                GetNewJobPostWithPaginationQuery request = new GetNewJobPostWithPaginationQuery(pageNumber, pageSize);
                var items = mediator.Send(request).GetAwaiter().GetResult();
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
            return View();
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
