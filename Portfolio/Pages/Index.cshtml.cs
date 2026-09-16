using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        public String Name { get; set; } = "Victor Jaque";
        public String Role { get; set; } = "System Developer .NET";

        public List<Project> Projects { get; set; } = new();
        public List<string> Technologies { get; set; } = new();

        private readonly ProjectService _projectService;
        public IndexModel(ProjectService projectService)
        {
            _projectService = projectService;
        }

        public void OnGet()
        {
            Projects = _projectService.GetProjects();
        }
    }
}
