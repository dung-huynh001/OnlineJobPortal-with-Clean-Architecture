using AutoMapper;
using OnlineJobPortal.Application.DTOs.ApplicationDto;
using OnlineJobPortal.Application.DTOs.BussinessIndustryDto;
using OnlineJobPortal.Application.DTOs.JobPostDto;
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
            CreateMap<ApplicationUser, RegistrationRequest>().ReverseMap();
            CreateMap<BussinessIndustryDto, BussinessIndustry>().ReverseMap();
        }
    }
}
