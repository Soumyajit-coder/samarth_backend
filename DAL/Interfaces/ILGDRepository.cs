using samarth_backend.DAL.Entities;

namespace samarth_backend.DAL.Interfaces
{
    public interface ILGDRepository : IRepository<District>
    {
        Task<List<District>> GetAllDistrictAsync();
        Task<List<Block>> GetAllBlockAsync();
        Task<List<Subdivision>> GetAllSubDivisionAsync();
        Task<List<Ward>> GetAllWardAsync();
        Task<List<Panchayat>> GetAllPanchayatAsync();
        Task<List<Municipality>> GetAllMunicipalityAsync();
    }
}
