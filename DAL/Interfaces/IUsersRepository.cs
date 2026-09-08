using samarth_backend.DAL.Entities;
using samarth_backend.DTO;

namespace samarth_backend.DAL.Interfaces
{
    public interface IUsersRepository : IRepository<User>
    {
        Task<UserDTO> GetUsersByMobileNoAsync(string mobile_no);
        //Task<bool> UserForgetPassword(UserForgetPasswordDTO dto);
    }
}
