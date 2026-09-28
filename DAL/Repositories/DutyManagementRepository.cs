using Microsoft.EntityFrameworkCore;
using samarth_backend.DAL.Entities;
using samarth_backend.DAL.Interfaces;

namespace samarth_backend.DAL.Repositories
{
    public class DutyManagementRepository : Repository<Permission>, IDutyManagementRepository
    {
        private readonly jaiBanglaDBContext _dbContext;
        private DbSet<Permission> _dbSet;
        public DutyManagementRepository(jaiBanglaDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
            _dbSet = _dbContext.Set<Permission>();
        }
    }
}
