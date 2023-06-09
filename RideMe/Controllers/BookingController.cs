﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RideMe.Data;
using RideMe.Data.Migrations;
using RideMe.Models;

namespace RideMe.Controllers
{
    //[Authorize]
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> _userManager;

        public BookingController(ApplicationDbContext context, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var userId = user.Id;

            var rentalIds = await _context.Rentals
                .Where(r => r.CustomerId == userId)
                .Select(r => r.Id)
                .ToListAsync();

            var bookingInfo = new List<Booking>();

            if (User.IsInRole("Admin"))
            {
                bookingInfo = await _context.Booking
                    .Include(b => b.Car)
                    .Include(b => b.Rentals)
                    .ToListAsync();
            }
            else
            {
                bookingInfo = await _context.Booking
                    .Include(b => b.Car)
                    .Include(b => b.Rentals)
                    .Where(b => rentalIds.Contains(b.RentalsId))
                    .ToListAsync();
            }

            return View(bookingInfo);
        }


        public async Task<IActionResult> Details(int id)
        {
            var bookingInfo = await _context.Booking
                    .Include(b => b.Car)
                    .Include(b => b.Rentals)
                    .Where(b => b.Id == id )
                    .FirstOrDefaultAsync();

            return View(bookingInfo);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Booking model)
        {
            var existingRentals = await _context.Rentals.FindAsync(model.Rentals.Id);
            var existingBooking = await _context.Booking.FindAsync(model.Id);
            
            if (existingRentals == null)
            {
                return NotFound();
            }
            existingRentals.PickupLocation = model.Rentals.PickupLocation;
            existingRentals.PickupDate = model.Rentals.PickupDate;
            existingRentals.PickupTime = model.Rentals.PickupTime;
            existingRentals.ReturnDate = model.Rentals.ReturnDate;
            existingRentals.ReturnTime = model.Rentals.ReturnTime;
            // Calculate rental period
            TimeSpan rentalPeriod = existingRentals.ReturnDate - existingRentals.PickupDate;
            existingBooking.RentalPeriod = (int)rentalPeriod.TotalDays;
            

            await _context.SaveChangesAsync();

            return RedirectToAction("Index"); 
        }




        [HttpPost]
        public IActionResult CreateBooking(int carId, int rentalsId, int rentalPeriod, decimal totalCost)
        {
            bool isBookingExists = _context.Booking.Any(b => b.RentalsId == rentalsId);

            if (isBookingExists)
            {
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

        // GET: Booking/Cancel/5
        public async Task<IActionResult> Cancel(int? id)
        {
            if (id == null || _context.Booking == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Cars/Cancel/5
        [HttpPost, ActionName("Cancel")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelConfirmed(int id)
        {
            if (_context.Booking == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Booking'  is null.");
            }
            var booking = await _context.Booking.FindAsync(id);
            if (booking != null)
            {
                _context.Booking.Remove(booking);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
