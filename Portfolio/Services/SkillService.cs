using Portfolio.Models;

namespace Portfolio.Services
{
    public class SkillService
    {
        public const int MaxLevel = 5;

        // The level is always shown as text, so the bar is never the only way to read it
        private static readonly Dictionary<int, string> LevelLabels = new()
        {
            { 1, "Beginner" },
            { 2, "Basic" },
            { 3, "Intermediate" },
            { 4, "Advanced" },
            { 5, "Expert" }
        };

        public static string GetLevelLabel(int level) =>
            LevelLabels.TryGetValue(level, out var label) ? label : "Unknown";

        public List<SkillCategory> GetSkillCategories()
        {
            return new List<SkillCategory>
            {
                new SkillCategory
                {
                    Title = "Frontend",
                    Skills = new List<Skill>
                    {
                        new Skill { Name = "HTML", Level = 4 },
                        new Skill { Name = "CSS", Level = 3 },
                        new Skill { Name = "JavaScript", Level = 2 },
                        new Skill { Name = "React", Level = 2 }
                    }
                },
                new SkillCategory
                {
                    Title = "Backend",
                    Skills = new List<Skill>
                    {
                        new Skill { Name = "C#", Level = 3 },
                        new Skill { Name = "ASP.NET Razor Pages", Level = 2 },
                        new Skill { Name = "SQL", Level = 1 }
                    }
                },
                new SkillCategory
                {
                    Title = "Tools",
                    Skills = new List<Skill>
                    {
                        new Skill { Name = "Git & GitHub", Level = 3 },
                        new Skill { Name = "Visual Studio / VS Code", Level = 3 },
                        new Skill { Name = "Linux & self-hosting", Level = 4 }
                    }
                }
            };
        }
    }
}
