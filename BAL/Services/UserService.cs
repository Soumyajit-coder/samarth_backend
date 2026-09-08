using AutoMapper;
using Microsoft.EntityFrameworkCore;
using samarth_backend.BAL.Interfaces;
using samarth_backend.DAL;
using samarth_backend.DAL.Interfaces;
using samarth_backend.DTO;

namespace samarth_backend.BAL.Services
{
    public class UserService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        private IMapper _mapper;
        private jaiBanglaDBContext _dbContext;
        public UserService(IUsersRepository usersRepository, IMapper mapper, jaiBanglaDBContext dbContext)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public Task<UserDTO> GetUserToAuthenticate(string mobile_no)
        {
            var userDetails = _usersRepository.GetUsersByMobileNoAsync(mobile_no);
            return userDetails;
        }
        public async Task<bool> UserForgetPassword(string mobile_no, UserForgetPasswordDTO dto)
        {
            var userDetails = await _usersRepository.GetDetailsAsync(u => u.MobileNo == dto.MobileNo);
            if (userDetails == null)
            {
                return false;
            }
            byte[] passwordHash, passwordSalt;
            PasswordHasher(dto.Password, out passwordHash, out passwordSalt);
            int updatePassword = await _dbContext.Users.Where(u => u.MobileNo == dto.MobileNo).ExecuteUpdateAsync(setters => setters.SetProperty(u => u.PasswordHash, passwordHash).SetProperty(u => u.PasswordSalt, passwordSalt));
            return true;
        }
        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            if (passwordHash == null || passwordSalt == null || string.IsNullOrEmpty(password))
            {
                return false;
            }
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                        return false;
                }
            }
            return true;
        }
        private void PasswordHasher(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
