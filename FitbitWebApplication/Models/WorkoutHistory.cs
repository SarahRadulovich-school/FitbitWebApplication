using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitbitWebApplication.Models
{
    public class WorkoutHistory
    {
        public List<Workout> History { get; set; }
        public UserProfile User { get; set; }

        public WorkoutHistory()
        {
            User = UserProfile.Instance;
        }

        public void populateHistory()
        {
            //collect all the Workouts from the db that are for this user
        }

    }
}
