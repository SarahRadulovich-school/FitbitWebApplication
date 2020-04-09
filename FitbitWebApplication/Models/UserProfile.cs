using System;
using System.Collections.Generic;
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
        public WorkoutPlan Plan { get; set; }
        public int HeartRate { get; set; }

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
            Plan = newPlan;
        }

        public void LinkToFitbit()
        {
            //TODO: figure out requirements to link to fitbit account
        }
		
	}
}
