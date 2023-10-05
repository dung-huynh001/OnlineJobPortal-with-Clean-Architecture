﻿using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class CandidateSkill : BaseEntity
    {
        public string BussinessName { get; set; }

        public int CompanyId { get; set; }
        public ICollection<Company> Companies { get; set;}
    }
}
