<%@ Page Title="" Language="C#" MasterPageFile="~/anything.master" AutoEventWireup="true" CodeFile="MyOrders.aspx.cs" Inherits="MyOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">    
    <style type="text/css">
        .rounded_corners
        {
            border: 1px solid #A1DCF2;
            -webkit-border-radius: 8px;
            -moz-border-radius: 8px;
            border-radius: 8px;
            overflow: hidden;
        }
        .rounded_corners td, .rounded_corners th
        {
            border: 1px solid #A1DCF2;
            font-family: Arial;
            font-size: 10pt;
            text-align: center;
            padding:6px 20px 6px 20px;
        }
        .rounded_corners table table td
        {
            border-style: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BannerPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CartInfoPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="SildeShowContentPlaceHolder" Runat="Server">
     <ul class="breadcrumb" style="background-color: transparent;">
		<li>You are here<span class="divider">/</span></li>
	    <li><a href="Default.aspx">Home</a> <span class="divider">/</span></li>
        <li class="active"><a href="#">My Orders</a><span class="divider">/</span></li>
	    
	</ul>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentAreaPlaceHolder" Runat="Server">
    <div class="span11 well" >
         <% if (!UserController.isLoggedIn()) { %>
            <div style="text-align:center">
                    <br/>
                   <h4>Please Login First</h4>
                <a href="Register.aspx?return=<%= Request.RawUrl %>" class="btn btn-link"><asp:Literal ID="Literal2" runat="server" Text="<%$ Resources:LangResources, RegisterLabel  %>" /></a>
                <a href="#loginModal" role="button" data-toggle="modal" class="btn btn-link"><asp:Literal ID="Literal7" runat="server" Text="<%$ Resources:LangResources, SignInLabel  %>" /></a>
            </div>
         <% } else { %>
            <div class="rounded_corners" >
                <asp:GridView ID="GridView1" runat="server" HeaderStyle-BackColor="#3AC0F2"
                    HeaderStyle-ForeColor="White" RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White"
                    RowStyle-ForeColor="#3A3A3A" AutoGenerateColumns="false" PageSize="10">
                    <Columns>
                        <asp:BoundField DataField="DealID" HeaderText="DealID" />
                        <asp:BoundField DataField="Qty" HeaderText="Quantity" />
                        <asp:BoundField DataField="Total" HeaderText="Total" />
                        <asp:BoundField DataField="PlacedOn" HeaderText="PlacedOn" />
                        <asp:BoundField DataField="ExpiresOn" HeaderText="ExpiresOn" />
                        <asp:BoundField DataField="Status" HeaderText="Status" />
                        <asp:TemplateField HeaderText="Expired?">
                            <ItemTemplate> 
                              <asp:Label ID="BirthDateLabel" Runat="Server" 
                                         Text='<%# Eval("isExpired") %>' />
                            </ItemTemplate>
                       </asp:TemplateField> 
                      <asp:HyperLinkField Text="View Deal"
                                          DataNavigateUrlFormatString="~/viewDeal.aspx?dealID={0}"
                                          DataNavigateUrlFields="DealID" />
                    </Columns>
                </asp:GridView>
            </div>

        <% } %>
    </div>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="RightPanelPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="FooterImports" Runat="Server">
</asp:Content>

