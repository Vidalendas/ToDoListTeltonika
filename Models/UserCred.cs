using System.ComponentModel.DataAnnotations;

namespace ToDoListTeltonika.Controllers
{
    public class UserCred
    {


        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}