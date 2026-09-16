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
        public List<string> Technologies { get; set; } = new();

        public void OnGet()
        {
            Projects.Add(new Project
            {
                Title = "My Portfolio",
                Description = "My first ASP.NET Core project",
                Technologies = new List<string>
                    {
                    "ASP.NET Core",
                    "C#",
                    "Web Technologies"
                    },
                LiveDemoUrl = new Uri("https://victorjaque91.github.io/DeveloperPortfolio/"),
                GitHubUrl = new Uri("https://github.com/VictorJaque91/DeveloperPortfolio")
            });

            Projects.Add(new Project
            {
                Title = "My future project",
                Description = "Here will my next project be showcased",
                Technologies = new List<string>
                    {
                    "C#"
                    },
            });
            Projects.Add(new Project
            {
                Title = "My future project",
                Description = "Here will another project be showcased",
                Technologies = new List<string>
                    {
                    "ASP.NET Core",
                    "C#"
                    },
            }); Projects.Add(new Project
            {
                Title = "My future project",
                Description = "Here will another project be showcased",
                Technologies = new List<string>
                    {
                    "ASP.NET Core",
                    "C#"
                    },
            }); Projects.Add(new Project
            {
                Title = "My future project",
                Description = "Here will another project be showcased",
                Technologies = new List<string>
                    {
                    "ASP.NET Core",
                    "C#"
                    },
            });
        }
    }
}
