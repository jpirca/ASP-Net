<%@ Page Title ="Order History" Language="C#" AutoEventWireup="true" CodeBehind="OrderHistory.aspx.cs" Inherits="TravelExpertsFront.Dashboard.OrderHisory" MasterPageFile ="Dashoboard.Master" %>

 <asp:Content ID="contenthead" ContentPlaceHolderID="head" runat="server"></asp:Content>
     <asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="mainContent" runat="server">
        	<div class="content">
            	<div class="container">
                	<div class="row">
                        <asp:DataList ID="dlBookings" runat="server"  OnItemDataBound="dlBookings_ItemDataBound">
                            <ItemTemplate>
                            <div class="col-lg-12 col-md-12 col-sm-12">
							<div class="card card-circle-chart grow" data-background-color="orange">
								<div class="card-header">
                                    <asp:TextBox ID="BookingId" Text='<%# Eval("BookingId") %>' runat="server" Visible="false"/>
	                                <h5 class="card-title text-left">Booking Number: <asp:Label ID="BookingNoLabel" runat="server" Text='<%# Eval("BookingNo") %>' /></h5>
	                                <p class="description"><asp:Label ID="TTNameLabel" runat="server" Text='<%# Eval("TTName") %>' /></p>
                                    <p class="description"><span class="ti-flag-alt-2"></span><asp:Label ID="lblDestination" runat="server" Text='<%# Eval("Destination") %>' /></p>
                                    <p class="description"><span class="ti-user"></span>
                                        <span class="ti-user"> <asp:Label ID="lblTotalCustomers" runat="server" Text='<%# Eval("TravelerCount") %>' />
                                        </span>
                                    </p>
                                    <p class="description"><span class="ti-ticket"></span><asp:Label ID="lblTotalCost" runat="server" Text='<%# string.Format("{0:$#,###.##}", Eval("TotalCost")) %>' /></p>

	                            </div>
								<div class="card-content">
									More Details
                                    <div class="card-content table-responsive ">
                                    <table class="table-full-width table-bordered">
                                     <asp:ListView ID="dlBookingDetails"  runat="server">

                                        <ItemTemplate>
                                            <tr>
                                                <td>
                                                    ItineraryNo:
                                                    <asp:Label ID="ItineraryNoLabel" runat="server" Text='<%# Eval("ItineraryNo") %>' /><br />
                                                    <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' /><br />
                                                    <asp:Label ID="TripStartLabel" runat="server" Text='<%# string.Format("{0:MM/dd/yyyy}", Eval("TripStart")) %>'/> - <asp:Label ID="TripEndLabel" runat="server" Text='<%# string.Format("{0:MM/dd/yyyy}", Eval("TripEnd")) %>'/><br />
                                                    <asp:Label ID="ProdNameLabel" runat="server" Text='<%# Eval("ProdName") %>' /> - <asp:Label ID="ClassNameLabel" runat="server" Text='<%# Eval("ClassName") %>' /><br />
                                                    <asp:Label ID="SupNameLabel" runat="server" Text='<%# Eval("SupName") %>' /><br />
                                                
                                                </td>
                                                <td class="text-right">                                                                            
                                                    Base Price: <asp:Label ID="Label1" runat="server" Text='<%# string.Format("{0:$#,###.##}", Eval("BasePrice")) %>'/><br />
                                                    Agency Commission: <asp:Label ID="Label2" runat="server" Text='<%# string.Format("{0:$#,###.##}", Eval("AgencyCommission")) %>'/>
                                                </td>
                                            </tr>

                                        </ItemTemplate>
                                             
                                     </asp:ListView>
                                    </table>
                                    </div>
	                                
	                            </div>

							</div>
						</div>
                            </ItemTemplate>
                        </asp:DataList>

                      

                	</div>
                    	
                    	
                	</div>
            	</div>
         </asp:Content>



