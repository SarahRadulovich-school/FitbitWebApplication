using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace FitbitWebApplication.Models
{
    public class IntervalWorkoutPlan : WorkoutPlan
    {
        public IntervalWorkoutPlan()
        {
            base.Name = "Interval";
            base.IsCompleted = false;
        }
    }
}
