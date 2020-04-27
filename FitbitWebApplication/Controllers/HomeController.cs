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
            User = UserProfile.Instance;
        }

        public IActionResult Index()
        {
            ViewBag.Username = User.Name;
            return View();
        }

        public IActionResult ToWorkout()
        {
            return RedirectToAction("Index", "Workout");
        }

        public IActionResult History()
        {
            Repository.GetWorkoutHistory();
            List<Workout> workoutHistory = User.History;
            if (workoutHistory != null)
            {
                ViewBag.History = workoutHistory;
            }

            ViewBag.Username = User.Name;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
