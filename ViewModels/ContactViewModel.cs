using System.ComponentModel.DataAnnotations;

namespace Treat.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Too Long")]
        public string Message { get; set; }
    }
}
