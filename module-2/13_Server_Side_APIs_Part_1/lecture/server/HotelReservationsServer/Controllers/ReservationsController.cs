using HotelReservations.DAO;
using HotelReservations.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelReservations.Controllers
{
    [Route("reservations")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private static IReservationDao reservationDao;
        private static IHotelDao hotelDao;
        public ReservationsController()
        {
            if (hotelDao == null)
            {
                hotelDao = new HotelMemoryDao();
            }
            if (reservationDao == null)
            {
                reservationDao = new ReservationMemoryDao();
            }
        }

        [HttpGet()]
        public ActionResult<List<Reservation>> GetReservations()
        {
            return reservationDao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Reservation> GetReservation(int id)
        {
            Reservation result = reservationDao.Get(id);
            if (result != null)
            {
                return result;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteReservation(int id)
        {
            reservationDao.Delete(id);

            if (reservationDao.Delete(id))
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost()]
        public ActionResult<Reservation> AddReservation(Reservation reservation)
        {
            Reservation result = reservationDao.Create(reservation);

            if (result == null)
            {
                return StatusCode(500);
            }
            else
            {
                return result;
            }

           
        }
    }
}
