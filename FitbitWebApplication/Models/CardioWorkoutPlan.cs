using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitbitWebApplication.Models
{
    public class CardioWorkoutPlan : WorkoutPlan
    {

        public CardioWorkoutPlan()
        {
            base.Name = "Cardio";
            base.IsCompleted = false;
        }
    }
}
