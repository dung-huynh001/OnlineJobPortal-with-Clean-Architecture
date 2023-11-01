using AutoMapper;
using OnlineJobPortal.Application.DTOs.CompanyDto;
using OnlineJobPortal.Application.DTOs.EmployerDto;
using OnlineJobPortal.Application.DTOs.JobPostDto;
using OnlineJobPortal.Application.DTOs.LocationDto;
using OnlineJobPortal.Application.DTOs.RequirementSkillDto;
using OnlineJobPortal.Application.DTOs.SkillDto;
using OnlineJobPortal.Application.Futures.DistrictFeatures.Commands;
using OnlineJobPortal.Application.Futures.ProvinceFeatures.Commands;
using OnlineJobPortal.Application.Models.Identity;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Presentation.Areas.Employer.Models;
using OnlineJobPortal.Presentation.Models;

namespace OnlineJobPortal.Presentation.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        { 
            CreateMap<RegisterEmployerViewModel, RegistrationEmployerRequest>().ReverseMap();

            CreateMap<RegisterEmployerViewModel, CreateDistrictCommand>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DistrictId))
                .ReverseMap();

            CreateMap<RegisterEmployerViewModel, CreateProvinceCommand>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ProvinceId))
                .ReverseMap();

            CreateMap<RegistrationEmployerRequest, CreateCompanyDto>().ReverseMap();
            CreateMap<RegistrationEmployerRequest, CreateEmployerDto>().ReverseMap();


            CreateMap<RegisterEmployerViewModel, CreateLocationDto>().ReverseMap();
            CreateMap<JobPostViewModel, CreateLocationDto>().ReverseMap();

            CreateMap<JobPostViewModel, CreateRequirementSkillDto>().ReverseMap();
            CreateMap<JobPostViewModel, CreateJobPostDto>().ReverseMap();

            CreateMap<Company, CompanyProfileViewModel>().ReverseMap();

            CreateMap<CompanyProfileViewModel, CreateLocationDto>().ReverseMap();
            CreateMap<CompanyProfileViewModel, UpdateCompanyDto>().ReverseMap();
        }
    }
}
