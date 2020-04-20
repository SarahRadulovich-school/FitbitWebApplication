using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;    //!!
using FitbitWebApplication.Models;

namespace FitbitWebApplication
{
    class FitnessDbContext : DbContext
    {
        public DbSet<UserProfile> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }    


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //change database name, server name or any other credentials needed for storing locally
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FitnessDatabase;Data Source=SARAHS-BABY\SQLEXPRESS");
        }
    }
}
