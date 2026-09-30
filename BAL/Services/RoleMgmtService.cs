using AutoMapper;
using samarth_backend.BAL.Interfaces;
using samarth_backend.DAL.Entities;
using samarth_backend.DAL.Interfaces;
using samarth_backend.DTO;

namespace samarth_backend.BAL.Services
{
    public class RoleMgmtService : IRoleMgmtService
    {
        private readonly IRoleMgmtRepository _roleMgmtRepository;
        private readonly IMapper _mapper;

        public RoleMgmtService(IRoleMgmtRepository roleMgmtRepository, IMapper mapper)
        {
            _roleMgmtRepository = roleMgmtRepository;
            _mapper = mapper;
        }

        public async Task<List<RoleMgmtListDTO>> GetAllRolesAsync()
        {
            var roles = await _roleMgmtRepository.GetAllAsync();
            return _mapper.Map<List<RoleMgmtListDTO>>(roles);
        }

        public async Task<long> AddRoleAsync(RoleMgmtDTO dto)
        {
            var roleEntity = _mapper.Map<Role>(dto);
            roleEntity.IsActive = 1;
            var createdRole = await _roleMgmtRepository.CreateAsync(roleEntity);
            return createdRole.Id;
        }
        public async Task<RoleMgmtListDTO> GetRoleDetailsByNameAsync(string name)
        {
            var roleDetails = await _roleMgmtRepository.GetDetailsAsync(n => n.Name == name);
            return _mapper.Map<RoleMgmtListDTO>(roleDetails);
        }

        public async Task<bool> UpdateRoleAsync(long id, UpdateRoleDetailsDTO dto)
        {
            var getRoleDetails = await _roleMgmtRepository.GetDetailsAsync(n => n.Id == id);
            if (getRoleDetails == null)
            {
                return false;
            }
            _mapper.Map(dto, getRoleDetails);
            await _roleMgmtRepository.UpdateAsync(getRoleDetails);
            return true;
        }
    }
}
