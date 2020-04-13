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

            string userName = user.Name;

            //Either find or create the user in the database
            Repository.AddUser(userName);


            return RedirectToAction("Index", "Home", userName);
        }
    }
}