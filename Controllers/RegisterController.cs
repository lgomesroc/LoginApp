using Microsoft.AspNetCore.Mvc;

namespace loginapp.Controllers
{
    [Route("Register")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRegisterPage()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "Register.html");
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }
            return PhysicalFile(filePath, "text/html");
        }
    }
}
