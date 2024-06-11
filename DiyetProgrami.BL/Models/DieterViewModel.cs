using DiyetProgrami.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.Models
{
    public class DieterViewModel
    {
        public Guid Id { get; set; }  
        public Guid DietitianId { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        // Navigation Property

        public UserViewModel User { get; set; }
        public DietitianViewModel Dietitian { get; set; }
        public List<DietPlanViewModel> DietPlans { get; set; }
    }
}
