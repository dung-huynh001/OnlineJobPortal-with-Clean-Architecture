using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineJobPortal.Presentation.Models
{
    public class AnnouncementViewModel
    {
        public int ID { set; get; }
        public string Title { set; get; }

        public string Content { set; get; }

        public DateTime CreatedDate { get; set; }

        public string UserId { set; get; }

        public bool Status { get; set; }
    }
}
