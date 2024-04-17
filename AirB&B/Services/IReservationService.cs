using AirB_B.Models.DTO;

namespace AirB_B.Services
{
    public interface IReservationService
    {
        public Task<PlacedReservationDTO> AddReservationAsync(PostReservationDTO reservationDto, CancellationToken cancellationToken);
    }
}
