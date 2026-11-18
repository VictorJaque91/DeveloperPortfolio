using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; set; } = new();

        // Every technology used in any project, once each, in the order they first appear.
        // Used for the filter buttons.
        public List<string> Technologies { get; set; } = new();

        private readonly ProjectService _projectService;
        public ProjectsModel(ProjectService projectService)
        {
            _projectService = projectService;
        }
        public void OnGet()
        {
            Projects = _projectService.GetProjects();
            Technologies = Projects.SelectMany(p => p.Technologies).Distinct().ToList();
        }
    }
}
