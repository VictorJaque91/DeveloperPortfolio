using Portfolio.Models;
using System.Reflection.Metadata.Ecma335;

namespace Portfolio.Services
{
    public class ProjectService
    {
        public List<Project> GetProjects()
        {
            return new List<Project>
        {
            new Project
            {
                Title = "My Portfolio",
                Description = "The site you're looking at right now! Built from scratch with ASP.NET Core and Razor Pages to showcase my journey and projects as a .NET developer.\",",
                Technologies = new List<string>
                {
                    "ASP.NET Core",
                    "C#",
                    "Web Technologies"
                },
                LiveDemoUrl = new Uri("https://victorjaque91.github.io/DeveloperPortfolio/"),
                GitHubUrl = new Uri("https://github.com/VictorJaque91/DeveloperPortfolio")
            },
            new Project
            {
                Title = "My future project",
                Description = "Here will my next project be showcased",
                Technologies = new List<string>
                {
                    "C#"
                }
            },
            new Project
            {
                Title = "My future project",
                Description = "Here will another project be showcased",
                Technologies = new List<string>
                {
                    "ASP.NET Core",
                    "C#"
                }
            },
            new Project
            {
                Title = "My future project",
                Description = "Here will another project be showcased",
                Technologies = new List<string>
                {
                    "ASP.NET Core",
                    "C#"
                }
            },
            new Project
            {
                Title = "My future project",
                Description = "Here will another project be showcased",
                Technologies = new List<string>
                {
                    "ASP.NET Core",
                    "C#"
                }
            }
        };
        }
    }
}