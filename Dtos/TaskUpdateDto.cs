using System.ComponentModel.DataAnnotations;


namespace TODO_list.Dtos
{
    public class TaskUpdateDto
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string TaskDescription { get; set; }
        [Required]
        public string State { get; set; }
    }
}
