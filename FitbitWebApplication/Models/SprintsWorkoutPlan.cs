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

            Intervals = new List<Interval>();

            Intervals.Add(new Interval(3, "Warm-up walk", 300));

            for (int i = 0; i < 10; i++)
            {
                Intervals.Add(new Interval(10, "Sprint as fast as you can!", 30));
                Intervals.Add(new Interval(2, "Recovery walk", 60));
            }

            Intervals.Add(new Interval(2, "Cool-down walk", 300));
        }
    }
}
