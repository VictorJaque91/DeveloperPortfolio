using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Pages
{
    public class AboutModel : PageModel
    {
        public List<SkillCategory> SkillCategories { get; set; } = new();

        private readonly SkillService _skillService;
        public AboutModel(SkillService skillService)
        {
            _skillService = skillService;
        }

        public void OnGet()
        {
            SkillCategories = _skillService.GetSkillCategories();
        }
    }
}
