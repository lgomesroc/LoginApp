using Microsoft.AspNetCore.Mvc;

namespace loginapp.Controllers
{
    [Route("Recover")]
    public class RecoverController : Controller
    {
        [HttpGet("")]
        public IActionResult Recover()
        {
            return View("Recover");
        }

        [HttpPost("")]
        public IActionResult Recover(string username, string newPassword, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                ModelState.AddModelError("", "Todos os campos são obrigatórios.");
                return View("Recover");
            }
            if (newPassword != confirmPassword)
            {
                ModelState.AddModelError("", "As senhas não coincidem.");
                return View("Recover");
            }

            // Lógica para atualizar a senha do usuário
            // Redirecionar para a página de login ou para uma página de confirmação
            return RedirectToAction("Login", "Login");
        }
    }
}
