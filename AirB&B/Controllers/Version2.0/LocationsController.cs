using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AirB_B.Data;
using AirB_B.Models;
using AirB_B.Models.DTO;
using AirB_B.Services;
using AutoMapper;

namespace AirB_B.Controllers.Version2._0
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class LocationsController : ControllerBase
    {      
        private readonly ISearchService _searchService;

        public LocationsController(IMapper mapper, ISearchService searchService)
        {
            _searchService = searchService;
        }

        /// <summary>
        ///  get Locations with new DTO price and type Weekopdracht 5
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Locations
        ///
        /// </remarks>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>An <see cref="IEnumerable{LocationDto}"/> of all locations as DTOs.</returns>

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationDto>>> GetPricedLocation(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetPricedLocation(cancellationToken);
            return Ok(locations);
        }

        /// <summary>
        /// Search for locations that meet the specified criteria weekopdracht 6.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <param name="obj">Search criteria object</param>
        /// <returns>Een enumberable list of PricedLocationsDTO objects voor specifieke criteria.    
        /// </returns>

        [HttpPost("Search")]
        public async Task<IEnumerable<PricedLocationDTO>> Search(SearchDTO? obj, CancellationToken cancellationToken)
        {
            return await _searchService.Search(obj, cancellationToken);

        }
        /// <summary>
        /// Gets the max price for a location weekopdracht 6.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Locations/GetMaxPrice
        ///
        /// </remarks>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="MaxPriceDto"/> of the location with the maximum price.</returns>
        [HttpGet("GetMaxPrice")]
        public async Task<ActionResult<MaxPriceDTO>> GetMaxPrice(CancellationToken cancellationToken)
        {
            var highestprice = _searchService.GetMaxPrice(cancellationToken);
            return await highestprice;

        }

        /// <summary>
        /// Get detailed data specific location weekopdracht 6.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Locations/GetDetails/{id}
        ///
        /// </remarks>
        /// <param name="id">The ID of the location.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns> <see cref="DetailedDto"/> of the specific location.</returns>
        [HttpGet("GetDetails/{id}")]
        public async Task<ActionResult<DetailsDTO>> GetDetailLocation(int id, CancellationToken cancellationToken)
        {
            var detailsLocation = await _searchService.GetDetailsLocation(cancellationToken, id);
            return detailsLocation;
        }

        /// <summary>
        /// Get unavailable dates by locationid based on reservations week 7
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("UnAvailableDates/{locationId}")]
        public async Task<ActionResult<UnavailableDatesDTO>> GetUnavailableDatesById(int locationId, CancellationToken cancellationToken)
        {
            var unavailableDates = await _searchService.GetUnavailableDates(locationId, cancellationToken);
            return unavailableDates;
        }
    }
}
