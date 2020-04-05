using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitbitWebApplication.Models
{
    public class FitnessGoalResults
    {
        public FitnessGoal FitnessGoal { get; set; }
        public TimeCommitment TimeCommitment { get; set; }

        public WorkoutPlan CalculatePlan()
        {
            switch(FitnessGoal)
            {
                case FitnessGoal.WeightLoss:
                    return new CardioWorkoutPlan();
                case FitnessGoal.Endurance:
                    return new IntervalWorkoutPlan();
                case FitnessGoal.Strength:
                    return new SprintsWorkoutPlan();
                default:
                    return new SprintsWorkoutPlan();
            }
        }
    }
}
