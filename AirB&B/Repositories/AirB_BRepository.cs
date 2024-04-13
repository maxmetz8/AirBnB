using AirB_B.Data;
using AirB_B.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirB_B.Repositories
{
    public class AirB_BRepository : IAirB_BRepository
    {
        private readonly AirB_BContext _context;
        public AirB_BRepository(AirB_BContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Location>> GetAllLocation(CancellationToken cancellationToken)
        {
            return await _context.Location.ToListAsync(cancellationToken);
        }
    }
}
