﻿using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ExperienceFeatures.Commands
{
    public class CreateExperienceCommand : IRequest<Experience?>
    {
        public int ResumeId { get; set; }
        public List<int> Skills { get; set; }
        public Experience Experience { get; set; }
        public CreateExperienceCommand(int resumeId, List<int> skills, Experience experience)
        {
            ResumeId = resumeId;
            Skills = skills;
            Experience = experience;
        }
    }
    public class CreateExperienceCommandHandler : IRequestHandler<CreateExperienceCommand, Experience?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateExperienceCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<Experience?> Handle(CreateExperienceCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var experience = request.Experience;
                experience.ResumeId = request.ResumeId;
                experience.ExperienceSkills = new List<ExperienceSkill>();
                var skills = unitOfWork.Repository<Skill>().GetAll
                                .Where(s => request.Skills.Contains(s.Id))
                                .ToList();

                foreach (var skill in skills)
                {
                    var experienceSkill = new ExperienceSkill
                    {
                        Skill = skill,
                        Experience = experience
                    };
                    await unitOfWork.Repository<ExperienceSkill>().AddAsync(experienceSkill);
                }

                await unitOfWork.Repository<Experience>().AddAsync(experience);
                unitOfWork.Commit();

                return experience;
            }
            catch
            {
                unitOfWork.Rollback();
                return null;
            }
        }
    }
}
