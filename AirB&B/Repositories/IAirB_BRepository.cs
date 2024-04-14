using AirB_B.Models;

namespace AirB_B.Repositories
{
    public interface IAirB_BRepository
    {
        public Task<IEnumerable<Location>> GetAllLocation(CancellationToken cancellationToken);
        public Task<IEnumerable<Location>> GetAllLocationsDTOAsync(CancellationToken cancellationToken);
        public Task<Location> GetLocationAsync(int id, CancellationToken cancellationToken);

    }
}
