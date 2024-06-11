using DiyetProgrami.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL.Entities
{
    public class MealLog : BaseEntity
    {
        public Guid DietPlanId { get; set; }
        public DateTime Date { get; set; }
        public string MealType { get; set; } // Örneğin, kahvaltı, öğle yemeği, akşam yemeği
        public string Description { get; set; }
        public float Calories { get; set; }
        public float Carbohydrates { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }

        // Navigation Property
        public DietPlan DietPlan { get; set; }
    }
}
