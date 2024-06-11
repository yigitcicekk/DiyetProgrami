using DiyetProgrami.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL.Entities
{
    public class ExerciseLog : BaseEntity
    {
        public Guid? DietPlanId { get; set; }
        public DateTime Date { get; set; }
        public string ExerciseType { get; set; }
        public float Duration { get; set; } // Süre (dakika olarak)
        public float CaloriesBurned { get; set; }

        // Navigation Property
        public List<DietPlan>? DietPlan { get; set; }
    }
}
