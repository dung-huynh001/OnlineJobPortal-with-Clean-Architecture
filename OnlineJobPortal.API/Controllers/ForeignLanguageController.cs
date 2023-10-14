using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.ForeignLangugeFeatures.Commands;

namespace OnlineJobPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForeignLanguageController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public ForeignLanguageController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateForeignLanguageCommand request)
        {
            var result = await mediator.Send(request);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return await Create(request);
        }
    }
}
