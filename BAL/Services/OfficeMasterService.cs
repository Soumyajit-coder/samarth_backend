using AutoMapper;
using samarth_backend.BAL.Interfaces;
using samarth_backend.DAL.Entities;
using samarth_backend.DAL.Interfaces;
using samarth_backend.DTO;

namespace samarth_backend.BAL.Services
{
    public class OfficeMasterService : IOfficeMasterService
    {
        private readonly IOfficeMasterRepository _officeMasterRepository;
        private readonly IMapper _mapper;

        public OfficeMasterService(IOfficeMasterRepository officeMasterRepository, IMapper mapper)
        {
            _officeMasterRepository = officeMasterRepository;
            _mapper = mapper;
        }
        public async Task<List<OfficeMasterDTO>> GetAllOfficesAsync(long? dist_code = null, long? block_code = null, long? subDiv_code = null)
        {
            return await _officeMasterRepository.GetOfficeMasterListAsync(dist_code, block_code, subDiv_code);
        }
        public async Task<OfficeMasterDTO> GetOfficeDetailsByIdAsync(long id)
        {             
            var officeDetails = await _officeMasterRepository.GetOfficeMasterByIdAsync(id);
            return officeDetails;
        }
        public async Task<long> AddOfficeAsync(AddOfficeMasterDTO dto)
        {
            var officeEntity = _mapper.Map<OfficeMaster>(dto);
            long maxOfficeTypeId = await _officeMasterRepository.GetMaxAsync(x => (long?)x.OfficeTypeId);
            officeEntity.OfficeTypeId = (int)maxOfficeTypeId + 1;
            officeEntity.IsActive = 1;
            officeEntity.CreatedAt = DateTime.UtcNow;

            if (officeEntity.MunicipalitiyId == 0) { officeEntity.MunicipalitiyId = null; }
            if (officeEntity.BlockId == 0) { officeEntity.BlockId = null; }
            if (officeEntity.WardId == 0) { officeEntity.WardId = null; }
            if (officeEntity.PanchayatId == 0) { officeEntity.PanchayatId = null; }
            if (officeEntity.SubdivisionId == 0) { officeEntity.SubdivisionId = null; }

            var createdOffice = await _officeMasterRepository.CreateAsync(officeEntity);
            return createdOffice.Id;
        }
        public async Task<bool> UpdateOfficeAsync(long id, updateOfficeMasterDTO dto)
        {
            var existingOffice = await _officeMasterRepository.GetDetailsAsync(f => f.Id == id);
            if (existingOffice == null)
            {
                return false; // Office not found
            }
            existingOffice.UpdatedAt = DateTime.UtcNow;
            // Map the updated properties from DTO to the existing entity
            _mapper.Map(dto, existingOffice);
            await _officeMasterRepository.UpdateAsync(existingOffice);
            return true;
        }
    }
}
