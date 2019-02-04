using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsFront.App_Code;

namespace TravelExpertsFront.Dashboard
{
    public partial class OrderHisory : System.Web.UI.Page
    {
        List<Booking> bookings = BookingDB.GetBookingDetails(143);

        protected void Page_Load(object sender, EventArgs e)
        {
            dlBookings.DataSource = bookings;
            dlBookings.DataBind();
        }

        protected void dlBookings_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            //HyperLink hyperLink = (HyperLink)e.Item.FindControl("collapse_arrow_link");
            //hyperLink.Target = "#" + e.Item.FindControl("pBookingDetails").ClientID;
            ////"#dlBookings_pBookingDetails";
            ListView gw = (ListView)e.Item.FindControl("dlBookingDetails");
            int bookingId = Convert.ToInt32(((TextBox)e.Item.FindControl("BookingId")).Text);

            gw.DataSource = (from bookingObj in bookings
                             where bookingObj.BookingId == bookingId
                             select bookingObj.BookingDetails).Single();

            //gw.DataBind();
            gw.DataBind();
        }
    }
}