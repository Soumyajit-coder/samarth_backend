using samarth_backend.DTO;

namespace samarth_backend.BAL.Interfaces
{
    public interface ILGDListService
    {
        Task<List<DistrictDTO>> GetDistrictListAsync();
        Task<List<BlockDTO>> GetBlockListAsync();
        Task<List<SubDivisionDTO>> GetSubdivisionListAsync();
        Task<List<WardDTO>> GetWardListAsync();
        Task<List<PanchayatDTO>> GetPanchayatListAsync();
        Task<List<MunicipalityDTO>> GetMunicipalityListAsync();
    }
}
