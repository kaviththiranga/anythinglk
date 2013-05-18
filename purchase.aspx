<%@ Page Title="" Language="C#" MasterPageFile="~/anything.master" AutoEventWireup="true" CodeFile="purchase.aspx.cs" Inherits="purchase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" Runat="Server">
    Purchase : <%= purchasingDeal.Title %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BannerPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CartInfoPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="SildeShowContentPlaceHolder" Runat="Server">
    <ul class="breadcrumb" style="background-color: transparent;">
		<li>You are here<span class="divider">/</span></li>
	    <li><a href="Default.aspx">Home</a> <span class="divider">/</span></li>
        <li><a href="purchase.aspx">Purchase Voucher</a><span class="divider">/</span></li>
	    <li class="active"><a href="viewDeal.aspx?dealID=<%= purchasingDeal.DealID %>"><%= purchasingDeal.Title %></a></li>
	</ul>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentAreaPlaceHolder" Runat="Server">
    <div class="span11 well">

        <p style="font-size:large;vertical-align:central;margin:10px;"> Purchase Voucher : <%= purchasingDeal.Title %><br /><a href="viewDeal.aspx?dealID=<%= purchasingDeal.DealID %>">  [View Deal]</a></p>

        <% if (!UserController.isLoggedIn()) { %>
            <div style="text-align:center">
                    </br>
                   <h4>Please Login First</h4>
                <a href="Register.aspx?return=<%= Request.RawUrl %>" class="btn btn-link"><asp:Literal ID="Literal2" runat="server" Text="<%$ Resources:LangResources, RegisterLabel  %>" /></a>
                <a href="#loginModal" role="button" data-toggle="modal" class="btn btn-link"><asp:Literal ID="Literal7" runat="server" Text="<%$ Resources:LangResources, SignInLabel  %>" /></a>
            </div>
         <% } else { %>

            <div class="form-horizontal">
                <div class="control-group">
                    <label class="control-label" for="inputQty">Quantity</label>
                    <div class="controls">
                        <% if(purchasingDeal.AllowMultiplePurchase){ %>
                            
                        <asp:DropDownList ID="inputQty" runat="server" AutoPostBack="True"></asp:DropDownList>
                            <span class="help-inline">
                                <asp:Label ID="inputQtyNameHelp" CssClass="text-error" runat="server" Text=""></asp:Label>
                            </span>
                        <% }else{ %>
                            <asp:TextBox ID="TextBox1" ReadOnly="true" runat="server" placeholder="Qty" Text="1"></asp:TextBox>
                
                            <span class="help-inline">
                                <asp:Label ID="Label1" CssClass="text-error" runat="server" Text="Only a Single Voucher per customer is allowed for this deal"></asp:Label>
                            </span>

                        <% } %>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label" for="total">Total Price</label>
                    <div class="controls">
                        <asp:Label ID="total"  runat="server" ViewStateMode="Disabled"></asp:Label>
                        <span class="help-inline">
                            <asp:Label ID="totalHelp" CssClass="text-error" runat="server" Text=""></asp:Label>
                        </span>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label" for="inputContact">
                        <asp:Literal ID="Literal6" runat="server" Text="<%$ Resources:LangResources, ContactNoText  %>" /></label>
                    <div class="controls">
                        <asp:TextBox ID="inputContact" runat="server" placeholder="<%$ Resources:LangResources, ContactNoText  %>"></asp:TextBox>
                        <span class="help-inline">
                            <asp:Label CssClass="text-error" ID="inputContactHelp" runat="server" Text=""></asp:Label>
                        </span>
                        <asp:RequiredFieldValidator ValidationGroup="Chekout" CssClass="text-error" ID="RequiredFieldValidatorEmail" runat="server"
                            ControlToValidate="inputContact" ErrorMessage="Required field cannot be left blank."
                            Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="control-group">
                    <div class="controls">
                        <asp:Button ID="Button1" ValidationGroup="Chekout" CssClass="btn btn-link" runat="server" Text="Checkout" OnClick="Button1_Click" />
                    </div>
                </div>
            </div>
          <% } %>

    </div>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="RightPanelPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="FooterImports" Runat="Server">
</asp:Content>

