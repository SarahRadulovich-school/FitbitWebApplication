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

            Intervals = new List<Interval>();

            Intervals.Add(new Interval(3, "Warm-up walk", 300));

            for (int i = 0; i < 5; i++)
            {
                Intervals.Add(new Interval(5, "Moderate jog", 60));
                Intervals.Add(new Interval(8, "Fast jog or run", 120));
                Intervals.Add(new Interval(5, "Moderate jog", 60));
            }

            Intervals.Add(new Interval(2, "Cool-down walk", 300));
        }
    }
}
