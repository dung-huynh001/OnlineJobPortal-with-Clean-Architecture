using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Owner { get; set; }
        public DateTime EstablishmentDate { get; set; }

        public string Address { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? WebsiteUrl { get; set; }

        public int DistrictId { get; set; }
        public int ProvinceId { get; set; }
        public District District { get; set; }

        public int? BussinessIndustryId { get; set; }
        public BussinessIndustry? BussinessIndustry { get; set; }

        public ICollection<CompanyImage>? CompanyImages { get; set; }

        public ICollection<Employer>? Employers { get; set; }

    }
}
