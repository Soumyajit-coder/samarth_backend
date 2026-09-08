using samarth_backend.DTO;

namespace samarth_backend.BAL.Interfaces
{
    public interface IUsersService
    {
        Task<UserDTO> GetUserToAuthenticate(string mobile_no);
        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
        Task<bool> UserForgetPassword(string mobile_no, UserForgetPasswordDTO dto);
        
    }
}
