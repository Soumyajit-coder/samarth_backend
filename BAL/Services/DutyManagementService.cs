using AutoMapper;
using samarth_backend.BAL.Interfaces;
using samarth_backend.DAL.Entities;
using samarth_backend.DAL.Interfaces;
using samarth_backend.DTO;

namespace samarth_backend.BAL.Services
{
    public class DutyManagementService : IDutyManagementService
    {
        private readonly IDutyManagementRepository _dutyManagementRepository;
        private readonly IMapper _mapper;

        public DutyManagementService(IDutyManagementRepository dutyManagementRepository, IMapper mapper)
        {
            _dutyManagementRepository = dutyManagementRepository;
            _mapper = mapper;
        }

        public async Task<List<PermissionListDTO>> GetAllPermissionAsync()
        {
            var permissions = await _dutyManagementRepository.GetAllAsync();
            return _mapper.Map<List<PermissionListDTO>>(permissions);
        }
        public async Task<long> AddPermissionAsync(AddPermissionDTO dto)
        {
            var permissionEntity = _mapper.Map<Permission>(dto);
            permissionEntity.IsActive = 1;
            var createdPermission = await _dutyManagementRepository.CreateAsync(permissionEntity);
            return createdPermission.Id;
        }
        public async Task<PermissionListDTO> GetPermissionDetailsByNameAsync(string name)
        {
            var PermissionName = await _dutyManagementRepository.GetDetailsAsync(n => n.Name == name);
            return _mapper.Map<PermissionListDTO>(PermissionName);
        }
        public async Task<bool> UpdatePermissionAsync(long id, updatePermissionDTO dto)
        {
            var getPermissionDetails = await _dutyManagementRepository.GetDetailsAsync(n => n.Id == id);
            if (getPermissionDetails == null)
            {
                return false;
            }
            _mapper.Map(dto, getPermissionDetails);
            await _dutyManagementRepository.UpdateAsync(getPermissionDetails);
            return true;
        }
    }
}
