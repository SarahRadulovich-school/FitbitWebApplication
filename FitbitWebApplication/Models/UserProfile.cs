using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitbitWebApplication.Models
{
	public class UserProfile
	{
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        [NotMapped]
        public WorkoutPlan CurrentPlan { get; set; }
        [NotMapped]
        public List<Workout> History { get; set; }

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

        public void LinkToFitbit()
        {
            //TODO: figure out requirements to link to fitbit account
        }
		
	}
}
