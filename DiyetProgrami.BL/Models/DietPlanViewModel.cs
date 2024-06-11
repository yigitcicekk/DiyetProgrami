using DiyetProgrami.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.Models
{
    public class DietPlanViewModel
    {
        public Guid Id { get; set; }
        public Guid DieterId { get; set; }
        public Guid DietitianId { get; set; }
        public string PlanName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation Properties
        public DietitianViewModel Dietitian { get; set; }
        public DieterViewModel Dieter { get; set; }
        public MealLogViewModel MealLog { get; set; }
        public ExerciseLogViewModel ExerciseLog { get; set; }
    }
}
