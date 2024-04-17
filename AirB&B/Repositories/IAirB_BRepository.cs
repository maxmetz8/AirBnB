using AirB_B.Models;
using AirB_B.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AirB_B.Repositories
{
    public interface IAirB_BRepository
    {
        public Task<IEnumerable<Location>> GetAllLocation(CancellationToken cancellationToken);
        public Task<IEnumerable<Location>> GetAllLocationsDTOAsync(CancellationToken cancellationToken);
        public Task<Location> GetLocationAsync(int id, CancellationToken cancellationToken);
        public Task<List<Reservation>> GetReservationsByLocationid(int locationId, CancellationToken cancellationToken);
        public Task<Customer> GetCustomerByEmail(string email, CancellationToken cancellationToken);
        public Task AddCustomer(Customer customer, CancellationToken cancellationToken);
        public Task<List<Reservation>> GetExistingReservations(int? locationId, DateTime startDate, DateTime endDate, CancellationToken cancellationToken);
        public Task AddReservation(Reservation reservation, CancellationToken cancellationToken);
        public Task SaveChanges(CancellationToken cancellationToken);
    }
}
