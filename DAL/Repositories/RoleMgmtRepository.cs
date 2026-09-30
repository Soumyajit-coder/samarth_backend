using Microsoft.EntityFrameworkCore;
using samarth_backend.DAL.Entities;
using samarth_backend.DAL.Interfaces;

namespace samarth_backend.DAL.Repositories
{
    public class RoleMgmtRepository : Repository<Role>, IRoleMgmtRepository
    {
        private readonly jaiBanglaDBContext _dbContext;
        private DbSet<Role> _dbSet;
        public RoleMgmtRepository(jaiBanglaDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
            _dbSet = _dbContext.Set<Role>();
        }
    }
}
