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
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {

            _reservationService = reservationService;

        }


        /// <summary>
        /// Post reservation for customer at a specific location
        /// </summary>
        /// <param name="postReservationDTO"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Geeft gemaakte reservering data</returns>
        /// <response code="200">Geeft gemaakte reservering data</response>
        /// <response code="400">error als de location id fout is</response>
        /// <response code="409">error als er overlappende reserveringsdata zijn bij een locatie</response>
        [HttpPost]
        [ProducesResponseType(typeof(PlacedReservationDTO), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 409)]
        public async Task<IActionResult> PostReservation(PostReservationDTO postReservationDTO,CancellationToken cancellationToken)
        {
            try
            {
                var placedReservationDto = await _reservationService.AddReservationAsync(postReservationDTO, cancellationToken);
                return Ok(placedReservationDto);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(ex.Message);
            }
        }
    }
}
