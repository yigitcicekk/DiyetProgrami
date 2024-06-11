using DiyetProgrami.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.Models
{
    public class MealLogViewModel
    {
        public Guid Id { get; set; }
        public Guid DietPlanId { get; set; }
        public DateTime Date { get; set; }
        public string MealType { get; set; } // Örneğin, kahvaltı, öğle yemeği, akşam yemeği
        public string Description { get; set; }
        public float Calories { get; set; }
        public float Carbohydrates { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }

        // Navigation Property
        public DietPlanViewModel DietPlan { get; set; }
    }
}
