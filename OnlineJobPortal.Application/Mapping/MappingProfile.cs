using AutoMapper;
using OnlineJobPortal.Application.DTOs.AdminDto;
using OnlineJobPortal.Application.DTOs.ApplicationDto;
using OnlineJobPortal.Application.DTOs.BussinessIndustryDto;
using OnlineJobPortal.Application.DTOs.CandidateDto;
using OnlineJobPortal.Application.DTOs.CandidateSkillDto;
using OnlineJobPortal.Application.DTOs.ForeignLanguageDto;
using OnlineJobPortal.Application.DTOs.JobPostDto;
using OnlineJobPortal.Application.DTOs.RequirementSkillDto;
using OnlineJobPortal.Application.DTOs.SkillDto;
using OnlineJobPortal.Application.Models.Identity;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<JobPostDto, JobPost>().ReverseMap();
            CreateMap<CreateJobPostDto, JobPost>().ReverseMap();

            CreateMap<AdminDto, Admin>().ReverseMap();
            CreateMap<CreateAdminDto, Admin>().ReverseMap();
            CreateMap<UpdateAdminDto, Admin>().ReverseMap();

            CreateMap<ApplicationUser, RegistrationRequest>().ReverseMap();

            CreateMap<UpdateBussinessIndustryDto, BussinessIndustry>().ReverseMap();

            CreateMap<ForeignLanguageDto, ForeignLanguage>().ReverseMap();

            CreateMap<SkillDto, Skill>().ReverseMap();
            CreateMap<CreateSkillDto, Skill>().ReverseMap();

            CreateMap<CreateCandidateDto, Candidate>().ReverseMap();
            CreateMap<UpdateCandidateDto, Candidate>().ReverseMap();

            CreateMap<CreateCandidateSkillDto, CandidateSkill>().ReverseMap();
            CreateMap<UpdateCandidateSkillDto, CandidateSkill>().ReverseMap();

            CreateMap<CreateRequirementSkillDto, RequirementSkill>().ReverseMap();
            CreateMap<UpdateRequirementSkillDto, RequirementSkill>().ReverseMap();
        }
    }
}
