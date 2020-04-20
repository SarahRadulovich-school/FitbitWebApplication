using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitbitWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitbitWebApplication.Controllers
{
    public class WorkoutController : Controller
    {
        public UserProfile User { get; set; }

        //page to select a workout 
        public IActionResult Index()
        {
            User = UserProfile.Instance;

            ViewBag.Username = User.Name;

            return View();
        }

        [HttpPost]
        public IActionResult SelectWorkout(string workoutType)
        {

            if (User == null)
            {
                User = UserProfile.Instance;
            }

            ViewBag.Username = User.Name;

            switch (workoutType)
            {
                case "sprint":
                    User.CurrentPlan = new SprintsWorkoutPlan();
                    break;
                case "interval":
                    User.CurrentPlan = new IntervalWorkoutPlan();
                    break;
                case "cardio":
                    User.CurrentPlan = new CardioWorkoutPlan();
                    break;
                default:
                    User.CurrentPlan = new IntervalWorkoutPlan();
                    break;
            }
            return RedirectToAction("Workout");
        }

        public IActionResult Workout()
        {
            if (User == null)
            {
                User = UserProfile.Instance;
            }

            if (User.CurrentPlan == null)
            {
                User.CurrentPlan = new CardioWorkoutPlan();
            }

            var list = User.CurrentPlan.Intervals;
            var name = User.CurrentPlan.Name;

            ViewBag.Username = User.Name;
            ViewBag.TimerList = list;
            ViewBag.WorkoutName = name;

            return View(list);
        }
    }
}