using DiyetProgrami.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.Models
{
    public class ExerciseLogViewModel
    {
        public Guid Id { get; set; }
        public Guid DietPlanId { get; set; }
        public DateTime Date { get; set; }
        public string ExerciseType { get; set; }
        public float Duration { get; set; } // Süre (dakika olarak)
        public float CaloriesBurned { get; set; }

        // Navigation Property
        public List<DietPlanViewModel> DietPlan { get; set; }
    }
}
