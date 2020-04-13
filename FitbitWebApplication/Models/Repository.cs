using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FitbitWebApplication.Models
{
    class Repository
    {
        private static FitnessDbContext _database = new FitnessDbContext();

        public static void AddUser(string name)
        {
            //no duplicate id's allowed
            var duplicate = _database.Users.FirstOrDefault(u => u.Name.Equals(name));
            if(duplicate != null)
            {
                return;
            }

            var user = new UserProfile
            {
                Name = name
            };

            _database.Users.Add(user);
            _database.SaveChanges();
        }

        public static void AddWorkout(UserProfile user, string workoutType)
        {
            //TODO: TimeStarted and TimeCompleted
            var workout = new Workout
            {
                User = user,
                WorkoutType = workoutType
            };

            _database.Workouts.Add(workout);
            _database.SaveChanges();

        }

        public static void AssignBirthdayToUser()
        {
            //TODO
        }

        public static void AssignGenderToUser()
        {
            //TODO
        }

        public static void AssignTimeStartedToWorkout()
        {
            //TODO
        }

        public static void AssignTimeEndedToWorkout()
        {
            //TODO
        }
    }
}
