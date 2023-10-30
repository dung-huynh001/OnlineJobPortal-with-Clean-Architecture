using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.JobTypeFeatures.Queries;

namespace OnlineJobPortal.Presentation.Controllers
{
    public class JobTypeController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public JobTypeController(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetJobTypeWithPagination(int currentItems)
        {
            try
            {
                int pageSize = 8;

                int pageNumber = 0;

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

                GetJobTypeWithPaginationQuery request = new GetJobTypeWithPaginationQuery(pageNumber, pageSize);
                var data = mediator.Send(request).GetAwaiter().GetResult();

                return Json(data);
            }
            catch(Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }
    }
}
