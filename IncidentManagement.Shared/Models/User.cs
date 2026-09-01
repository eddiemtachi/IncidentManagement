using System.ComponentModel.DataAnnotations;

namespace IncidentManagement.Shared.Models
{
    [AtLeastOneRequired("PhoneNumber", "WhatsAppNumber", ErrorMessage = "Either Phone Number or WhatsApp Number must be supplied.")]
    public class User
    {
        [Required]
        public long UserId { get; set; }

        [Required(ErrorMessage = "Email or Username is required")]
        public string Email { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Password is required")]
        //[StringLength(20, MinimumLength = 4, ErrorMessage = "Password must be 4–20 characters")]
        public string PasswordHash { get; set; } = string.Empty;

        [Required(ErrorMessage = "Username is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 20 characters")]
        public string? Username { get; set; }        

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string? ConfirmPassword { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string? PhoneNumber { get; set; }

        [Phone(ErrorMessage = "Invalid WhatsApp number format")]
        public string? WhatsAppNumber { get; set; }

        [Required(ErrorMessage = "Role selection is required")]
        public string? Role { get; set; }

        public bool IsActive { get; set; } = true; // Soft delete flag

        public List<string> Roles { get; set; } = new List<string>();
    }
}
