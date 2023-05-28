using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RideMe.Data;
using RideMe.Data.Migrations;
using RideMe.Models;

namespace RideMe.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly ApplicationDbContext _context;


        public VehiclesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cars
        public async Task<IActionResult> Index()
        {
            // Retrieve the last inserted reservation
            var rentals = await _context.Rentals
                .OrderByDescending(m => m.Id)
                .FirstOrDefaultAsync();
            var cars = await _context.Car.ToListAsync();
            var booking = new Booking
            {
                Cars = cars,
                Rentals = rentals
            };
            return View(booking);
        }



        [HttpPost]
        public async Task<IActionResult> Create(Data.Migrations.Rentals rentals)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentals);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index"); // Redirect to the index page or another page as needed
            }

            return View(rentals);
        }


        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Car == null)
            {
                return NotFound();
            }

            var car = await _context.Car
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }
    }
}
