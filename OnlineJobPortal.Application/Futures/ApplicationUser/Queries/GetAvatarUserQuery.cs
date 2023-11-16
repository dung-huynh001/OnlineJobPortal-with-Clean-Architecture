using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.ApplicationUserDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ApplicationUser.Queries
{
    public class GetAvatarUserQuery : IRequest<UserWithAvatarDto>
    {
        public GetAvatarUserQuery(string userId)
        {
            UserId = userId;
        }

        public string UserId { get; }
    }

    public class GetAvatarUserQueryHandler : IRequestHandler<GetAvatarUserQuery, UserWithAvatarDto>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IApplicationUserRepository applicationUserRepository;

        public GetAvatarUserQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, IApplicationUserRepository applicationUserRepository)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.applicationUserRepository = applicationUserRepository;
        }
        public async Task<UserWithAvatarDto> Handle(GetAvatarUserQuery request, CancellationToken cancellationToken)
        {
            var result = applicationUserRepository.GetAvatarUser(request.UserId).Result;
            return result;
        }
    }
}
