using OnlineJobPortal.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.BussinessIndustryDto
{
    public class GetBussinessIndustryDto : BaseDto
    {
        public string BussinessName { get; set; }
    }
}
