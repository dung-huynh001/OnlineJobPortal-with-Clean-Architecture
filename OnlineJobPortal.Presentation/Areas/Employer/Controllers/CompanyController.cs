using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.BussinessIndustryFeatures.Queries;
using OnlineJobPortal.Application.Futures.CompanyFeatures.Queries;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Presentation.Areas.Employer.Models;
using OnlineJobPortal.Application.Interfaces;

namespace OnlineJobPortal.Presentation.Areas.Employer.Controllers
{
    [Area("Employer")]
    public class CompanyController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;
        private readonly ICurrentUserService currentUserSevice;

        public CompanyController(IMapper mapper, IMediator mediator, ICurrentUserService currentUserSevice)
        {
            this.mapper = mapper;
            this.mediator = mediator;
            this.currentUserSevice = currentUserSevice;
        }

        [HttpGet]
        public IActionResult CompanyProfile(int employerId)
        {
            Company company = mediator.Send(new GetCompanyDetailQuery(employerId)).GetAwaiter().GetResult();
            ViewData["BussinessIndustrys"] = mediator.Send(new GetAllBussinessIndustryQuery()).GetAwaiter().GetResult();
            var data = mapper.Map<CompanyProfileViewModel>(company);
            return View(data);
        }

        [HttpPost]
        public IActionResult CompanyProfile([FromForm] CompanyProfileViewModel companyProfile)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("CompanyProfile", "Company", new { area = "Employer", employerId = 2 });

            }
            else
            {
                int id = currentUserSevice.GetActorId();
                return RedirectToAction("CompanyProfile", "Company", new { area = "Employer", employerId = id });
            }
            
        }

    }
}
