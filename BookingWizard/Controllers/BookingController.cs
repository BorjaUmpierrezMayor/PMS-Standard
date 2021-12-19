using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingWizard.Models;
using BookingWizard.Models.Response;
using BookingWizard.Models.Request;

namespace BookingWizard.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingController : Controller
    {
        /*
        [HttpGet]
        public IActionResult Get()
        {
            BookingResponse oResponse = new BookingResponse();

            try
            {
                using (PMSCheckinContext db = new PMSCheckinContext())
                {
                    var lst = db.Bookings.ToList();
                    oResponse.Successfully = 1;
                    oResponse.Data = lst;
                }
            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }

            return Ok(oResponse);
        }
        */


        /*
        [HttpPost]
        public IActionResult AddBookingData(BookingRequest model)
        {
            BookingResponse oResponse = new BookingResponse();

            try
            {
                using (PMSCheckinContext db = new PMSCheckinContext())
                {
                    Booking oBooking = new Booking();
                    oBooking.ArrivalDate = model.ArrivalDate;
                    oBooking.DepartureDate = model.DepartureDate;
                    oBooking.RoomType = model.RoomType;
                    oBooking.PensionType = model.PensionType;
                    db.Bookings.Add(oBooking);
                    db.SaveChanges();
                    oResponse.Successfully = 1;
                    oResponse.Data = oBooking;
                }
            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }

            return Ok(oResponse);
        }
        */


        [HttpPut]
        public IActionResult UpdateBookingData(BookingRequest model)
        {
            BookingResponse<BookingRequest> oResponse = new BookingResponse<BookingRequest>();

            try
            {
                using (PMSCheckinContext db = new PMSCheckinContext())
                {
                    Booking oBooking = db.Bookings.Find(model.Reference);

                    if (model.ArrivalDate != null)      oBooking.ArrivalDate    = model.ArrivalDate;
                    if (model.DepartureDate != null)    oBooking.DepartureDate  = model.DepartureDate;
                    if (model.RoomType != null)         oBooking.RoomType       = model.RoomType;
                    if (model.PensionType != null)      oBooking.PensionType    = model.PensionType;

                    db.Entry(oBooking).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    
                    oResponse.Successfully = 1;
                    oResponse.Data = model;
                }
            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }

            return Ok(oResponse);
        }


        // Pasamos la referencia en el enlace directamente /Referencia:
        [HttpGet("{Reference}")]
        public IActionResult GetBookingData(int Reference)
        {
            BookingResponse<Booking> oResponse = new BookingResponse<Booking>();

            try
            {
                using (PMSCheckinContext db = new PMSCheckinContext())
                {
                    Booking oBooking = db.Bookings.Find(Reference);
                    oResponse.Successfully = 1;
                    oResponse.Data = oBooking;
                }
            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }

            return Ok(oResponse);
        }

        /*
        [HttpDelete("{Reference}")]
        public IActionResult DeleteBookingData(int Reference)
        {
            BookingResponse oResponse = new BookingResponse();

            try
            {
                using (PMSCheckinContext db = new PMSCheckinContext())
                {
                    Booking oBooking = db.Bookings.Find(Reference);
                    db.Remove(oBooking);
                    db.SaveChanges();
                    oResponse.Successfully = 1;
                    oResponse.Data = oBooking;
                }
            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }

            return Ok(oResponse);
        }
        */
    }
}
