using System.ComponentModel.DataAnnotations;
using TaskManagement.Backend.Enums;
using TaskManagement.Backend.Helpers;

namespace TaskManagement.Backend.Models
{
    public class TaskM
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Title es required")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
        public string Title { get; set; }

        [StringLength(800, ErrorMessage = "Description cannot be longer than 800 characters")]
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }

        [DateGreaterThan("CreateAt")]
        public DateTime DeadLine { get; set; }
        public Status Status { get; set; }

        public Assignment Assignment { get; set; }
    }
}
