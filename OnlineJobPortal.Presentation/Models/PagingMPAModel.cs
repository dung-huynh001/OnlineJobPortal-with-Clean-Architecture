namespace OnlineJobPortal.Presentation.Models
{
    public class PagingMPAModel
    {
        public int currentPage { get; set; }
        public int countPages { get; set; }
        public Func<int?, string> generateUrl { get; set; }
    }
}
