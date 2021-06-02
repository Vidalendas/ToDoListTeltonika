using System.ComponentModel.DataAnnotations;

namespace ToDoListTeltonika.Dtos
{
    public class UserAuthorizationDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
