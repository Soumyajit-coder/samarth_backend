using samarth_backend.DTO;

namespace samarth_backend.BAL.Interfaces
{
    public interface IOfficeMasterService
    {
        Task<List<OfficeMasterDTO>> GetAllOfficesAsync(long? dist_code = null, long? block_code = null, long? subDiv_code = null);
        Task<long> AddOfficeAsync(AddOfficeMasterDTO dto);
        Task<OfficeMasterDTO> GetOfficeDetailsByIdAsync(long id);
        Task<bool> UpdateOfficeAsync(long id, updateOfficeMasterDTO dto);
    }
}
