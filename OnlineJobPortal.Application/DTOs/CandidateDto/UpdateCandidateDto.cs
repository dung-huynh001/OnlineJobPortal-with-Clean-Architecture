﻿using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.CandidateDto
{
    public class UpdateCandidateDto : BaseDto
    {
        public string FullName { get; set; }
        public string NationalId { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string AvatarUrl { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
