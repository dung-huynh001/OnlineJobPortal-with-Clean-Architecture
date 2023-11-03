using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.CompanyFeatures.Queries;
using OnlineJobPortal.Application.Futures.JobPostFeatures.Queries;

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
        public IActionResult CompanyDetail(int id) 
        {
            return View();
        }

        public IActionResult GetCompanyList(int currentItems)
        {
            int pageSize = 5;
            int pageNumber = currentItems % pageSize == 0 ? 
                currentItems / pageSize + 1 : 
                pageNumber = currentItems / pageSize + 2;

            if (currentItems % pageSize != 0)
                throw new Exception();

            var request = new GetCompanyWithPaginationQuery(pageNumber, pageSize);
            var data = mediator.Send(request).GetAwaiter().GetResult();

            return Json(data);
        }

        public IActionResult TopCompany() 
        { 
            return View();
        }
    }
}
