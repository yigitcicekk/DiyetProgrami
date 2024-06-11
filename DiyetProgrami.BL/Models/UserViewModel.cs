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
        public Guid? DieterId { get; set; }
        public Guid? DietitianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string VerificationCode { get; set; }
        public bool IsVerified { get; set; }

        // Navigation Properties
        public DieterViewModel Dieter { get; set; }
        public DietitianViewModel Dietitian { get; set; }

        public byte[]? Image { get; set; }
    }
}
