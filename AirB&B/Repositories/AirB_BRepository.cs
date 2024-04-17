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
        public async Task<IEnumerable<Location>> GetAllLocationsDTOAsync(CancellationToken cancellationToken)
        {
            return await _context.Location.Include(location => location.Images).Include(location => location.Landlord).ThenInclude(location => location.Avatar).ToListAsync(cancellationToken);
        }
        public async Task<Location> GetLocationAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Location
                .Include(l => l.Images)
                .Include(l => l.Landlord)
                .ThenInclude(l => l.Avatar)
                .FirstOrDefaultAsync(l => l.Id == id, cancellationToken);
        }

        public async Task<List<Reservation>> GetReservationsByLocationid(int locationId, CancellationToken cancellationToken)
        {
            return await _context.Reservation.Where(r => r.LocationId == locationId && r.EndDate >= DateTime.Today).ToListAsync(cancellationToken);
        }

        public async Task<Customer> GetCustomerByEmail(string email, CancellationToken cancellationToken)
        {
            return await _context.Customer.FirstOrDefaultAsync(obj => obj.Email == email, cancellationToken);
        }
        public async Task AddCustomer(Customer customer, CancellationToken cancellationToken)
        {
            await _context.Customer.AddAsync(customer, cancellationToken);

        }
        public async Task AddReservation(Reservation reservation, CancellationToken cancellationToken)
        {
            await _context.Reservation.AddAsync(reservation, cancellationToken);
        }
        public async Task<List<Reservation>> GetExistingReservations(int? locationId, DateTime startDate, DateTime endDate, CancellationToken cancellationToken)
        {
            return await _context.Reservation.Where(r => r.LocationId == locationId
            && r.StartDate <= endDate && r.EndDate >= startDate).ToListAsync(cancellationToken);
        }

        public async Task SaveChanges(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
