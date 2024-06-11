using DiyetProgrami.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL.Context
{
    public class DiyetProgramiDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Dieter> Dieters { get; set; }
        public DbSet<Dietitian> Dietitians { get; set; }
        public DbSet<DietPlan> DietPlans { get; set; }
        public DbSet<ExerciseLog> ExerciseLogs { get; set; }
        public DbSet<MealLog> MealLogs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer("server=DESKTOP-TK8QI16\\SQLEXPRESS;database=DiyetProgramiDb;uid=sa;pwd=123;trustservercertificate=true");

    }
}
