using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitbitWebApplication.Models
{
    public abstract class WorkoutPlan
    {
        public List<Interval> Intervals { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }   

        public void StartWorkout() { }
        public void StartInterval() { }
        public void EndWorkout() { }
    }
}
