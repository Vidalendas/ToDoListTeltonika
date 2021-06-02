using Microsoft.EntityFrameworkCore;
using TODO_list.Models;

namespace TODO_list.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> opt) : base(opt)
        {
            
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        
    }
}
