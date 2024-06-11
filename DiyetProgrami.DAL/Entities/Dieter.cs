using DiyetProgrami.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL.Entities
{
    public class Dieter : BaseEntity
    {
        public Guid DietitianId { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        // Navigation Property

        public User User { get; set; }
        public Dietitian Dietitian { get; set; }
        public List<DietPlan> DietPlans { get; set; }
    }
}
