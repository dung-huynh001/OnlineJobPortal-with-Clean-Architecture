using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.DTOs.AdminDto;
using OnlineJobPortal.Application.Futures.AdminFeatures.Commands;
using OnlineJobPortal.Application.Futures.AdminFeatures.Queries;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Infrastructure.Implementation;
using System.Net;

namespace OnlineJobPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ICurrentUserService currentUserSevice;

        public AdminController(IMediator mediator, ICurrentUserService currentUserSevice)
        {
            this.mediator = mediator;
            this.currentUserSevice = currentUserSevice;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<AdminDto>> GetAll([FromQuery]GetAllAdminsQuery request)
        {
            var result = await mediator.Send(request);

            return (IEnumerable<AdminDto>)result.Data;
        }

        [HttpGet("GetById")]
        [Authorize(Roles = "Admin")]
        public async Task<AdminDto> GetById([FromQuery]GetAdminByIdQuery request)
        {
            var result = await mediator.Send(request);

            return (AdminDto)result.Data;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateAdminCommand createAdminCommand)
        {
            var result = await mediator.Send(createAdminCommand);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return StatusCode(StatusCodes.Status201Created, createAdminCommand);
        }

        [HttpGet("GetCurrentUser")]
        [Authorize]
        public IActionResult GetCurrentUser()
        {
            var user = currentUserSevice.UserId;
            return Ok(user);
        }
    }
}
