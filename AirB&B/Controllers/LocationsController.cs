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

        // GET: api/Locations week 3
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocation(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetAllLocation(cancellationToken);
            return Ok(locations);
        }



        //week 4
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationDto>>> GetLocation(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetLocation(cancellationToken);
            return Ok(locations);
        }
    }   
}
