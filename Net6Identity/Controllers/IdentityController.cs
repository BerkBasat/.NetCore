using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Net6Identity.Models.ViewModels;

namespace Net6Identity.Controllers
{
    public class IdentityController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public IdentityController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVm registerUser)
        {
            if (ModelState.IsValid)
            {
                IdentityUser newUser = new IdentityUser() { UserName = registerUser.Username, Email = registerUser.Email };

                var result = await _userManager.CreateAsync(newUser, registerUser.Password);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(registerUser.Email);
                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                    return RedirectToAction("ConfirmEmail", "Account", new { id = user.Id, token = token });
                }
                else
                {
                    return View();
                }

            }
            return View();
        }
    }
}