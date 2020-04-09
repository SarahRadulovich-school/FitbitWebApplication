using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;    //!!
using FitbitWebApplication.Models;

namespace FitbitWebApplication
{
    class FitnessDbContext : DbContext
    {
        //classes that need to be saved in the database
        public DbSet<UserProfile> Profile { get; set; }
        //WorkoutHistory Table
        //HeartRate table


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //change database name, server name or any other credentials needed for storing locally
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FitnessDatabase;Data Source=SARAHS-BABY\SQLEXPRESS");
        }
    }
}
