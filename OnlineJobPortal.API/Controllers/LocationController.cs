using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Application.Futures.DistrictFeatures.Commands;
using OnlineJobPortal.Application.Futures.ProvinceFeatures.Commands;

namespace OnlineJobPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public LocationController(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        [HttpPost("AddProvince")]
        public async Task<IActionResult> AddProvince(CreateProvinceCommand request)
        {
            var result = await mediator.Send(request);
            if (!result.Success)
            {
                return BadRequest();
            }
            return StatusCode(StatusCodes.Status201Created, request);
        }

        [HttpPost("AddDistrict")]
        public async Task<IActionResult> AddDistrict(CreateDistrictCommand request)
        {
            var result = await mediator.Send(request);
            if (!result.Success)
            {
                return BadRequest();
            }
            return StatusCode(StatusCodes.Status201Created, request);
        }

    }
}
