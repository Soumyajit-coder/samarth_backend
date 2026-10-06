using Microsoft.EntityFrameworkCore;
using samarth_backend.DAL.Entities;
using samarth_backend.DAL.Interfaces;

namespace samarth_backend.DAL.Repositories
{
    public class LGDRepository : Repository<District>, ILGDRepository
    {
        private readonly jaiBanglaDBContext _dbContext;
        private DbSet<District> _districtDbSet;
        private DbSet<Subdivision> _subDivisionDbSet;
        private DbSet<Block> _blockDbSet;
        private DbSet<Ward> _wardDbSet;
        private DbSet<Panchayat> _panchayatDbSet;
        private DbSet<Municipality> _municipalityDbSet;
        public LGDRepository(jaiBanglaDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
            _districtDbSet = _dbContext.Set<District>();
            _subDivisionDbSet = _dbContext.Set<Subdivision>();
            _blockDbSet = _dbContext.Set<Block>();
            _wardDbSet = _dbContext.Set<Ward>();
            _panchayatDbSet = _dbContext.Set<Panchayat>();
            _municipalityDbSet = _dbContext.Set<Municipality>();
        }

        public async Task<List<District>> GetAllDistrictAsync()
        {
            return await _districtDbSet.ToListAsync();
        }
        public async Task<List<Block>> GetAllBlockAsync()
        {
            return await _blockDbSet.ToListAsync();
        }
        public async Task<List<Subdivision>> GetAllSubDivisionAsync()
        {
            return await _subDivisionDbSet.ToListAsync();
        }
        public async Task<List<Ward>> GetAllWardAsync()
        {
            return await _wardDbSet.ToListAsync();
        }
        public async Task<List<Panchayat>> GetAllPanchayatAsync()
        {
            return await _panchayatDbSet.ToListAsync();
        }
        public async Task<List<Municipality>> GetAllMunicipalityAsync()
        {
            return await _municipalityDbSet.ToListAsync();
        }
    }
}
