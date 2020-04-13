using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitbitWebApplication.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public UserProfile User { get; set; }
        public DateTime TimeStarted { get; set; }
        public DateTime TimeEnded { get; set; }

        //public int TotalTimeInSeconds { get; set; }
        public string WorkoutType { get; set; } //for now
    }
}
