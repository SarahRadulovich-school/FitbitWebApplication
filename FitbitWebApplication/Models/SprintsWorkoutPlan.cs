using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace FitbitWebApplication.Models
{
    public class SprintsWorkoutPlan : WorkoutPlan
    {
        public SprintsWorkoutPlan()
        {
            base.Name = "Sprints";
            base.IsCompleted = false;
        }
    }
}
