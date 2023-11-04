using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.CompanyFeatures.Queries;
using OnlineJobPortal.Application.Futures.JobPostFeatures.Queries;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
using System.Drawing.Printing;

namespace OnlineJobPortal.Presentation.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public CompanyController(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CompanyDetail(int id) 
        {
            var result = await mediator.Send(new GetCompanyDetailQuery(id));
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetJobWithPaginationByCompanyId(int id, int currentItems)
        {
            try
            {
                int pageSize = 4;
                int pageNumber = currentItems % pageSize == 0 ?
                    currentItems / pageSize + 1 :
                    pageNumber = currentItems / pageSize + 2;

                if (currentItems % pageSize != 0)
                    throw new Exception();

                var data = await mediator.Send(new GetJobPostByCompanyIdQuery(id, pageNumber, pageSize));
                return Json(data);
            }
            catch(Exception ex)
            {
                return Json(ex.Message);
            }
        }

        public IActionResult GetCompanyList(int currentItems, string keyword)
        {
            try
            {
                int pageSize = 10;
                int pageNumber = currentItems % pageSize == 0 ?
                    currentItems / pageSize + 1 :
                    currentItems / pageSize + 2;

                if (currentItems % pageSize != 0)
                    throw new Exception();

                var request = new GetCompanyWithPaginationQuery(pageNumber, pageSize);
                var data = mediator.Send(request).GetAwaiter().GetResult();
                
                string Keyword = keyword != null ? keyword.ToLower() : "";
                data.Items = data.Items.Where(i => i.CompanyName.ToLower().Contains(Keyword)).ToList();
                return Json(data);
            }
            catch(Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetLogoTopCompany()
        {
            try
            {
                var request = new GetCompanyWithPaginationQuery(0, 10);
                var data = mediator.Send(request).GetAwaiter().GetResult();

                data.Items = data.Items.OrderByDescending(i => i.TotalJob).ToList();
                return Json(data);
            }
            catch(Exception ex)
            {
                return Json(ex.Message);
            }
        }

        public IActionResult TopCompany(int pageNumber) 
        {
            int pageSize = 9;
            var request = new GetCompanyWithPaginationQuery(pageNumber, pageSize);
            var data = mediator.Send(request).GetAwaiter().GetResult();
            data.Items = data.Items.OrderByDescending(c => c.TotalJob).ToList();
            return View(data);
        }
    }
}
