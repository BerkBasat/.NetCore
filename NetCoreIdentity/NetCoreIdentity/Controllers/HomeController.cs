using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCoreIdentity.Models.Entity;
using NetCoreIdentity.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIdentity.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(UserManager<AppUser> usermanager,SignInManager<AppUser> signInManager)
        {
            _usermanager = usermanager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser();
                user.UserName = registerVM.Username;
                user.Email = registerVM.Email;

              var result=await  _usermanager.CreateAsync(user, registerVM.Password);
                if (result.Succeeded)
                {
                    return View();
                }
                else
                {
                    return View();
                }


            }
            else
            {
                return View();
            }
            
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var user =await _usermanager.FindByEmailAsync(loginVM.Email);
                if (user != null)
                {
                    var result = _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("errLogin", "hatalı giriş");
                    }
                }
                return View();
            }
            else
            {
                return View();
            }
            
        }
    }
}
