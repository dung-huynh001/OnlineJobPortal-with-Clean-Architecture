﻿using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.SkillDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.SkillFeatures.Queries
{
    public class GetAllSkillsQuery : IRequest<List<GetSkillDto>>
    {

    }

    public class GetAllSkillsQueryHandler : IRequestHandler<GetAllSkillsQuery, List<GetSkillDto>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllSkillsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<GetSkillDto>> Handle(GetAllSkillsQuery request, CancellationToken cancellationToken)
        {
            var skillListDto = new List<GetSkillDto>();
            var skillList = await unitOfWork.Repository<Skill>().GetAllAsync();

            foreach (var skill in skillList) 
            {
                var skillDto = mapper.Map<GetSkillDto>(skill);
                skillListDto.Add(skillDto);
            }

            return skillListDto;
        }
    }
}
