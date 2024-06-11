using DiyetProgrami.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.Models
{
    public class AdminViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        // Navigation Property
        public UserViewModel User { get; set; }
    }
}
