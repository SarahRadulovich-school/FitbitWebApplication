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
        private UserProfile _user;
        private FitnessDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _dbContext = new FitnessDbContext();
            _user = new UserProfile();
        }

        public IActionResult Index(string userName)
        {
            return View(userName);
        }

        public IActionResult Workout()
        {
            return View();
        }

        public IActionResult FitnessPlan()
        {
            return View();
        }

        public IActionResult SelectWorkout()
        {
            //When the user selects their workout, they return to the home page where it says the currently selected workout
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
