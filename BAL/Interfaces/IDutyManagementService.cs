using samarth_backend.DTO;

namespace samarth_backend.BAL.Interfaces
{
    public interface IDutyManagementService
    {
        Task<List<PermissionListDTO>> GetAllPermissionAsync();
        Task<long> AddPermissionAsync(AddPermissionDTO dto);
        Task<PermissionListDTO> GetPermissionDetailsByNameAsync(string name);
        Task<bool> UpdatePermissionAsync(long id, updatePermissionDTO dto);
    }
}
