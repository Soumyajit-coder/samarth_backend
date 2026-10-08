using samarth_backend.DAL.Entities;
using samarth_backend.DTO;

namespace samarth_backend.DAL.Interfaces
{
    public interface IOfficeMasterRepository : IRepository<OfficeMaster>
    {
        Task<List<OfficeMasterDTO>> GetOfficeMasterListAsync(long? dist_code = null, long? block_code = null, long? subDiv_code = null);
        Task<OfficeMasterDTO> GetOfficeMasterByIdAsync(long id);
    }
}
