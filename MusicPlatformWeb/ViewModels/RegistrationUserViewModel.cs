using System.ComponentModel.DataAnnotations;
namespace MusicPlatform.ViewModels
{
    public class RegistrationUserViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public DateOnly? Birthday { get; set; }
    } 
}
