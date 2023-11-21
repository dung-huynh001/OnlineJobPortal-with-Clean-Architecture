using System.Text;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineJobPortal.Application.DTOs.JobPostDto;
using OnlineJobPortal.Application.DTOs.LocationDto;
using OnlineJobPortal.Application.DTOs.SkillDto;
using OnlineJobPortal.Application.Futures.ApplyFeatures.Commands;
using OnlineJobPortal.Application.Futures.ApplyFeatures.Queries;
using OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Queries;
using OnlineJobPortal.Application.Futures.JobPostFeatures.Commands;
using OnlineJobPortal.Application.Futures.JobPostFeatures.Queries;
using OnlineJobPortal.Application.Futures.JobTypeFeatures.Queries;
using OnlineJobPortal.Application.Futures.LocationFeatures.Commands;
using OnlineJobPortal.Application.Futures.ResumeFeatures.Queries;
using OnlineJobPortal.Application.Futures.SkillFeatures.Queries;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Presentation.Areas.Employer.Models;
using OnlineJobPortal.Presentation.Models;
using static OnlineJobPortal.Presentation.Controllers.JobPostController;

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
            return Json(new { data = data });
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
        public IActionResult ShowJobPostDetail(int id)
        {
            var data = mediator.Send(new GetJobPostByIdQuery(id)).GetAwaiter().GetResult();
            return View(data);
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


                    if (!model.Salary!.ToLower().Contains("triệu") && !model.Salary.ToLower().Contains("thỏa thuận"))
                        model.Salary += " triệu";

                    var createJobPostCommand = new CreateJobPostCommand();
                    createJobPostCommand.CreateJobPostDto = mapper.Map<CreateJobPostDto>(model);
                    var result = await mediator.Send(createJobPostCommand);
                    if (!result.Success)
                    {
                        throw new Exception();
                    }

                    ModelState.Clear();
                    ViewBag.Message = "Đăng tin tuyển dụng thành công";
                    return View();
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

        [HttpDelete]
        public async Task<IActionResult> DeleteJobPost(int jobPostId)
        {
            var success = await mediator.Send(new DeleteJobPostCommand(jobPostId));
            return Json(success);
        }

        [HttpPatch]
        public async Task<IActionResult> RejectCandidate(int applyId){
            var success = await mediator.Send(new RejectProfileCommand(applyId));
            return Json(success);
        }

        [HttpPatch]
        public async Task<IActionResult> ApprovalCandidate(int applyId)
        {
            var success = await mediator.Send(new ApprovalProfileCommand(applyId));
            return Json(success);
        }

        [HttpPatch]
        public async Task<IActionResult> MarkViewedProfile(int applyId)
        {
            var success = await mediator.Send(new MarkViewedProfileCommand(applyId));
            return Json(success);
        }

        [HttpGet]
        public async Task<IActionResult> LoadProfile(int applyId)
        {
            var result = await mediator.Send(new GetProfileByApplyIdQuery(applyId));
            return Json(result);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetSuggestJobPosts(ConditionViewModel condition)
        {
            // Dữ liệu Resume để gửi đi
            var defaultResume = new
            {
                skills = new List<string>(),
                experience = "",
                education = ""
            };
            var candidateId = currentUserService.GetActorId();
            var userResume = await mediator.Send(new GetResumeToSuggestJobsQuery(candidateId));

            // URL của API Python
            var apiUrl = "http://localhost:5000/suggest-candidates";

            // Sử dụng HttpClient để gọi API Python
            using (var client = new HttpClient())
            {
                var jsonContent = new StringContent(JsonConvert.SerializeObject(new { resume = defaultResume }), Encoding.UTF8, "application/json");

                // Chuyển đổi dữ liệu Resume thành chuỗi JSON
                if (userResume != null)
                {
                    jsonContent = new StringContent(JsonConvert.SerializeObject(new { resume = userResume }), Encoding.UTF8, "application/json");

                }

                // Gửi yêu cầu POST đến API Python
                var response = await client.PostAsync(apiUrl, jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var suggestedJobs = JsonConvert.DeserializeObject<SuggestJobResponse>(responseData);

                    var data = suggestedJobs?.Recommendations;
                    int pageSize = 5;
                    int pageNumber = condition.pageNumber ?? 0;
                    if (condition.sortBy != null)
                    {
                        switch (condition.sortBy.ToLower())
                        {
                            case "fulltime":
                                data = data?.Where(i => i.EmploymentType == 0).ToList();
                                break;
                            case "parttime":
                                data = data?.Where(i => i.EmploymentType == 1).ToList();
                                break;
                            case "remote":
                                data = data?.Where(i => i.EmploymentType == 2).ToList();
                                break;
                            case "freelancer":
                                data = data?.Where(i => i.EmploymentType == 3).ToList();
                                break;
                        }
                    }

                    string? keyword = condition.keyword?.ToLower();
                    string? level = condition.level?.ToLower();
                    level = (level != null && (level.Contains("kinh nghiệm") || level.Contains("tất cả"))) ? "" : level;

                    string? provinceName = condition.provinceName?.Trim().ToLower();
                    provinceName = (provinceName != null && provinceName.Contains("tất cả thành phố")) ? "" : provinceName;
                    int? salary = condition.salary;

                    var favoriteJobs = await mediator.Send(new GetAllJobFavoriteIdQuery());
                    foreach (var jobPost in data!)
                    {
                        jobPost.Saved = favoriteJobs.Any(id => id == jobPost.JobPostId);
                    }

                    return Json(data);
                }
                else
                {
                    // Xử lý lỗi nếu có
                    return Json("Error");
                }
            }
        }
    }
}
