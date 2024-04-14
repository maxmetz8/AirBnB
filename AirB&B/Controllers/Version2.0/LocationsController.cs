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
        /// Weekopdracht 5 get Locations met nieuwe DTO price en type
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
    }
}
