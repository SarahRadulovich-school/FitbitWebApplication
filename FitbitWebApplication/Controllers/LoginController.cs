using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitbitWebApplication.Models;
using System.Web.Helpers;

namespace FitbitWebApplication.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult SignUpForm(UserProfile user)
        {
            //no duplicate usernames allowed
            if (Repository.GetUser(user.Name) != null)
            {
                return RedirectToAction("ErrorUserAlreadyExists");
            }

            var userProfile = UserProfile.Instance;
            userProfile.Name = user.Name;

            //generate salted and hashed password (using RFC 2898)
            userProfile.Salt = Crypto.GenerateSalt();
            userProfile.Password = Crypto.HashPassword(userProfile.Salt + user.Password);

            //create the user in the database
            var userAdded = Repository.AddUser();

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult LoginForm(UserProfile user)
        {

            var userFromDb = Repository.GetUser(user.Name);

            //check if user exists
            if (userFromDb == null)
            {
                return RedirectToAction("ErrorUserDoesNotExist");
            }

            //user exists, now compare the passwords
            var verified = Crypto.VerifyHashedPassword(userFromDb.Password, (userFromDb.Salt + user.Password));

            if (!verified)
            {
                return RedirectToAction("ErrorPasswordIncorrect");
            }

            UserProfile.SetInstance(userFromDb);

            return RedirectToAction("Index", "Home");

        }

        public IActionResult ErrorInvalidInputSignUp()
        {
            ViewBag.Error = "InvalidInput";
            return View("SignUp");
        }

        public IActionResult ErrorUserAlreadyExists()
        {
            ViewBag.Error = "UserAlreadyExists";
            return View("SignUp");
        }

        public IActionResult ErrorInvalidInputLogin()
        {
            ViewBag.Error = "InvalidInput";
            return View("Index");
        }

        public IActionResult ErrorUserDoesNotExist()
        {
            ViewBag.Error = "UserDoesNotExist";
            return View("Index");
        }

        public IActionResult ErrorPasswordIncorrect()
        {
            ViewBag.Error = "PasswordIncorrect";
            return View("Index");
        }
    }
}