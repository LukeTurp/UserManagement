using System.ComponentModel.DataAnnotations;

namespace participate_registration.Models.DTOs
{
    public class InsertUser
    {
        public int UserId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Username must be at least 2 characters.")]
        [MaxLength(256, ErrorMessage = "Username must not exceed 256 characters.")]
        [RegularExpression(@"^[a-zA-Z][\w]*$", ErrorMessage = "Only alphanumeric and underscore characters allowed.")]
        public string UserName { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Password must be longer than 5 characters.")]
        [MaxLength(256, ErrorMessage = "Password must not exceed 256 characters.")]
        public string Password { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Not a valid email address.")]
        public string Email { get; set; }
    }
}
