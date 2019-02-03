<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderHistory.aspx.cs" Inherits="TravelExpertsFront.OrderHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap/bootstrap.min.css" rel="stylesheet" />
    <script src="bootstrap/bootstrap.min.js"></script>
    <script src="bootstrap/jquery.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="CustomerID" runat="server" Value="143"/>
            <br />
            <asp:DataList ID="dlBookings" runat="server" OnItemDataBound="dlBookings_ItemDataBound" 
                RepeatDirection="Horizontal" RepeatColumns="3">
                <ItemTemplate>
                <div class="card">
                    <div class="bg-info font-weight-bold">
                    BookingId:
                    <asp:Label ID="BookingIdLabel" runat="server" Text='<%# Eval("BookingId") %>' />
                    <br />
                    CustomerId:
                    <asp:Label ID="CustomerIdLabel" runat="server" Text='<%# Eval("CustomerId") %>' />
                    <br />
                    BookingDate:
                    <asp:Label ID="BookingDateLabel" runat="server" Text='<%# Eval("BookingDate") %>' />
                    <br />
                    BookingNo:
                    <asp:Label ID="BookingNoLabel" runat="server" Text='<%# Eval("BookingNo") %>' />
                    <br />
                    TravelerCount:
                    <asp:Label ID="TravelerCountLabel" runat="server" Text='<%# Eval("TravelerCount") %>' />
                    <br />
                    TripTypeId:
                    <asp:Label ID="TripTypeIdLabel" runat="server" Text='<%# Eval("TripTypeId") %>' />
                    <br />
                    TTName:
                    <asp:Label ID="TTNameLabel" runat="server" Text='<%# Eval("TTName") %>' />
                    <br />
                    BookingDetails:
                    </div>
                    <div class="bg-light">
                    <asp:DataList ID="dlBookingDetails" runat="server">
                        <ItemTemplate>
                            BookingDetailId:
                            <asp:Label ID="BookingDetailIdLabel" runat="server" Text='<%# Eval("BookingDetailId") %>' />
                            <br />
                            ItineraryNo:
                            <asp:Label ID="ItineraryNoLabel" runat="server" Text='<%# Eval("ItineraryNo") %>' />
                            <br />
                            TripStart:
                            <asp:Label ID="TripStartLabel" runat="server" Text='<%# Eval("TripStart") %>' />
                            <br />
                            TripEnd:
                            <asp:Label ID="TripEndLabel" runat="server" Text='<%# Eval("TripEnd") %>' />
                            <br />
                            Description:
                            <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                            <br />
                            Destination:
                            <asp:Label ID="DestinationLabel" runat="server" Text='<%# Eval("Destination") %>' />
                            <br />
                            BasePrice:
                            <asp:Label ID="BasePriceLabel" runat="server" Text='<%# Eval("BasePrice") %>' />
                            <br />
                            AgencyCommission:
                            <asp:Label ID="AgencyCommissionLabel" runat="server" Text='<%# Eval("AgencyCommission") %>' />
                            <br />
                            RegionId:
                            <asp:Label ID="RegionIdLabel" runat="server" Text='<%# Eval("RegionId") %>' />
                            <br />
                            RegionName:
                            <asp:Label ID="RegionNameLabel" runat="server" Text='<%# Eval("RegionName") %>' />
                            <br />
                            ClassId:
                            <asp:Label ID="ClassIdLabel" runat="server" Text='<%# Eval("ClassId") %>' />
                            <br />
                            ClassName:
                            <asp:Label ID="ClassNameLabel" runat="server" Text='<%# Eval("ClassName") %>' />
                            <br />
                            FeeId:
                            <asp:Label ID="FeeIdLabel" runat="server" Text='<%# Eval("FeeId") %>' />
                            <br />
                            FeeName:
                            <asp:Label ID="FeeNameLabel" runat="server" Text='<%# Eval("FeeName") %>' />
                            <br />
                            ProductSupplierId:
                            <asp:Label ID="ProductSupplierIdLabel" runat="server" Text='<%# Eval("ProductSupplierId") %>' />
                            <br />
                            ProdName:
                            <asp:Label ID="ProdNameLabel" runat="server" Text='<%# Eval("ProdName") %>' />
                            <br />
                            SupName:
                            <asp:Label ID="SupNameLabel" runat="server" Text='<%# Eval("SupName") %>' />
                            <br />
                            <hr />
                        </ItemTemplate>
                    </asp:DataList>
                    </div>                    
                </div>
                    <br />
                    <br />
                </ItemTemplate>
            </asp:DataList>
            <asp:ObjectDataSource ID="BookingDBResource" runat="server" SelectMethod="GetBookingDetails" TypeName="TravelExpertsFront.App_Code.BookingDB">
                <SelectParameters>
                    <asp:ControlParameter ControlID="CustomerID" Name="CustId" PropertyName="Value" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
