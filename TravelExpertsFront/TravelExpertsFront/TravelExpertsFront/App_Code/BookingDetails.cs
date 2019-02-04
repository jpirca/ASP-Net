using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelExpertsFront.App_Code
{
    public class BookingDetails
    {
        public BookingDetails() { }

        //public int BookingId { get; set; }              // Booking Id
        public int BookingDetailId { get; set; }        // Booking Details Id
        public decimal ItineraryNo { get; set; }        // Itinerary Number
        public DateTime? TripStart { get; set; }        // Date Trip Start
        public DateTime? TripEnd { get; set; }          // Date Trip End
        public string Description { get; set; }         // Description
        public string Destination { get; set; }         // Destination
        public decimal BasePrice { get; set; }          // Base Price
        public decimal AgencyCommission { get; set; }   // Agency Comision
        //public string RegionId { get; set; }            // Region Id
        public string RegionName { get; set; }          // Region Name
        //public string ClassId { get; set; }             // Class Id
        public string ClassName { get; set; }           // Class Name
        //public string FeeId { get; set; }               // Fee Id
        public string FeeName { get; set; }             // Fee Name
        //public int ProductSupplierId { get; set; }      // Product Supplier ID
        public string ProdName { get; set; }            // Product Name
        public string SupName { get; set; }             // Supplier Name

    }
}