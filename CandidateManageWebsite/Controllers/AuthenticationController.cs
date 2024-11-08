using Microsoft.AspNetCore.Mvc;

namespace CandidateManageWebsite.Controllers
{
    [Route("api/authetication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("logout")]
        public IActionResult ClearSession()
        {
            HttpContext.Session.Clear();
            return new JsonResult(new { success = true, message = "Logout Successful" });
        }
    }
}
