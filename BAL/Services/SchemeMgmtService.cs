using AutoMapper;
using samarth_backend.BAL.Interfaces;
using samarth_backend.DAL.Entities;
using samarth_backend.DAL.Interfaces;
using samarth_backend.DTO;

namespace samarth_backend.BAL.Services
{
    public class SchemeMgmtService : ISchemeMgmtService
    {
        private readonly ISchemeMgmtRepository _schemeMgmtRepository;
        private readonly IMapper _mapper;

        public SchemeMgmtService(ISchemeMgmtRepository schemeMgmtRepository, IMapper mapper)
        {
            _schemeMgmtRepository = schemeMgmtRepository;
            _mapper = mapper;
        }

        public async Task<List<SchemeMgmtDTO>> GetAllSchemesAsync()
        {
            var schemes = await _schemeMgmtRepository.GetAllAsync();
            return _mapper.Map<List<SchemeMgmtDTO>>(schemes);
        }

        public async Task<SchemeMgmtDTO> GetSchemeByIdAsync(long id)
        {
            var scheme = await _schemeMgmtRepository.GetDetailsAsync(s => s.Id == id);
            return _mapper.Map<SchemeMgmtDTO>(scheme);
        }

        public async Task<SchemeMgmtDTO> CreateSchemeAsync(SchemeMgmtDTO dto)
        {
            var schemeEntity = _mapper.Map<Scheme>(dto);
            var createdScheme = await _schemeMgmtRepository.CreateAsync(schemeEntity);
            return _mapper.Map<SchemeMgmtDTO>(createdScheme);
        }

        public async Task<updateSchemeDTO> UpdateSchemeAsync(long id, updateSchemeDTO dto)
        {
            var existingScheme = await _schemeMgmtRepository.GetDetailsAsync(s => s.Id == id);
            if (existingScheme == null)
            {
                return null;
            }
            _mapper.Map(dto, existingScheme);
            await _schemeMgmtRepository.UpdateAsync(existingScheme);
            return _mapper.Map<updateSchemeDTO>(existingScheme);
        }
    }
}
