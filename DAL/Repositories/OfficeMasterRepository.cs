using Microsoft.EntityFrameworkCore;
using samarth_backend.DAL.Entities;
using samarth_backend.DAL.Interfaces;
using samarth_backend.DTO;

namespace samarth_backend.DAL.Repositories
{
    public class OfficeMasterRepository : Repository<OfficeMaster>, IOfficeMasterRepository
    {
        private readonly jaiBanglaDBContext _dbContext;
        private DbSet<OfficeMaster> _dbSet;
        public OfficeMasterRepository(jaiBanglaDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
            _dbSet = _dbContext.Set<OfficeMaster>();
        }

        public async Task<List<OfficeMasterDTO>> GetOfficeMasterListAsync(long? dist_code = null, long? block_code = null, long? subDiv_code = null)
        {
            var OfficeMasterList = await (from fm in _dbContext.OfficeMasters
                                              // Left Join (যাতে কোনো কলাম Null থাকলেও ডাটা আসে)
                                          join d in _dbContext.Districts on fm.DistrictId equals d.Id into distGroup
                                          from d in distGroup.DefaultIfEmpty()
                                          join b in _dbContext.Blocks on fm.BlockId equals b.Id into blockGroup
                                          from b in blockGroup.DefaultIfEmpty()
                                          join sub in _dbContext.Subdivisions on fm.SubdivisionId equals sub.Id into subGroup
                                          from sub in subGroup.DefaultIfEmpty()
                                          where (dist_code == null || fm.DistrictId == dist_code)
                                             && (block_code == null || fm.BlockId == block_code)
                                             && (subDiv_code == null || fm.SubdivisionId == subDiv_code)

                                          select new OfficeMasterDTO
                                          {
                                              Name = fm.Name,
                                              Address = fm.Address,
                                              OfficeTypeId = fm.OfficeTypeId,
                                              StateId = fm.StateId,
                                              DistrictId = d.Name,
                                              BlockId = b.Name,
                                              SubdivisionId = sub.Name,
                                              IsActive = fm.IsActive == 1 ? "Active" : "Inactive"
                                          }).ToListAsync();

            return OfficeMasterList;
        }
        public async Task<OfficeMasterDTO> GetOfficeMasterByIdAsync(long id)
        {
            var OfficeMasterDetails = await (from fm in _dbContext.OfficeMasters
                                          join d in _dbContext.Districts on fm.DistrictId equals d.Id
                                          join b in _dbContext.Blocks on fm.BlockId equals b.Id
                                          join sub in _dbContext.Subdivisions on fm.SubdivisionId equals sub.Id
                                          //join mun in _dbContext.Municipalities on fm.MunicipalitiyId equals mun.Id
                                          //join w in _dbContext.Wards on fm.WardId equals w.Id
                                          //join p in _dbContext.Panchayats on fm.PanchayatId equals p.Id
                                          where fm.Id == id
                                          select new OfficeMasterDTO
                                          {
                                              Name = fm.Name,
                                              Address = fm.Address,
                                              OfficeTypeId = fm.OfficeTypeId,
                                              StateId = fm.StateId,
                                              DistrictId = d.Name,
                                              BlockId = b.Name,
                                              SubdivisionId = sub.Name,
                                              //MunicipalitiyId = mun.Id,
                                              //WardId = w.Id,
                                              //PanchayatId = p.Id,
                                              IsActive = fm.IsActive == 1 ? "Active" : "Inactive"
                                          }).FirstOrDefaultAsync();
            return OfficeMasterDetails;
        }
    }
}
