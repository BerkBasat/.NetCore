using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Net6Identity.Models.ViewModels;

namespace Net6Identity.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> ConfirmEmail(string id, string token)
        {
            if (id != null && token != null)
            {
                var user = await _userManager.FindByIdAsync(id);
                var confirm = await _userManager.ConfirmEmailAsync(user, token);
                if (confirm.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
            }
            return View();
        }

        public IActionResult SignIn()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginVM login)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(login.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, login.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }
    }
}