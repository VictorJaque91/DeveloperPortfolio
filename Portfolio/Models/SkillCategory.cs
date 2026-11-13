namespace Portfolio.Models
{
    public class SkillCategory
    {
        public string Title { get; set; } = "";
        public List<Skill> Skills { get; set; } = new();
    }
}
