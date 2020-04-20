using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace FitbitWebApplication.Models
{
    public class CardioWorkoutPlan : WorkoutPlan
    {

        public CardioWorkoutPlan()
        {
            base.Name = "Cardio";
            base.IsCompleted = false;

            //create the workout
            Intervals = new List<Interval>();
            Intervals.Add(new Interval(2, "Warm-up walk", 5));
            Intervals.Add(new Interval(4, "Speed walk", 5));
            Intervals.Add(new Interval(5, "Comfortable but challenging jog", 30));
            Intervals.Add(new Interval(4, "Speed walk", 5));
            Intervals.Add(new Interval(2, "Cool-down walk", 5));
        }
    }
}
