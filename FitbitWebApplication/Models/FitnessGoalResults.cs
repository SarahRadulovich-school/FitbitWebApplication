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

        public void CalculatePlan()
        {
        }
    }
}
