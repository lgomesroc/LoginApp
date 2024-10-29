using Microsoft.AspNetCore.Mvc;

namespace loginapp.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        [HttpGet("")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost("Authenticate")]
        public IActionResult Authenticate(string username, string password)
        {
            // Lógica de autenticação
            if (IsValidUser(username, password))
            {
                // Redireciona para a página inicial após autenticação bem-sucedida
                return RedirectToAction("Index", "Home");
            }

            // Se a autenticação falhar, você pode retornar uma mensagem de erro
            ViewBag.ErrorMessage = "Usuário ou senha inválidos.";
            return View("Login");
        }

        [HttpGet("Recover")]
        public IActionResult RedirectToRecover()
        {
            return RedirectToAction("Recover", "Recover");
        }

        private bool IsValidUser(string username, string password)
        {
            // Lógica de validação de usuário
            return username == "admin" && password == "password";
        }
    }
}
