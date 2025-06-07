namespace api.Models
{
    public class Story
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
    }
}

