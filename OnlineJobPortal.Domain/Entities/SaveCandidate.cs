using OnlineJobPortal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Domain.Entities
{
    public class SaveCandidate : BaseEntity
    {
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
