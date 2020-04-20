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
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            var userProfile = UserProfile.Instance;
            userProfile.Name = user.Name;
            userProfile.Password = user.Password;

            //Either find or create the user in the database
            var userAdded = Repository.AddUser();

            if (!userAdded && (Repository.GetPassword(user) != user.Password))
            {
                return View("Index");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}