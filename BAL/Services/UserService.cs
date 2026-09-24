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
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);
            int updatePassword = await _dbContext.Users.Where(u => u.MobileNo == dto.MobileNo).ExecuteUpdateAsync(setters => setters.SetProperty(u => u.Password, passwordHash));
            return true;
        }
        public bool VerifyPasswordHash(string password, string passwordHash)
        {
            if (string.IsNullOrEmpty(passwordHash) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}
