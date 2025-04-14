using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace myGITAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginAPIController : ControllerBase
    {

        [HttpGet("UserList")]
        public async Task<IActionResult> GetUserList()
        {
            List<string> userList = new List<string>
            {
                "user1",
                "user2",
                "user3"
            };
           

            var response = new
            {
                success = true,
                message = "User list fetched successfully.",
                data = userList
            };

            return Ok(response);
        }
    }
}
