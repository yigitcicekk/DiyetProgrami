using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using DiyetProgrami.BL.CCS;
using DiyetProgrami.BL.Manager.Abstract;
using DiyetProgrami.BL.MappingProfiles;
using DiyetProgrami.BL.Models;
using DiyetProgrami.DAL.Context;
using DiyetProgrami.DAL.Entities;
using DiyetProgrami.DAL.Repository.Concrete;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace DiyetProgrami.BL.Manager.Concrete
{
    public class UserManager : Manager<UserViewModel, User, UserMappingProfile>
    {
        private readonly UserRepository _repository;
        private readonly DietitianRepository _dietitianRepository;
        private readonly DiyetProgramiDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IMailSender _mailSender;

        public UserManager(DiyetProgramiDbContext dbContext, IMailSender mailSender) : base()
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _mailSender = mailSender ?? throw new ArgumentNullException(nameof(mailSender));
            _repository = new UserRepository(dbContext);
            _dietitianRepository = new DietitianRepository(dbContext);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping().CreateMap<UserViewModel, User>().ReverseMap();
                cfg.AddProfile<UserMappingProfile>();
                cfg.AddExpressionMapping().CreateMap<DieterViewModel, Dieter>().ReverseMap();
                cfg.AddProfile<DieterMappingProfile>();
                cfg.AddExpressionMapping().CreateMap<DietitianViewModel, Dietitian>().ReverseMap();
                cfg.AddProfile<DieterMappingProfile>();
            });
            _mapper = config.CreateMapper();
        }

        public async Task<UserViewModel> Register(UserViewModel userViewModel, string password, object additionalInfo = null)
        {
            if (userViewModel == null)
            {
                throw new ArgumentNullException(nameof(userViewModel));
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password cannot be empty or whitespace.", nameof(password));
            }

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            userViewModel.PasswordHash = passwordHash;
            userViewModel.PasswordSalt = passwordSalt;
            userViewModel.VerificationCode = await _mailSender.SendEmailAsync(userViewModel, password);
            userViewModel.IsVerified = false;

            var user = _mapper.Map<User>(userViewModel);
            _repository.Insert(user);
            await _dbContext.SaveChangesAsync();

            if (additionalInfo != null)
            {
                if (additionalInfo is DieterViewModel dieterViewModel)
                {
                    var dieter = _mapper.Map<Dieter>(dieterViewModel);
                    dieter.DietitianId = _dietitianRepository.GetAll().FirstOrDefault().Id;
                    _dbContext.Dieters.Add(dieter);
                    await _dbContext.SaveChangesAsync();
                }
                else if (additionalInfo is DietitianViewModel dietitianViewModel)
                {
                    var dietitian = _mapper.Map<Dietitian>(dietitianViewModel);
                    dietitian.User.Id = user.Id;
                    _dbContext.Dietitians.Add(dietitian);
                    await _dbContext.SaveChangesAsync();
                }
            }

            return _mapper.Map<UserViewModel>(user);
        }

        public bool VerifyUser(string email, string verificationCode)
        {
            var user = _repository.GetByEmail(email);
            if (user == null || user.VerificationCode != verificationCode)
            {
                return false;
            }
            user.IsVerified = true;
            _repository.Update(user);
            _dbContext.SaveChanges();

            return true;
        }

        public UserViewModel Login(string email, string password)
        {
            var user = _repository.GetByEmail(email);
            if (user == null || !VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }

            if (!user.IsVerified)
            {
                throw new Exception("User is not verified.");
            }
            return _mapper.Map<UserViewModel>(user);
        }


        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public async Task<bool> UpdateUserProfileImage(Guid userId, byte[] profileImage)
        {
            var user = _repository.GetById(userId);
            if (user == null)
                return false;

            if (profileImage != null && profileImage.Length > 0)
            {
                user.Image = profileImage;

                _repository.Update(user);
                await _dbContext.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
