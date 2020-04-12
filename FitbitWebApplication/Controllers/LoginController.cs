using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitbitWebApplication.Models;

namespace FitbitWebApplication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginForm(UserProfile user)
        {
            //todo: validation
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Index", "Home", user);
        }
    }
}