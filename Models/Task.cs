using System.ComponentModel.DataAnnotations;

namespace TODO_list.Models
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string TaskDescription { get; set; }
        [Required]
        public string State { get; set; }
    }
}
