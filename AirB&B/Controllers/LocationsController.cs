using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AirB_B.Data;
using AirB_B.Models;
using AirB_B.Services;
using AirB_B.Models.DTO;

namespace AirB_B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public LocationsController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        /// <summary>
        /// Get locations weekopdracht 3.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Locations/GetAll
        ///
        /// </remarks>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An <see cref="IEnumerable{Location}"/> of all locations.</returns>
        /// 
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocation(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetAllLocation(cancellationToken);
            return Ok(locations);
        }



        /// <summary>
        /// Get all locations DTOs weekopdracht 4.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Locations
        ///
        /// </remarks>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An <see cref="IEnumerable{LocationDto}"/> of all locations as DTOs.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationDto>>> GetLocation(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetLocation(cancellationToken);
            return Ok(locations);
        }


        /// <summary>
        /// Search for locations that meet the specified criteria weekopdracht 6.
        /// </summary>
        /// <param name="obj">Search criteria object</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>An enumerable list of PricedLocationDto objects that meet the specified criteria</returns>
        [HttpPost("Search")]
        public async Task<IEnumerable<PricedLocationDTO>> Search(SearchDTO? obj, CancellationToken cancellationToken)
        {
            return await _searchService.Search(obj, cancellationToken);

        }


        /// <summary>
        /// Gets max price for location weekopdracht 6.
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
        /// Get detailed data specific location week 6
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
    }   
}
