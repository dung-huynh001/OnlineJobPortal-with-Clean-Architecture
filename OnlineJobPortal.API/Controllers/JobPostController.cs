using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.JobPostFeatures.Commands;

namespace OnlineJobPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostController : ControllerBase
    {
        private readonly IMediator mediator;

        public JobPostController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateJobPostCommand createJobPostCommand)
        {
            var result = await mediator.Send(createJobPostCommand);

            if(!result.Success)
                return BadRequest(result.Message);

            return StatusCode(StatusCodes.Status201Created, createJobPostCommand);
        }
    }
}
