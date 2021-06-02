using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoListTeltonika.Data;
using ToDoListTeltonika.Dtos;

namespace ToDoListTeltonika.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : Controller
    {

        private readonly IUsersRepo _repository;
        private readonly IJwtAuthenticationManager jwtAuthenticationManager;

        public NameController(IUsersRepo repository, IMapper mapper, IJwtAuthenticationManager jwtAuthenticationManager)
        {
            _repository = repository;
            this.jwtAuthenticationManager = jwtAuthenticationManager;
        }

        [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody] UserCred userCred)
        {
            if(_repository.GetUserCredByEmail(userCred.Email, userCred.Password))
            {
                var token = jwtAuthenticationManager.Authenticate(userCred.Email, userCred.Password);
                return Ok(token);
                
            }
            else return Unauthorized();
        }
     //GET: api/Name
     [HttpGet]
     public IEnumerable<string> Get()
        {
            return new string[] { " " };
        }
       
    }
}
