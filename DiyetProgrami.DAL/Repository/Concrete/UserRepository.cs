using DiyetProgrami.DAL.Context;
using DiyetProgrami.DAL.Entities;
using DiyetProgrami.DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL.Repository.Concrete
{
    public class UserRepository : Repository<User>
    {
        private readonly DiyetProgramiDbContext _db;
        public UserRepository(DiyetProgramiDbContext db) : base(db)
        {
            _db = db;
        }

        public User GetByEmail(string email)
        {
            return _db.Users.AsNoTracking().FirstOrDefault(u => u.Email == email);
        }
    }
}
