using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.DTOs.JobPostDto;
using OnlineJobPortal.Application.DTOs.LocationDto;
using OnlineJobPortal.Application.DTOs.SkillDto;
using OnlineJobPortal.Application.Futures.JobPostFeatures.Commands;
using OnlineJobPortal.Application.Futures.JobPostFeatures.Queries;
using OnlineJobPortal.Application.Futures.JobTypeFeatures.Queries;
using OnlineJobPortal.Application.Futures.LocationFeatures.Commands;
using OnlineJobPortal.Application.Futures.SkillFeatures.Queries;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Presentation.Areas.Employer.Models;

namespace OnlineJobPortal.Presentation.Areas.Employer.Controllers
{
    [Area("Employer")]
    [Authorize(Roles = "Employer")]
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

        public IActionResult ManageJobPosts()
        {
            return View();
        }

        public async Task<IActionResult> GetAllJobPost()
        {
            var employerId = currentUserService.GetActorId();
            var data = await mediator.Send(new GetAllJobPostByEmployerIdQuery(employerId));
            return Json(new {data = data});
        }

        public async Task<IActionResult> PostANewJob()
        {
            var skillList = await mediator.Send(new GetAllSkillsQuery());
            var jobTypeList = await mediator.Send(new GetAllJobTypeQuery());

            ViewBag.SkillList = skillList;
            ViewBag.JobTypeList = jobTypeList;

            return View();
        }

        [HttpGet]
        public IActionResult ShowJobPostDetail(int id){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostANewJob(JobPostViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var location = mapper.Map<CreateLocationDto>(model);
                    var createLocationCommand = new CreateLocationCommand();
                    createLocationCommand.Location = location;
                    await mediator.Send(createLocationCommand);


                    if (!model.Salary.ToLower().Contains("triệu") && !model.Salary.ToLower().Contains("thỏa thuận"))
                        model.Salary += " triệu";

                    var createJobPostCommand = new CreateJobPostCommand();
                    createJobPostCommand.CreateJobPostDto = mapper.Map<CreateJobPostDto>(model);
                    var result = await mediator.Send(createJobPostCommand);
                    if(!result.Success) 
                    {
                        throw new Exception();
                    }

                    ModelState.Clear();
                    ViewBag.Message = "Đăng tin tuyển dụng thành công";
                    return View();
                    //return RedirectToAction("Index", "Home", new {area = "Employer"});
                }
                throw new Exception();
            }
            catch
            {
                var skillList = await mediator.Send(new GetAllSkillsQuery());
                var jobTypeList = await mediator.Send(new GetAllJobTypeQuery());

                ViewBag.SkillList = skillList;
                ViewBag.JobTypeList = jobTypeList;
                ViewBag.Message = "Vui lòng kiểm tra lại thông tin tuyển dụng";
                return View(model);
            }
        }
    }
}
