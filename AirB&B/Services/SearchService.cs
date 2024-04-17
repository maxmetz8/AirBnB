using AirB_B.Models;
using AirB_B.Models.DTO;
using AirB_B.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirB_B.Services
{
    public class SearchService : ISearchService
    {
        private readonly IAirB_BRepository _airB_BRepository;
        private readonly IMapper _mapper;
        public SearchService(IAirB_BRepository airBnBRepository, IMapper mapper)
        {
            _airB_BRepository = airBnBRepository;
            _mapper = mapper;

        }
        public async Task<IEnumerable<Location>> GetAllLocation(CancellationToken cancellationToken)
        {
            return await _airB_BRepository.GetAllLocation(cancellationToken);
        }

        public async Task<IEnumerable<LocationDto>> GetLocation(CancellationToken cancellationToken)
        {
            return (await _airB_BRepository.GetAllLocationsDTOAsync(cancellationToken)).Select(location => _mapper.Map<LocationDto>(location));

        }
        public async Task<IEnumerable<PricedLocationDTO>> GetPricedLocation(CancellationToken cancellationToken)
        {
            return (await _airB_BRepository.GetAllLocationsDTOAsync(cancellationToken)).Select(location => _mapper.Map<PricedLocationDTO>(location));

        }
        public async Task<IEnumerable<PricedLocationDTO>> Search(SearchDTO? obj, CancellationToken cancellationToken)
        {
            int? MinPrice = obj.MinPrice;
            int? MaxPrice = obj.MaxPrice;
            int? Room = obj.Rooms;

            if (obj.MinPrice == null)
            {
                MinPrice = 0;
            }
            if (obj.MaxPrice == null)
            {
                MaxPrice = int.MaxValue;
            }
            if (obj.Rooms == null)
            {
                Room = 0;
            }
            var list = await _airB_BRepository.GetAllLocationsDTOAsync(cancellationToken);
            if (obj.Features == null && obj.Type == null && obj.MaxPrice == null && obj.MinPrice == null && obj.Rooms == null)
            {
                return list.Select(location => _mapper.Map<PricedLocationDTO>(location));
            }
            if (obj.Features == null && obj.Type == null)
            {
                var filtered = list.Where(item => item.PricePerDay >= MinPrice).Where(item => item.PricePerDay <= MaxPrice).Where(item => item.Rooms >= Room);
                return filtered.Select(location => _mapper.Map<PricedLocationDTO>(location));
            }
            if (obj.Features == null)
            {
                var filtered = list.Where(item => item.Type == obj.Type).Where(item => item.PricePerDay >= MinPrice).Where(item => item.PricePerDay <= MaxPrice).Where(item => item.Rooms >= Room);
                return filtered.Select(location => _mapper.Map<PricedLocationDTO>(location));
            }
            if (obj.Type == null)
            {
                var filtered = list.Where(item => item.Features == obj.Features).Where(item => item.PricePerDay >= MinPrice).Where(item => item.PricePerDay <= MaxPrice).Where(item => item.Rooms >= Room);
                return filtered.Select(location => _mapper.Map<PricedLocationDTO>(location));
            }
            else
            {
                var filtered = list.Where(item => item.Features == obj.Features).Where(item => item.PricePerDay >= MinPrice).Where(item => item.PricePerDay <= MaxPrice).Where(item => item.Type == obj.Type).Where(item => item.Rooms >= Room);
                return filtered.Select(location => _mapper.Map<PricedLocationDTO>(location));
            }
        }
        public async Task<ActionResult<MaxPriceDTO>> GetMaxPrice(CancellationToken cancellationToken)
        {
            IEnumerable<MaxPriceDTO> list = (await _airB_BRepository.GetAllLocationsDTOAsync(cancellationToken)).Select(location => _mapper.Map<MaxPriceDTO>(location));
            return list.OrderByDescending(item => item.Price).First();

        }

        public async Task<ActionResult<DetailsDTO>> GetDetailsLocation(CancellationToken cancellationToken, int id)
        {
            var locationsById = await _airB_BRepository.GetLocationAsync(id, cancellationToken);
            var detailedLocation = _mapper.Map<DetailsDTO>(locationsById);
            return detailedLocation;
        }

        public async Task<UnavailableDatesDTO> GetUnavailableDates(int locatoinId, CancellationToken cancellationToken)
        {
            var reservations = await _airB_BRepository.GetReservationsByLocationid(locatoinId, cancellationToken);

            var unavailableDates = reservations.SelectMany(res => Enumerable.Range(0, (res.EndDate - res.StartDate).Days + 1)
            .Select(i => res.StartDate.AddDays(i))).ToList();
            return new UnavailableDatesDTO { UnavailableDates = unavailableDates };
        }
    }
}
