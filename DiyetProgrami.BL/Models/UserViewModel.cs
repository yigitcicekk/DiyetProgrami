using DiyetProgrami.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.Models
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string VerificationCode { get; set; }
        public bool IsVerified { get; set; }

        // Navigation Properties
        public List<DieterViewModel> Dieters { get; set; }
        public List<DietitianViewModel> Dietitians { get; set; }
        public List<AdminViewModel> Admins { get; set; }

        public byte[] Image { get; set; }
    }
}
