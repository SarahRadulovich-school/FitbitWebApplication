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

        public static bool AddUser()
        {
            UserProfile user = UserProfile.Instance;

            _database.Users.Add(user);
            _database.SaveChanges();
            return true;
        }

        public static UserProfile GetUser(string name)
        {
            var duplicate = _database.Users.FirstOrDefault(u => u.Name.Equals(name));

            return duplicate;
        }

        public static void AddWorkout(string workoutType, DateTime date, bool completed)
        {
            var user = UserProfile.Instance;
            var person = _database.Users.Where(u => u.Name == user.Name).FirstOrDefault();
            //TODO: TimeStarted and TimeCompleted
            var workout = new Workout();
            workout.User = person;
            workout.WorkoutType = workoutType;
            workout.Date = date;
            workout.isCompleted = completed;
            _database.Workouts.Add(workout);
            _database.SaveChanges();

            GetWorkoutHistory();
        }

        public static void AssignBirthdayToUser()
        {
            //TODO
        }

        public static void AssignGenderToUser()
        {
            //TODO
        }

        public static void GetWorkoutHistory()
        {
            var user = UserProfile.Instance;
            var person = _database.Users.Where(u => u.Name == user.Name).FirstOrDefault();
            List<Workout> list = _database.Workouts.Include(w => w.User).Where(w => w.User.Id == person.Id).ToList();

            user.History = list;
        }

        public static string GetPassword(UserProfile username)
        {
            var pass = _database.Users.Where(u => u.Name == username.Name).FirstOrDefault().Password;
            return pass;
        }
    }
}
