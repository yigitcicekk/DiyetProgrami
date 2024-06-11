using DiyetProgrami.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.Models
{
    public class DietitianViewModel
    {
        public Guid Id { get; set; }    
        public string Specialization { get; set; }

        // Navigation Property

        public UserViewModel User { get; set; }
        public List<DieterViewModel> Dieters { get; set; }
        public List<DietPlanViewModel> DietPlans { get; set; }
        
    }
}
