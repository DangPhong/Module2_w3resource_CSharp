using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CF_ABCCenter.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CF_ABCCenter.Controllers
{
    public class AccountController : Controller
    {
        public AccountController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> signInManager)
        {

        }
        public IActionResult Login()
        {
            return View();
        }
    }
}