using firtsApiCSharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace firtsApiCSharp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUser() 
        {
            var user = new User()
            {
                Name = "Felipe",
                Email = "Teste@gmail.com",
                Password = "1234"
            };

            return Ok(user);
        }


    }
}
