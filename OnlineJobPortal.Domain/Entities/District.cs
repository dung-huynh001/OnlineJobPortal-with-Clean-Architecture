using OnlineJobPortal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Domain.Entities
{
    public class District : BaseEntity
    {
        public string DistrictName { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }

        public ICollection<Company> Companies { get; set; }
        public ICollection<JobPost> JobPosts { get; set; }

    }
}
