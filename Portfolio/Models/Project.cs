namespace Portfolio.Models
{
    public class Project
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string> Technologies { get; set; } = new();
        public Uri? LiveDemoUrl { get; set; }
        public Uri? GitHubUrl { get; set; }
        public string? ImageUrl { get; set; }
    }
}
