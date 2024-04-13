using AirB_B.Models;

namespace AirB_B.Repositories
{
    public interface IAirB_BRepository
    {
        public Task<IEnumerable<Location>> GetAllLocation(CancellationToken cancellationToken);
    }
}
