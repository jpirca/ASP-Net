<%@ Page  Title ="Edit Profile" Language="C#" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="TravelExpertsFront.Dashboard.editProfile" MasterPageFile ="Dashoboard.Master"%>
 <asp:Content ID="contenthead" ContentPlaceHolderID="head" runat="server"></asp:Content>
     <asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="mainContent" runat="server">
<%--Customer Registration Form
    Author:Muhammad islam
    Created:Jan, 2019--%>
    <%--<div class="wrapper">--%>
		<!--   you can change the color of the filter page using: data-color="blue | azure | green | orange | red | purple" -->
        	
       
            <div class="content">
	            <div class="container-fluid">
	                <div class="row">
	                    <div class="col-lg-4 col-md-5">
	                        <div class="card card-user">
	                            <div class="image">
	                                <img src="../../assets/img/background.jpg" alt="..."/>
	                            </div>
	                            <div class="card-content">
	                                <div class="author">
	                                  <img class="avatar border-white" src="../../assets/img/faces/face-2.jpg" alt="..."/>
	                                  <h4 class="card-title">Chet Faker<br />
	                                     <a href="#"><small>@chetfaker</small></a>
	                                  </h4>
	                                </div>
	                                <p class="description text-center">
	                                    "I like the way you work it <br>
	                                    No diggity <br>
	                                    I wanna bag it up"
	                                </p>
	                            </div>
	                            <hr>
	                            <div class="text-center">
	                                <div class="row">
	                                    <div class="col-md-3 col-md-offset-1">
	                                        <h5>12<br /><small>Files</small></h5>
	                                    </div>
	                                    <div class="col-md-4">
	                                        <h5>2GB<br /><small>Used</small></h5>
	                                    </div>
	                                    <div class="col-md-3">
	                                        <h5>24,6$<br /><small>Spent</small></h5>
	                                    </div>
	                                </div>
	                            </div>
	                        </div>
	                        <div class="card">
	                            <div class="card-header">
	                                <h4 class="card-title">Team Members</h4>
	                            </div>
	                            <div class="card-content">
	                                <ul class="list-unstyled team-members">
                                        <li>
                                            <div class="row">
                                                <div class="col-xs-3">
                                                    <div class="avatar">
                                                        <img src="../../assets/img/faces/face-0.jpg" alt="Circle Image" class="img-circle img-no-padding img-responsive">
                                                    </div>
                                                </div>
                                                <div class="col-xs-6">
                                                    DJ Khaled
                                                    <br />
                                                    <span class="text-muted"><small>Offline</small></span>
                                                </div>
                                                <div class="col-xs-3 text-right">
                                                    <btn class="btn btn-sm btn-success btn-icon"><i class="fa fa-envelope"></i></btn>
                                                </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class="row">
                                                <div class="col-xs-3">
                                                    <div class="avatar">
                                                        <img src="../../assets/img/faces/face-1.jpg" alt="Circle Image" class="img-circle img-no-padding img-responsive">
                                                    </div>
                                                </div>
                                                <div class="col-xs-6">
                                                    Creative Tim
                                                    <br />
                                                    <span class="text-success"><small>Available</small></span>
                                                </div>
                                                <div class="col-xs-3 text-right">
                                                    <btn class="btn btn-sm btn-success btn-icon"><i class="fa fa-envelope"></i></btn>
                                                </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class="row">
                                                <div class="col-xs-3">
                                                    <div class="avatar">
                                                        <img src="../../assets/img/faces/face-3.jpg" alt="Circle Image" class="img-circle img-no-padding img-responsive">
                                                    </div>
                                                </div>
                                                <div class="col-xs-6">
                                                    Flume
                                                    <br />
                                                    <span class="text-danger"><small>Busy</small></span>
                                                </div>
                                                <div class="col-xs-3 text-right">
                                                    <btn class="btn btn-sm btn-success btn-icon"><i class="fa fa-envelope"></i></btn>
                                                </div>
                                            </div>
                                        </li>
	                                </ul>
	                            </div>
	                        </div>
	                    </div>
	                    <div class="col-lg-8 col-md-7">
	                        <div class="card">
	                            <div class="card-header">
	                                <h4 class="card-title">Edit Profile</h4>
	                            </div>
	                            <div class="card-content">
	                                <form id="form1" runat="server">
	                                  
	                                    <div class="row">
	                                        <div class="col-md-6">
	                                            <div class="form-group">
	                                                <label>First Name</label>
	                                                <asp:TextBox ID="txtFirstName" runat="server" class="form-control border-input" placeholder="First Name"></asp:TextBox>
                                                     <asp:Label ID="lblPovideFname" runat="server" Text="*First Name" Class="lablestyle"></asp:Label>
	                                            </div>
	                                        </div>
	                                        <div class="col-md-6">
	                                            <div class="form-group">
	                                                <label>Last Name</label>
	                                                <asp:TextBox ID="txtLastName" runat="server" class="form-control border-input" placeholder="Last Name"></asp:TextBox>
                                                     <asp:Label ID="lblprovideLastName" runat="server" CssClass="lableerror"></asp:Label>
	                                            </div>
	                                        </div>
	                                    </div>
	                                    <div class="row">
	                                        <div class="col-md-12">
	                                            <div class="form-group">
	                                                <label>Address</label>
	                                                <asp:TextBox ID="txtAddress" runat="server" class="form-control border-input" placeholder="Home Address"></asp:TextBox>
                                                     <asp:Label ID="lblProvidAddrss" runat="server" CssClass="lableerror"></asp:Label>
	                                            </div>
	                                        </div>
	                                    </div>
	                                    <div class="row">
	                                        <div class="col-md-3">
	                                            <div class="form-group">
	                                                <label>City</label>
	                                                <asp:TextBox ID="txtCity" runat="server" class="form-control border-input" placeholder="City"></asp:TextBox>
                                                     <asp:Label ID="lblProvideCity" runat="server" CssClass="lableerror"></asp:Label>
	                                            </div>
	                                        </div>
                                            <div class="col-md-3">
	                                            <div class="form-group">
	                                                <label>Province</label>
	                                                <asp:TextBox ID="txtProvince" runat="server" class="form-control border-input" placeholder="Province"></asp:TextBox>
                                                     <asp:Label ID="lblProvideProvince" runat="server" CssClass="lableerror"></asp:Label>
	                                            </div>
	                                        </div>
	                                        <div class="col-md-3">
	                                            <div class="form-group">
	                                                <label>Country</label>
	                                                <asp:TextBox ID="txtCountry" runat="server" class="form-control border-input" placeholder="Country"></asp:TextBox>
                                                    <asp:Label ID="lblProvideCountry" runat="server" CssClass="lableerror"></asp:Label>
	                                            </div>
	                                        </div>
	                                        <div class="col-md-3">
	                                            <div class="form-group">
	                                                <label>Postal Code</label>
	                                                <asp:TextBox ID="txtPostalCode" runat="server" class="form-control border-input" placeholder="ZIP Code"></asp:TextBox>
                                                      <asp:Label ID="lblProvidePostalCode" runat="server" CssClass="lableerror"></asp:Label>
	                                            </div>
	                                        </div>
	                                    </div>
                                         <div class="row">
	                                        <div class="col-md-6">
	                                            <div class="form-group">
                                                     <label>Home Phone</label>
                                                    <asp:TextBox ID="txtHomePhone" runat="server" class="form-control border-input" placeholder="(587)9879999"></asp:TextBox>
                                                     <asp:Label ID="lblProvideHomePhone" runat="server" CssClass="lableerror"></asp:Label>
                                                     </div>
                                                 </div>
                                                    <div class="col-md-6">
                                                     <div class="form-group">
                                                    <asp:Label ID="lblBusPhone" runat="server" class="lablestyle">Business Phone</asp:Label>
                                                     <asp:TextBox ID="txtBusPhone" runat="server" class="form-control border-input" placeholder="(587)9879999"></asp:TextBox>
                                                         <asp:Label ID="lblProvideBusPhone" runat="server" CssClass="lableerror"></asp:Label>
	                                                </div>
                                                       <%--<asp:TextBox ID="txtHomePhone" class="form-control border-input" placeholder="(587)9789999"></asp:TextBox>--%>
                                                   </div>
                                               
                                             </div>
                                        <div class="row">
                                           <div class="col-md-4">
	                                            <div class="form-group">
                                                     <asp:Label ID="lblEmail" runat="server" class="lablestyle">*Email</asp:Label>
                                                     <asp:TextBox ID="txtEmail" runat="server" class="form-control border-input" placeholder="jhon@gmail.com"></asp:TextBox>
                                                     </div>
                                                 </div>
                                                    <div class="col-md-4">
                                                    <div class="form-group">
                                                    <asp:Label ID="lblAgent" runat="server" class="lablestyle">Agent</asp:Label>
                                                 <asp:DropDownList ID="drpAgents" runat="server" class="form-control" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="agentID"></asp:DropDownList>
                                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAgents" TypeName="TravelExpertsFront.AgentsDB"></asp:ObjectDataSource>
	                                                </div>
                                                       <%--<asp:TextBox ID="txtHomePhone" class="form-control border-input" placeholder="(587)9789999"></asp:TextBox>--%>
                                                   </div>
                                            <div class="col-md-4">
                                                    <div class="form-group">
                                                        <asp:Label ID="lblCustPassword" runat="server" class="lablestyle">Update Your Password (Optional)</asp:Label>
                                                         <asp:TextBox ID="txtCustPassword" TextMode="Password" runat="server" class="form-control border-input"></asp:TextBox>
                                                         <asp:Label ID="lblProvidCustPassword" runat="server" CssClass="lableerror"></asp:Label>
                                                        </div>

                                            </div>
                                        </div>
                                
	                          
	                                    <div class="text-center">
                                             <asp:Button ID="btnUpdate" class="btn btn-info btn-fill btn-wd" runat="server" OnClick="btnUpdate_Click" Text="Create Free Account" />
	                                        <button type="submit" class="btn btn-info btn-fill btn-wd">Update Profile</button>
                                             <asp:Label ID="lblUpdated" runat="server" CssClass="lableerror"></asp:Label>
	                                    </div>
	                                    <div class="clearfix"></div>
	                                </form>
	                            </div>
	                        </div>
	                    </div>
	                </div>
	            </div>
	        <%--</div>--%>


          </div>
</asp:Content>

