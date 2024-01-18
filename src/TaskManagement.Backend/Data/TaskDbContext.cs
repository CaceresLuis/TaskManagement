using Microsoft.EntityFrameworkCore;
using TaskManagement.Backend.Models;

namespace TaskManagement.Backend.Data
{
    public class TaskDbContext(DbContextOptions<TaskDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<TaskM> Tasks { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
    }
}
