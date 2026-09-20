using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; set; } = new();

        private readonly ProjectService _projectService;
        public ProjectsModel(ProjectService projectService)
        {
            _projectService = projectService;
        }
        public void OnGet()
        {
            Projects = _projectService.GetProjects();
        }
    }
}
