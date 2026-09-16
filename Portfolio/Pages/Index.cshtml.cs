using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        public String Name { get; set; } = "Victor Jaque";
        public String Role { get; set; } = "System Developer .NET";

        public List<Project> Projects { get; set; } = new();

        public void OnGet()
        {
            Projects.Add(new Project
            {
                Title = "My Portfolio",
                Description = "My first ASP.NET Core project",
                Technologies = "ASP.NET Core & C#"
            });

            Projects.Add(new Project
            {
                Title = "My future project",
                Description = "Here will my next project be showcased",
                Technologies = "C#"
            });
            Projects.Add(new Project
            {
                Title = "My future project",
                Description = "Here will another project be showcased",
                Technologies = "ASP.NET Core"
            }); Projects.Add(new Project
            {
                Title = "My future project",
                Description = "Here will another project be showcased",
                Technologies = "ASP.NET Core"
            }); Projects.Add(new Project
            {
                Title = "My future project",
                Description = "Here will another project be showcased",
                Technologies = "ASP.NET Core"
            });
        }
    }
}
