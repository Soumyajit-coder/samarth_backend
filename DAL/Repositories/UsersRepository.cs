using Microsoft.EntityFrameworkCore;
using samarth_backend.DAL.Entities;
using samarth_backend.DAL.Interfaces;
using samarth_backend.DTO;

namespace samarth_backend.DAL.Repositories
{
    public class UsersRepository : Repository<User>, IUsersRepository
    {
        private readonly jaiBanglaDBContext _dbContext;
        private DbSet<User> _dbSet;
        public UsersRepository(jaiBanglaDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
            _dbSet = _dbContext.Set<User>();
        }
        public async Task<UserDTO> GetUsersByMobileNoAsync(string mobile_no)
        {
            var getUser = await (from u in _dbContext.Users
                                 where u.MobileNo == mobile_no
                                 select new UserDTO
                                 {
                                     Name = u.Name,
                                     MobileNo = u.MobileNo,
                                     Password = u.Password,

                                 }).FirstOrDefaultAsync();
            return getUser;
        }
        //public async Task<bool> UserForgetPassword(UserForgetPasswordDTO dto)
        //{
        //    var userDetails = await _dbSet.FirstOrDefaultAsync(u => u.MobileNo == dto.MobileNo);
        //    if (userDetails == null)
        //    {
        //        return false;
        //    }
        //    int updatePassword = await _dbContext.Users.Where(u => u.MobileNo == dto.MobileNo).ExecuteUpdateAsync(setters => setters.SetProperty());
        //}
    }
}
