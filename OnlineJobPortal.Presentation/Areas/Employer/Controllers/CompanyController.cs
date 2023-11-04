using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.BussinessIndustryFeatures.Queries;
using OnlineJobPortal.Application.Futures.CompanyFeatures.Queries;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Presentation.Areas.Employer.Models;
using OnlineJobPortal.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using OnlineJobPortal.Application.DTOs.LocationDto;
using OnlineJobPortal.Application.Futures.LocationFeatures.Commands;
using OnlineJobPortal.Application.DTOs.CompanyDto;
using OnlineJobPortal.Application.Futures.CompanyFeatures.Commands;
using Microsoft.AspNetCore.Hosting;

namespace OnlineJobPortal.Presentation.Areas.Employer.Controllers
{
    [Area("Employer")]
    [Authorize(Roles = "Employer")]
    public class CompanyController : Controller
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;
        private readonly ICurrentUserService currentUserSevice;
        private readonly IUploadService uploadService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CompanyController(IMapper mapper, IMediator mediator, 
            ICurrentUserService currentUserSevice, 
            IUploadService uploadService, 
            IWebHostEnvironment webHostEnvironment)
        {
            this.mapper = mapper;
            this.mediator = mediator;
            this.currentUserSevice = currentUserSevice;
            this.uploadService = uploadService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult CompanyProfile(int employerId)
        {
            Company company = mediator.Send(new GetCompanyProfileQuery(employerId)).GetAwaiter().GetResult();
            ViewData["BussinessIndustrys"] = mediator.Send(new GetAllBussinessIndustryQuery()).GetAwaiter().GetResult();
            var data = mapper.Map<CompanyProfileViewModel>(company);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> CompanyProfile([FromForm] CompanyProfileViewModel model)
        {
            try
            {
                int id = currentUserSevice.GetActorId();

                if (ModelState.IsValid)
                {
                    if (model.CompanyLogo != null)
                    {
                        string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/CompanyImg");
                        string logoUrl = await uploadService.UploadImageAsync(model.CompanyLogo, uploadsFolder);
                        model.LogoUrl = logoUrl;
                    }

                    var location = mapper.Map<CreateLocationDto>(model);
                    var createLocationCommand = new CreateLocationCommand();
                    createLocationCommand.Location = location;
                    await mediator.Send(createLocationCommand);

                    var company = mapper.Map<UpdateCompanyDto>(model);
                    var updateCompanyCommand = new UpdateCompanyCommand(company);
                    var result = await mediator.Send(updateCompanyCommand);

                    return RedirectToAction("CompanyProfile", "Company", new { area = "Employer", employerId = id });

                }
                throw new Exception();
            }
            catch
            {
                int id = currentUserSevice.GetActorId();
                return RedirectToAction("CompanyProfile", "Company", new { area = "Employer", employerId = id });
            }



        }

    }
}
