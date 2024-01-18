using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Backend.Models
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; }

        public Guid TaskId { get; set; }
        public TaskM Task { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
