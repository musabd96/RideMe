﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RideMe.Data;
using RideMe.Models;

namespace RideMe.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBooking(int carId, int rentalsId, int rentalPeriod, decimal totalCost)
        {
            // Check if a booking already exists for the given rentalsId
            bool isBookingExists = _context.Booking.Any(b => b.RentalsId == rentalsId);

            if (isBookingExists)
            {
                // Handle the case when a booking already exists
                // You can redirect to an error page or return an error message
                return RedirectToAction("BookingConfirmation", new { RentalsId = rentalsId });
            }

            Booking booking = new Booking
            {
                CarId = carId,
                RentalsId = rentalsId,
                RentalPeriod = rentalPeriod,
                TotalCost = totalCost
            };

            _context.Booking.Add(booking);
            _context.SaveChanges();

            // Redirect to a success page or perform any other desired action.
            return RedirectToAction("BookingConfirmation", new { RentalsId = rentalsId });
        }


        public async Task<IActionResult> BookingConfirmationAsync(int RentalsId)
        {
            var booking = await _context.Booking
                .Include(b => b.Rentals)
                .Include(b => b.Car)
                .FirstOrDefaultAsync(b => b.RentalsId == RentalsId);

            return View(booking);

        }




    }
}
