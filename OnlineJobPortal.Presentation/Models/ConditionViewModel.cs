using Newtonsoft.Json;
using OnlineJobPortal.Domain.Enums;

namespace OnlineJobPortal.Presentation.Models
{
    public class ConditionViewModel
    {
        // public int? currentItems { get; set; }
        public int? pageNumber { get; set; }
        public string? sortBy { get; set; }
        public string? keyword { get; set; }

        public string? level { get; set; }

        public string? provinceName { get; set; }
        public int? salary { get; set; }
    }
}
