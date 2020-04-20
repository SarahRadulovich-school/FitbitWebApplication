using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace FitbitWebApplication.Models
{
    public abstract class WorkoutPlan
    {
        public List<Interval> Intervals { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }

    }
}
