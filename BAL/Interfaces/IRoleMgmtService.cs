using samarth_backend.DTO;

namespace samarth_backend.BAL.Interfaces
{
    public interface IRoleMgmtService
    {   
        Task<List<RoleMgmtListDTO>> GetAllRolesAsync();
        Task<long> AddRoleAsync(RoleMgmtDTO dto);
        Task<RoleMgmtListDTO> GetRoleDetailsByNameAsync(string name);
        Task<bool> UpdateRoleAsync(long id, UpdateRoleDetailsDTO dto);
    }
}
