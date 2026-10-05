using samarth_backend.DTO;

namespace samarth_backend.BAL.Interfaces
{
    public interface ISchemeMgmtService
    {
        Task<List<SchemeMgmtDTO>> GetAllSchemesAsync();
        Task<SchemeMgmtDTO> GetSchemeByIdAsync(long id);
        Task<SchemeMgmtDTO> CreateSchemeAsync(SchemeMgmtDTO dto);
        Task<updateSchemeDTO> UpdateSchemeAsync(long id, updateSchemeDTO dto);
        //Task<bool> DeleteScheme(long id);
    }
}
