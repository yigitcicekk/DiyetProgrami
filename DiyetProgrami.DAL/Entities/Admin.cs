using DiyetProgrami.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL.Entities
{
    public class Admin : BaseEntity
    {
        public Guid UserId { get; set; }

        // Navigation Property
        public User User { get; set; }
    }
}
