using System.ComponentModel.DataAnnotations;

namespace TODO_list.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(12)]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
