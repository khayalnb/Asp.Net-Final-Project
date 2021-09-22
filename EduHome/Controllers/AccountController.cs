using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public AccountController(UserManager<AppUser> userManager )
        {
            this.userManager = userManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid) return View(register);

            AppUser user = new AppUser
            {
                UserName = register.UserName,
                FullName = register.FullName,
                Email = register.Email
            };

            IdentityResult result = await userManager.CreateAsync(user, register.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
            return RedirectToAction("Index", "Home");
        }


        public IActionResult Login()
        {
            return View();
        }




    }
}
