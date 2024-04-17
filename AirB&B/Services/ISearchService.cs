using AirB_B.Models;
using AirB_B.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AirB_B.Services
{
    public interface ISearchService
    {
        public Task<IEnumerable<Location>> GetAllLocation(CancellationToken cancellationToken);
        public Task<IEnumerable<LocationDto>> GetLocation(CancellationToken cancellationToken);
        public Task<IEnumerable<PricedLocationDTO>> GetPricedLocation(CancellationToken cancellationToken);
        public Task<IEnumerable<PricedLocationDTO>> Search(SearchDTO? obj, CancellationToken cancellationToken);
        public Task<ActionResult<MaxPriceDTO>> GetMaxPrice(CancellationToken cancellationToken);
        public Task<ActionResult<DetailsDTO>> GetDetailsLocation(CancellationToken cancellationToken, int id);
        public Task<UnavailableDatesDTO> GetUnavailableDates(int locationId, CancellationToken cancellationToken);
    }
}
