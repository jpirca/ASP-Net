using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelExpertsFront.App_Code
{
    // Class to get all Bookig details
    public static class BookingDB
    {
        // Method to Get All Booking Details by Customer
        public static List<Booking> GetBookingDetails(int CustId)
        {
            List<Booking> bookingList = new List<Booking>();

            string sql = "SELECT BookingId,CustomerId,BookingDate,BookingNo,TravelerCount,TripTypeId,TTName,BookingDetailId," +
                "ItineraryNo,TripStart,TripEnd,Description,Destination,BasePrice,AgencyCommission,RegionId,RegionName," +
                "ClassId,ClassName,FeeId,FeeName,ProductSupplierId,ProdName,SupName " +
                "FROM GetOrderDetailsByID WHERE CustomerId = @Param1 ORDER BY BookingDate ASC, BookingId ASC";
            
            using (SqlConnection conn = TravelExpertsConnectDB.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Param1", CustId);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while(reader.Read())
                        {
                            Booking booking = new Booking();

                            booking.BookingId = Convert.ToInt32(reader["BookingId"]);
                            booking.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                            booking.BookingDate = Convert.ToDateTime(reader["BookingDate"]);
                            booking.BookingNo = Convert.ToString(reader["BookingNo"]);
                            booking.TravelerCount = Convert.ToDecimal(reader["TravelerCount"]);
                            booking.TripTypeId = Convert.ToChar(reader["TripTypeId"]);
                            booking.TTName = Convert.ToString(reader["TTName"]);
                            booking.BookingDetailId = Convert.ToInt32(reader["BookingDetailId"]);
                            booking.ItineraryNo = Convert.ToDecimal(reader["ItineraryNo"]);
                            booking.TripStart = Convert.ToDateTime(reader["TripStart"]);
                            booking.TripEnd = Convert.ToDateTime(reader["TripEnd"]);
                            booking.Description = Convert.ToString(reader["Description"]);
                            booking.Destination = Convert.ToString(reader["Destination"]);
                            booking.BasePrice = Convert.ToDecimal(reader["BasePrice"]);
                            booking.AgencyCommission = Convert.ToDecimal(reader["AgencyCommission"]);
                            booking.RegionId = Convert.ToString(reader["RegionId"]);
                            booking.RegionName = Convert.ToString(reader["RegionName"]);
                            booking.ClassId = Convert.ToString(reader["ClassId"]);
                            booking.ClassName = Convert.ToString(reader["ClassName"]);
                            booking.FeeId = Convert.ToString(reader["FeeId"]);
                            booking.FeeName = Convert.ToString(reader["FeeName"]);
                            booking.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);
                            booking.ProdName = Convert.ToString(reader["ProdName"]);
                            booking.SupName = Convert.ToString(reader["SupName"]);

                            bookingList.Add(booking);

                        }


                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }
            }

                return bookingList;
        }
    }
}