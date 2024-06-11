using DiyetProgrami.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string VerificationCode { get; set; }
        public bool IsVerified { get; set; }

        // Navigation Properties
        public List<Dietitian> Dietitians { get; set; }
        public List<Admin> Admins { get; set; }

        // Image as Base64 String Format
        public byte[] Image { get; set; }
    }
}

