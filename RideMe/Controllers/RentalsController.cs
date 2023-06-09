﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RideMe.Data;
using RideMe.Models;

namespace RideMe.Controllers
{
    //[Authorize]
    public class RentalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentalsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: ReservationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RentalsController/Details/5
        public async Task<IActionResult> Details(int? CarId, string id, int RentalsId, [Bind("Id,CustomerId, PickupLocation,PickupDate,PickupTime,ReturnDate,ReturnTime")] Rentals rentals)
        {
            if (!string.IsNullOrEmpty(rentals.PickupLocation))
            {
                var rental = await _context.Rentals
                    .OrderByDescending(r => r.Id)
                    .FirstOrDefaultAsync(r => r.CustomerId == rentals.CustomerId);

                if (rental != null)
                {
                    var rentalId = await _context.Booking
                        .FirstOrDefaultAsync(b => b.RentalsId == rental.Id);

                    if (rentalId == null)
                    {
                        
                        // Update the existing rental data
                        rental.PickupLocation = rentals.PickupLocation;
                        rental.PickupDate = rentals.PickupDate;
                        rental.PickupTime = rentals.PickupTime;
                        rental.ReturnDate = rentals.ReturnDate;
                        rental.ReturnTime = rentals.ReturnTime;

                        await _context.SaveChangesAsync();
                        var rentalsInfoPopUp = await _context.Rentals
                            .FirstOrDefaultAsync(r => r.Id == rental.Id );
                        var carPopUp = await _context.Car
                            .FirstOrDefaultAsync(m => m.Id == Int32.Parse(id.ToString()));
                        var bookingPopUp = new Booking
                        {
                            Rentals = rentalsInfoPopUp,
                            Car = carPopUp
                        };

                        return View(bookingPopUp);
                    }
                    // Create a new rental
                    var newRental = new Rentals
                    {
                        CustomerId = rentals.CustomerId,
                        PickupLocation = rentals.PickupLocation,
                        PickupDate = rentals.PickupDate,
                        PickupTime = rentals.PickupTime,
                        ReturnDate = rentals.ReturnDate,
                        ReturnTime = rentals.ReturnTime
                    };

                    _context.Rentals.Add(newRental);

                    await _context.SaveChangesAsync();

                    var rentalsInfoPopUpNew = await _context.Rentals
                            .FirstOrDefaultAsync(r => r.Id == newRental.Id);

                    var carPopUpNew = await _context.Car
                        .FirstOrDefaultAsync(m => m.Id == Int32.Parse(id.ToString()));
                    var bookingPopUpNew = new Booking
                    {
                        Rentals = rentalsInfoPopUpNew,
                        Car = carPopUpNew
                    };

                    return View(bookingPopUpNew);
                    // Return an error view indicating that the "selected-car-id" field is empty
                    //return View("Error");
                }
            }

            // Retrieve the last inserted reservation
            var rentalsInfo = await _context.Rentals
                //.OrderByDescending(m => m.Id)
                .FirstOrDefaultAsync(r => r.Id == RentalsId);
            var car = await _context.Car
                .FirstOrDefaultAsync(m => m.Id == CarId);
            var booking = new Booking
            {
                Rentals = rentalsInfo,
                Car = car
            };

            return View(booking);
        }



        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,CustomerId, PickupLocation,PickupDate,PickupTime,ReturnDate,ReturnTime")] Rentals rentals)
        {
            if (ModelState.IsValid)
            {
                var rental = await _context.Rentals
                    .OrderByDescending(r => r.Id)
                    .FirstOrDefaultAsync(r => r.CustomerId == rentals.CustomerId);

                if (rental != null)
                {
                    var rentalId = await _context.Booking
                        .FirstOrDefaultAsync(b => b.RentalsId == rental.Id);

                    if (rentalId == null)
                    {
                        // Update the existing rental data
                        rental.PickupLocation = rentals.PickupLocation;
                        rental.PickupDate = rentals.PickupDate;
                        rental.PickupTime = rentals.PickupTime;
                        rental.ReturnDate = rentals.ReturnDate;
                        rental.ReturnTime = rentals.ReturnTime;

                        await _context.SaveChangesAsync();
                        return RedirectToAction("Index", "Vehicles", new { RentalsId = rental.Id }); // Return the existing rental
                    }
                }

                // Create a new rental
                var newRental = new Rentals
                {
                    CustomerId = rentals.CustomerId,
                    PickupLocation = rentals.PickupLocation,
                    PickupDate = rentals.PickupDate,
                    PickupTime = rentals.PickupTime,
                    ReturnDate = rentals.ReturnDate,
                    ReturnTime = rentals.ReturnTime
                };

                _context.Rentals.Add(newRental);
                await _context.SaveChangesAsync();
                ViewBag.Message = "New rental created with rentalId: " + newRental.Id;
                return RedirectToAction("Index", "Vehicles", new { RentalsId = newRental.Id });
            }

            return View(rentals);


        }




        // GET: RentalsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RentalsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RentalsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RentalsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
