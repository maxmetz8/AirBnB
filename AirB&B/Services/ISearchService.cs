using AirB_B.Models;

namespace AirB_B.Services
{
    public interface ISearchService
    {
        public Task<IEnumerable<Location>> GetAllLocation(CancellationToken cancellationToken);
    }
}
