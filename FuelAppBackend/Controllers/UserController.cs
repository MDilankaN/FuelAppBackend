using FuelAppBackend.Models;
using FuelAppBackend.Services;
using Microsoft.AspNetCore.Mvc;
using static System.Collections.Specialized.BitVector32;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FuelAppBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return _userService.GetUsers();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(String id)
        {
            var user = _userService.GetUserByID(id);
            if (user == null)
            {
                return NotFound($"User with UserID = {id} not found");
            }
            return user;
        }

        // GET api/<UserController>/5
        [Route("[action]/{username}")]
        [HttpGet]
        public ActionResult<User> GetUserByName(String username)
        {
            var user = _userService.GetUserByName(username);
            if (user == null)
            {
                return NotFound($"User with UserName = {username} not found");
            }
            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            _userService.CreateUser(user);
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] User user)
        {
            var exsistingUser = _userService.GetUserByID(id);
            if (exsistingUser == null)
            {
                return NotFound($"User with ID = {id} not found");
            }
            _userService.UpdateUser(id, user);
            return Ok($"User with User = {id} Updated");
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var exsistingUser = _userService.GetUserByID(id);
            if (exsistingUser == null)
            {
                return NotFound($"User with userID = {id} not found");
            }
            _userService.RemoveUser(id);
            return Ok($"User with UserID = {id} deleted");
        }
    }
}
