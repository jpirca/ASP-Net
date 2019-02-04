using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelExpertsFront.App_Code
{
    public class Booking
    {
        public Booking() { }                            // Constructor
        public int BookingId { get; set; }              // Booking Id
        public int CustomerId { get; set; }             // Customer Id
        public DateTime BookingDate { get; set; }       // Booking Date
        public string BookingNo { get; set; }           // Booking Number
        public decimal TravelerCount { get; set; }      // Travel 
        public string Destination { get; set; }         // Destination
        public char TripTypeId { get; set; }            // Trip Type ID
        public string TTName { get; set; }              // Trip Type Name
        public decimal TotalCost { get; set; }           // total cost of all ordered packages and products
        public List<BookingDetails> BookingDetails { get; set; } // Booking Detail List
    }
}