using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.ApplyDto
{
    public class ColumnBarChartDto
    {
        public DateTime Date { get; set; }
        public int Total { get; set; }
        public int PendingJobs { get; set; }
        public int ViewedJobs { get; set; }
    }
}
