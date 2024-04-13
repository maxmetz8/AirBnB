using AirB_B.Models;
using AirB_B.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AirB_B.Services
{
    public class SearchService : ISearchService
    {
        private readonly IAirB_BRepository _airB_BRepository;
        
        public SearchService(IAirB_BRepository airBnBRepository)
        {
            _airB_BRepository = airBnBRepository;

        }
        public async Task<IEnumerable<Location>> GetAllLocation(CancellationToken cancellationToken)
        {
            return await _airB_BRepository.GetAllLocation(cancellationToken);
        }
    }
}
