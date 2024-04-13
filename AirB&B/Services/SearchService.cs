using AirB_B.Models;
using AirB_B.Models.DTO;
using AirB_B.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AirB_B.Services
{
    public class SearchService : ISearchService
    {
        private readonly IAirB_BRepository _airB_BRepository;
        private readonly IMapper _mapper;
        public SearchService(IAirB_BRepository airBnBRepository, IMapper mapper)
        {
            _airB_BRepository = airBnBRepository;
            _mapper = mapper;

        }
        public async Task<IEnumerable<Location>> GetAllLocation(CancellationToken cancellationToken)
        {
            return await _airB_BRepository.GetAllLocation(cancellationToken);
        }

        public async Task<IEnumerable<LocationDto>> GetLocation(CancellationToken cancellationToken)
        {
            return (await _airB_BRepository.GetAllLocationsDTOAsync(cancellationToken)).Select(location => _mapper.Map<LocationDto>(location));

        }
    }
}
