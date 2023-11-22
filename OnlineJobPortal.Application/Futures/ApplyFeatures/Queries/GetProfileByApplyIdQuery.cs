using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.DTOs.ApplyDto;
using OnlineJobPortal.Application.DTOs.EducationDto;
using OnlineJobPortal.Application.DTOs.ExperienceDto;
using OnlineJobPortal.Application.DTOs.ForeignLanguageDto;
using OnlineJobPortal.Application.DTOs.ProjectDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ApplyFeatures.Queries
{
    public class GetProfileByApplyIdQuery : IRequest<ProfileDto>
    {
        public GetProfileByApplyIdQuery(int applyId)
        {
            ApplyId = applyId;
        }

        public int ApplyId { get; }
    }

    public class GetProfileByApplyIdQueryHandler : IRequestHandler<GetProfileByApplyIdQuery, ProfileDto>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetProfileByApplyIdQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ProfileDto> Handle(GetProfileByApplyIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var profileDto = new ProfileDto();

                var apply = await unitOfWork.Repository<Apply>().GetByIdAsync(request.ApplyId);
                var candidate = await unitOfWork.Repository<Candidate>().GetByIdAsync(apply!.CandidateId);
                var resume = await unitOfWork.Repository<Resume>().GetAll
                    .FirstOrDefaultAsync(r => r.CandidateId == candidate!.Id);
                var candidateSkills = await unitOfWork.Repository<Resume>()
                    .GetAll
                    .Where(r => r.CandidateId == candidate!.Id)
                    .Include(r => r.CandidateSkills).ThenInclude(cs => cs.Skill)
                    .Select(r => r.CandidateSkills.Select(cs => cs.Skill.SkillName).ToList())
                    .FirstOrDefaultAsync();

                var experiences = await unitOfWork.Repository<Experience>().GetAll
                    .Where(e => e.ResumeId == resume!.Id)
                    .Include(e => e.ExperienceProjects)
                    .Include(e => e.ExperienceSkills)
                    .Select(e => new GetExperienceDto
                    {
                        Id = e.Id,
                        Position = e.Position,
                        CompanyName = e.CompanyName,
                        Description = e.Description,
                        StartDate = e.StartDate,
                        EndDate = e.EndDate,
                        Skills = e.ExperienceSkills!.Select(es => es.Skill.SkillName).ToList(),
                        Projects = e.ExperienceProjects!.Select(ep => new GetExperienceProjectDto
                        {
                            Id = ep.Id,
                            EndDate = ep.EndDate,
                            StartDate = ep.StartDate,
                            Position = ep.Position,
                            Title = ep.Title
                        }).ToList()
                    })
                    .ToListAsync();

                var educations = await unitOfWork.Repository<Education>().GetAll
                    .Where(e => e.ResumeId == resume!.Id)
                    .Select(e => new GetEducationDto
                    {
                        Major = e.Major,
                        University = e.University,
                        StartDate = e.StartDate,
                        CompletionDate = e.CompletionDate,
                        GPA = e.GPA
                    })
                    .ToListAsync();

                var projects = await unitOfWork.Repository<Project>().GetAll
                    .Where(e => e.ResumeId == resume!.Id)
                    .Select(e => new GetProjectDto
                    {
                        Title = e.Title,
                        Position = e.Position,
                        StartDate = e.StartDate,
                        EndDate = e.EndDate,
                        LinkGit = e.LinkGit,
                        Description = e.Description
                    })
                    .ToListAsync();

                var foreignLanguage = await unitOfWork.Repository<ForeignLanguage>().GetAll
                    .Where(e => e.ResumeId == resume!.Id)
                    .Select(e => new GetForeignLanguageDto
                    {
                        LanguageName = e.LanguageName,
                        Degree = e.Degree
                    })
                    .ToListAsync();

                profileDto = mapper.Map<ProfileDto>(apply);
                profileDto.FullName = candidate!.FullName;
                profileDto.AvatarUrl = candidate!.AvatarUrl;
                profileDto.Position = resume!.Position;
                profileDto.YearOfExperiences = resume!.YearOfExperiences;
                profileDto.Experiences = experiences;
                profileDto.Educations = educations;
                profileDto.Projects = projects;
                profileDto.ForeignLanguages = foreignLanguage;
                profileDto.Skills = candidateSkills!;

                return profileDto;
            }
            catch
            {
                return new ProfileDto();
            }
        }
    }
}
