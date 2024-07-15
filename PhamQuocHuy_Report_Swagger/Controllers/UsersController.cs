using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhamQuocHuy_Report_Swagger.Model;

namespace PhamQuocHuy_Report_Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static List<Users> users = new List<Users>
        {
            new Users { ID = 1, Name = "User A", Email = "huypham1@example.com" },
            new Users { ID = 2, Name = "User B", Email = "huypham2@example.com" },
            new Users { ID = 3, Name = "User C", Email = "huypham3@example.com" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Users>> GetUsers()
        {
            return Ok(users);
        }
        [HttpPost]
        public ActionResult<Users> PostUser([FromBody] Users user)
        {
            users.Add(user);
            return CreatedAtAction(nameof(GetUsers), new { id = user.ID }, user);
        }
        [HttpPut("{id}")]
        public IActionResult PutUser(int id, [FromBody] Users user)
        {
            var existingUser = users.FirstOrDefault(u => u.ID == id);
            if (existingUser == null)
            {
                return NotFound();
            }

            existingUser.Name = user.Name;
            existingUser.Email = user.Email;

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.ID == id);
            if (user == null)
            {
                return NotFound();
            }

            users.Remove(user);
            return NoContent();
        }
    }
}
