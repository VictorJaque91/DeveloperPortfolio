namespace Portfolio.Models
{
    public class Skill
    {
        public string Name { get; set; } = "";

        // 1-5, see SkillService.MaxLevel
        public int Level { get; set; }
    }
}
