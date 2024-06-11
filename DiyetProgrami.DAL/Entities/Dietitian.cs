using DiyetProgrami.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL.Entities
{
    public class Dietitian : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Specialization { get; set; }

        // Navigation Property

        public User User { get; set; }
        public List<Dieter> Dieters { get; set; }
        public List<DietPlan> DietPlans { get; set; }
    }
}
