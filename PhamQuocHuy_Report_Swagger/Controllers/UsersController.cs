using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhamQuocHuy_Report_Swagger.Model;

namespace PhamQuocHuy_Report_Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Users>> GetUsers()
        {
            var users = new List<Users>
            {
                new Users { ID = 1, Name = "User A", Email = "huypham1@example.com" },
                new Users { ID = 2, Name = "User B", Email = "huypham2@example.com" },
                new Users { ID = 3, Name = "User C", Email = "huypham3@example.com" }
            };

            return Ok(users);
        }
    }
}
