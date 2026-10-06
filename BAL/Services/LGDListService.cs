using AutoMapper;
using samarth_backend.BAL.Interfaces;
using samarth_backend.DAL.Interfaces;
using samarth_backend.DTO;

namespace samarth_backend.BAL.Services
{
    public class LGDListService : ILGDListService
    {
        private readonly ILGDRepository _lgdRepository;
        private readonly IMapper _mapper;

        public LGDListService(ILGDRepository lgdRepository, IMapper mapper)
        {
            _lgdRepository = lgdRepository;
            _mapper = mapper;
        }
        public async Task<List<DistrictDTO>> GetDistrictListAsync()
        {
            var distList = await _lgdRepository.GetAllDistrictAsync();
            return _mapper.Map<List<DistrictDTO>>(distList);
        }
        public async Task<List<BlockDTO>> GetBlockListAsync()
        {
            var blockList = await _lgdRepository.GetAllBlockAsync();
            return _mapper.Map<List<BlockDTO>>(blockList);
        }
        public async Task<List<SubDivisionDTO>> GetSubdivisionListAsync()
        {
            var subDivList = await _lgdRepository.GetAllSubDivisionAsync();
            return _mapper.Map<List<SubDivisionDTO>>(subDivList);
        }
        public async Task<List<WardDTO>> GetWardListAsync()
        {
            var wardList = await _lgdRepository.GetAllWardAsync();
            return _mapper.Map<List<WardDTO>>(wardList);
        }
        public async Task<List<PanchayatDTO>> GetPanchayatListAsync()
        {
            var panchayatList = await _lgdRepository.GetAllPanchayatAsync();
            return _mapper.Map<List<PanchayatDTO>>(panchayatList);
        }
        public async Task<List<MunicipalityDTO>> GetMunicipalityListAsync()
        {
            var municipalityList = await _lgdRepository.GetAllMunicipalityAsync();
            return _mapper.Map<List<MunicipalityDTO>>(municipalityList);
        }
    }
}
