using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.AdminDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.AdminFeatures.Queries
{
    public class GetAllAdminsQuery : IRequest<ApiResponse>
    {

    }

    public class GetAllAdminsQueryHandler : IRequestHandler<GetAllAdminsQuery, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllAdminsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(GetAllAdminsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var admindtos = new List<AdminDto>();
                var admins = await unitOfWork.Repository<Admin>().GetAllAsync();

                if(admins == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "No admins found."
                    };
                }

                foreach (var admin in admins) 
                {
                    var admindto = mapper.Map<AdminDto>(admin);
                    admindtos.Add(admindto);
                }

                return new ApiResponse
                {
                    Success = true,
                    Message = "Got all admins successfully.",
                    Data = admindtos
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = true,
                    Message = "Get all admins failed! Something went wrong.",
                };
            }
        }
    }
}
