using Microsoft.AspNetCore.Mvc;

namespace loginapp.Controllers
{
    [Route("Login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetLoginPage()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "Login.html");
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }
            return PhysicalFile(filePath, "text/html");
        }
    }
}
