using DiyetProgrami.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL.Entities
{
    public class DietPlan : BaseEntity
    {
        public Guid DieterId { get; set; }
        public Guid DietitianId { get; set; }
        public string PlanName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation Properties
        public Dietitian Dietitian { get; set; }
        public Dieter Dieter { get; set; }
        public MealLog MealLog { get; set; }
        public ExerciseLog ExerciseLog { get; set; }
    }
}
