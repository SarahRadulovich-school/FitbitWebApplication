using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FitbitWebApplication.Models;

namespace FitbitWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public UserProfile User { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            User = new UserProfile();
        }

        public IActionResult Index(UserProfile user)
        {
            User.Name = user.Name;
            return View(User);
        }

        public IActionResult Workout()
        {
            return View();
        }

        public IActionResult FitnessPlan()
        {
            ViewBag.Username = User.Name;
            return View();
        }

        public IActionResult SelectIntervalWorkout()
        {
            //User.CurrentPlan = new IntervalWorkoutPlan();
            return RedirectToAction("Index", User);
        }
        public IActionResult SelectSprintWorkout()
        {
            //User.CurrentPlan = new SprintWorkoutPlan();
            return RedirectToAction("Index", User);
        }
        public IActionResult SelectCardioWorkout()
        {
            //User.CurrentPlan = new CardioWorkoutPlan();
            return RedirectToAction("Index", User);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
