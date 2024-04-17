using AirB_B.Models.DTO;
using AirB_B.Models;
using AutoMapper;
using AirB_B.Repositories;

namespace AirB_B.Services
{
    public class ReservationService : IReservationService
    {

        private readonly IAirB_BRepository _airB_BRepository;
        private readonly IMapper _mapper;
        public ReservationService(IAirB_BRepository airBnBRepository, IMapper mapper)
        {
            _airB_BRepository = airBnBRepository;
            _mapper = mapper;
        }
        public async Task<PlacedReservationDTO> AddReservationAsync(PostReservationDTO postReservationDTO, CancellationToken cancellationToken)
        {
            var customer = await _airB_BRepository.GetCustomerByEmail(postReservationDTO.Email, cancellationToken);

            if (customer == null)
            {
                customer = new Customer
                {
                    FirstName = postReservationDTO.FirstName,
                    LastName = postReservationDTO.LastName,
                    Email = postReservationDTO.Email
                };
                await _airB_BRepository.AddCustomer(customer, cancellationToken);
            }

            var location = await _airB_BRepository.GetLocationAsync(postReservationDTO.LocationId, cancellationToken);
            if (location == null)
            {
                throw new ArgumentException("Verkeerd location ID");
            }

            var reservation = _mapper.Map<Reservation>(postReservationDTO);
            reservation.Customer = customer;
            reservation.Location = location;
            //check of er al een reservatie is gemaakt op die datum en locatie om dubbele boekingen te voorkomen
            var existingReservations = await _airB_BRepository.GetExistingReservations(reservation.LocationId, reservation.StartDate, reservation.EndDate, cancellationToken);
            if (existingReservations.Any())
            {
                throw new InvalidOperationException("Deze reservatie overlapt met een bestaande reservatie.");
            }
            await _airB_BRepository.AddReservation(reservation, cancellationToken);
            await _airB_BRepository.SaveChanges(cancellationToken);
            return _mapper.Map<PlacedReservationDTO>(reservation);
        }
    }
}
