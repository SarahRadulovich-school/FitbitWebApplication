using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitbitWebApplication.Models
{
	public class UserProfile
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }

        [NotMapped]
        public WorkoutPlan CurrentPlan { get; set; }
        //public WorkoutHistory History { get; set; }

        private static UserProfile _instance = null;
        public static UserProfile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserProfile();
                }
                return _instance;
            }
        }

        public UserProfile()
        {

        }

        public UserProfile(string name, DateTime birthday, string gender)
        {
            Name = name;
            Birthday = birthday;
            Gender = gender;
        }

        public void ChangePlan(WorkoutPlan newPlan)
        {
            //CurrentPlan = newPlan;
        }

        public void LinkToFitbit()
        {
            //TODO: figure out requirements to link to fitbit account
        }
		
	}
}
