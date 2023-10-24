using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.CompanyFeatures.Commands;
using OnlineJobPortal.Application.Responses;

namespace OnlineJobPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public CompanyController(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateCompanyCommand request){
            var result = await mediator.Send(request);
            if (!result.Success)
            {
                return BadRequest();
            }
            return StatusCode(StatusCodes.Status201Created, request);
        }
    }
}
