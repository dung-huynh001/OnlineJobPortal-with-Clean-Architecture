using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.AdminFeatures.Commands;
using System.Net;

namespace OnlineJobPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMediator mediator;

        public AdminController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateAdminCommand createAdminCommand)
        {
            var result = await mediator.Send(createAdminCommand);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return StatusCode(StatusCodes.Status201Created, createAdminCommand);
        }
    }
}
