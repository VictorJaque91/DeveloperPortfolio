using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Pages
{
    public class ContactModel : PageModel
    {
        private readonly IEmailService _emailService;

        [BindProperty]
        public ContactFormModel Form { get; set; } = new();

        public bool WasSent { get; set; }
        public bool SendFailed { get; set; }
        public string? ErrorDetails { get; set; }

        public ContactModel(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                await _emailService.SendContactMessageAsync(Form);
                WasSent = true;
                Form = new ContactFormModel(); 
                ModelState.Clear();
            }
            catch (Exception ex)
            {
                SendFailed = true;
            }

            return Page();
        }
    }
}