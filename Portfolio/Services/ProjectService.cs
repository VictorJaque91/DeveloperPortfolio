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
                Description = "The site you're looking at right now! Built from scratch with ASP.NET Core and Razor Pages to showcase my journey and projects as a .NET developer.",
                Technologies = new List<string>
                {
                    "ASP.NET Core",
                    "C#",
                    "Web Technologies"
                },
                LiveDemoUrl = new Uri("https://victorjaque91.github.io/DeveloperPortfolio/"),
                GitHubUrl = new Uri("https://github.com/VictorJaque91/DeveloperPortfolio"),
                ImageUrl = "/images/vj-logo.png",
                PreviewUrl = "/images/portfolio-preview.png"
            },
            new Project
            {
                Title = "Library",
                Description = "A simple library management system built with C# and .NET which was developed in school. My first application that I will use WPF",
                Technologies = new List<string>
                {
                    "C#",
                    ".NET",
                    "WPF"
                },
                GitHubUrl = new Uri("https://github.com/VictorJaque91/Library")
            },
            new Project
            {
                Title = "Quiz Mobile Game",
                Description = "I am currently working on a mobile game using Unity and C# alongside my studies. The plan is to develop new features depending on where I am in my studies",
                Technologies = new List<string>
                {
                    "Unity",
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