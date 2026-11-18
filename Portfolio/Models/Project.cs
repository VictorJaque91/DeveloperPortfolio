using System.Text.RegularExpressions;

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
        public string? PreviewUrl { get; set; }

        // Optional light-theme variants. When set, the cards swap to these on the
        // light theme (handled in the partials via the .theme-img CSS rules).
        public string? ImageUrlLight { get; set; }
        public string? PreviewUrlLight { get; set; }

        // Longer text for the "Read more" dialog on the Projects page
        public string Details { get; set; } = "";
        public List<string> Highlights { get; set; } = new();

        // Only projects with something extra to say get a "Read more" button
        public bool HasMoreInfo => !string.IsNullOrWhiteSpace(Details) || Highlights.Count > 0;

        // Id-friendly version of the title, e.g. "SE*Bekiles Cattery" -> "se-bekiles-cattery".
        // Gives each project's dialog a unique id in the HTML.
        public string Slug => Regex.Replace(Title.ToLowerInvariant(), "[^a-z0-9]+", "-").Trim('-');
    }
}
