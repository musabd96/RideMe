using Microsoft.AspNetCore.Mvc;
using RideOn.Data;
using RideOn.Models;

namespace RideOn.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Endpoint for creating a reservation
        [HttpPost]
        public IActionResult Create(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Reservations.Add(reservation);
                _context.SaveChanges();

                return RedirectToAction("Confirmation", new { id = reservation.Id });
            }

            // If the model is not valid, return a BadRequest response
            return BadRequest(ModelState);
        }

        // Endpoint for displaying the confirmation page
        public IActionResult Confirmation(int id)
        {
            var reservation = _context.Reservations.Find(id);

            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }
    }
}
