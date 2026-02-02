namespace PawConnect.Models
{
    public class Post
    {
        public int Id { get; set; }

        // Who posted it (Sprint 1: store display info only)
        public string AuthorName { get; set; } = string.Empty;
        public string AuthorHandle { get; set; } = string.Empty;   // e.g. @mayur

        // Post content
        public string Content { get; set; } = string.Empty;

        // For feed ordering
        public DateTime CreatedAt { get; set; }
    }
}
