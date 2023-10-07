using AutoMapper;
using OnlineJobPortal.Application.DTOs.JobPostDto;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Mapping
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<JobPostDto, JobPost>().ReverseMap();
        }
    }
}
