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
            if(User.CurrentPlan == null)
            {
                ViewBag.workout = "test";
            }
            else
            {
                ViewBag.workout = User.CurrentPlan.Name;
            }

            ViewBag.Username = User.Name;
            return View();
        }

        public IActionResult Workout()
        {
            ViewBag.Username = User.Name;
            return View();
        }

        public IActionResult FitnessPlan()
        {
            ViewBag.Username = User.Name;
            return View();
        }

        public IActionResult SelectIntervalWorkout()
        {
            ViewBag.Username = User.Name;
            User.CurrentPlan = new IntervalWorkoutPlan();
            return RedirectToAction("Index", User);
        }
        public IActionResult SelectSprintWorkout()
        {
            ViewBag.Username = User.Name;
            User.CurrentPlan = new SprintsWorkoutPlan();
            return RedirectToAction("Index", User);
        }
        public IActionResult SelectCardioWorkout()
        {
            ViewBag.Username = User.Name;
            User.CurrentPlan = new CardioWorkoutPlan();
            return RedirectToAction("Index", User);
        }

        public IActionResult History()
        {
            Repository.GetWorkoutHistory();

            List<Workout> workoutHistory = User.History;
            if(workoutHistory != null)
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

        public IActionResult TimerTest()
        {
            //TODO: pass interval list to this controller method instead of creating it here
            var workoutPlan = new CardioWorkoutPlan();

            var list = workoutPlan.Intervals;
            var name = workoutPlan.Name;

            ViewBag.Username = User.Name;
            ViewBag.TimerList = list;

            return View(list);
        }
    }
}
