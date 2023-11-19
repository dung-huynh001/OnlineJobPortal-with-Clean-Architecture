namespace OnlineJobPortal.Presentation.Models
{
    public class MessageViewModel
    {
        public string UserId { get; set; }
        public int ConversationId { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
