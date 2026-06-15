using System.ComponentModel.DataAnnotations;

namespace BlazorProject.Models
{
    public class UserRegistration
    {
        [Required]
        public string Name { get; set; } = "";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";
    }
}