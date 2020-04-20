using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitbitWebApplication.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public UserProfile User { get; set; }

        public DateTime Date { get; set; }
        public string WorkoutType { get; set; }
        public bool isCompleted { get; set; }
    }
}
