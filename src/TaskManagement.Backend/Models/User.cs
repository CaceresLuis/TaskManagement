using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Backend.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name es required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email es required")]
        [StringLength(100, ErrorMessage = "Email cannot be longer than 100 characters")]
        [EmailAddress(ErrorMessage = "this field must be in email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password es required")]
        [StringLength(25, ErrorMessage = "Password cannot be longer than 25 characters")]
        [PasswordPropertyText]
        public string Password { get; set; }
        public Role Role { get; set; }

        public Assignment Assignment { get; set; }
    }
}
