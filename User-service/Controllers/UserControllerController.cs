using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User_service.Entities;
using User_service.IService;

namespace User_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserControllerController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserControllerController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            var createdUser = await _userService.CreateUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id }, createdUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
        {
            if (id != user.Id) return BadRequest("User ID mismatch");

            var updatedUser = await _userService.UpdateUser(user);
            return Ok(updatedUser);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result = await _userService.DeleteUser(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
