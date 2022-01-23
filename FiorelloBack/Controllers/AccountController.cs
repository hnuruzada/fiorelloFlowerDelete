using FiorelloBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloBack.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterVM register)
        {
            if(!ModelState.IsValid) return View();
            return View(register);
        }
    }
}
