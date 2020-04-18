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
        [HttpGet]
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

            var userProfile = UserProfile.Instance;
            userProfile.Name = user.Name;

            //Either find or create the user in the database
            Repository.AddUser(user.Name);

            return RedirectToAction("Index", "Home");
        }
    }
}