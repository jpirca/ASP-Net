using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsFront.App_Code;

namespace TravelExpertsFront
{
	public partial class OrderHistory : System.Web.UI.Page
	{
        
        List<Booking> bookings = BookingDB.GetBookingDetails(143);

		protected void Page_Load(object sender, EventArgs e)
		{
            dlBookings.DataSource = bookings;
            dlBookings.DataBind();
		}

        protected void dlBookings_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            DataList dl = (DataList)e.Item.FindControl("dlBookingDetails");
            int bookingId = Convert.ToInt32(((Label)e.Item.FindControl("BookingIdLabel")).Text);

            dl.DataSource = (from bookingObj in bookings
                            where bookingObj.BookingId == bookingId
                            select bookingObj.BookingDetails).Single();
                            
            dl.DataBind();
        }
    }
}