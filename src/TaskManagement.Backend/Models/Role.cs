using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Backend.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; } 

        [Required(ErrorMessage = "Name required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }
        public bool Create { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public bool Read { get; set; }
    }
}
