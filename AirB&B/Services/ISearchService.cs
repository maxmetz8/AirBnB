using AirB_B.Models;
using AirB_B.Models.DTO;

namespace AirB_B.Services
{
    public interface ISearchService
    {
        public Task<IEnumerable<Location>> GetAllLocation(CancellationToken cancellationToken);
        public Task<IEnumerable<LocationDto>> GetLocation(CancellationToken cancellationToken);
    }
}
