using BLL.DTOs;
using BLL.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Registration(UserDTO user)
        {
            try
            {
                _userService.Registration(user);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }

        }
    }
}
