using Microsoft.AspNetCore.Mvc;

namespace loginapp.Controllers
{
    [Route("Register")]
    public class RegisterController : Controller
    {
        [HttpGet("")]
        public IActionResult GetRegisterPage()
        {
            return View("Register");
        }

        [HttpPost("Create")]
        public IActionResult Create(string nome, string username, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                ModelState.AddModelError("", "Todos os campos são obrigatórios.");
                return View("Register");
            }
            if (password != confirmPassword)
            {
                ModelState.AddModelError("", "As senhas não coincidem.");
                return View("Register");
            }

            // Adicione aqui a lógica para criar o usuário
            // Exemplo: salvar no banco de dados

            // Redirecionar para a página de login após a criação da conta
            return RedirectToAction("Login", "Login");
        }
    }
}
