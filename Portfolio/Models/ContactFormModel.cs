using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(100)]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Please enter a message.")]
        [StringLength(2000)]
        public string Message { get; set; } = "";
    }
}