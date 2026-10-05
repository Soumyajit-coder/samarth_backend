using Microsoft.EntityFrameworkCore;
using samarth_backend.DAL.Entities;
using samarth_backend.DAL.Interfaces;

namespace samarth_backend.DAL.Repositories
{
    public class SchemeMgmtRepository : Repository<Scheme>, ISchemeMgmtRepository
    {
        private readonly jaiBanglaDBContext _dbContext;
        private DbSet<Scheme> _dbSet;
        public SchemeMgmtRepository(jaiBanglaDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
            _dbSet = _dbContext.Set<Scheme>();
        }
    }
}
