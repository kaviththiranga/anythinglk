<%@ Page Title="" Language="C#" MasterPageFile="~/anything.master" AutoEventWireup="true" CodeFile="MyWishList.aspx.cs" Inherits="MyWishList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" Runat="Server">
    MyWishList  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BannerPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CartInfoPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="SildeShowContentPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentAreaPlaceHolder" Runat="Server">
    <div class="span11 well">
        <% if (!UserController.isLoggedIn()) { %>
                <h4>Please Login First</h4>
                <a href="Register.aspx?return=<%= Request.RawUrl %>" class="btn btn-link"><asp:Literal ID="Literal2" runat="server" Text="<%$ Resources:LangResources, RegisterLabel  %>" /></a>
                <a href="#loginModal" role="button" data-toggle="modal" class="btn btn-link"><asp:Literal ID="Literal7" runat="server" Text="<%$ Resources:LangResources, SignInLabel  %>" /></a>
         <% } else { %>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <div id="events" class=" row" style="margin-bottom:20px;background-color:brown;">
                    <div class="label label-info" style="background-color:brown;"><h5><i class="icon-calendar"></i>My Wish List</h5></div>
                </div>
            </HeaderTemplate>
            <ItemTemplate>
                <div class="span2 well" style="text-align:center;min-height:320px;">                    
                    <div style="position:relative;right:-15px;top:25px; padding-top:0; width:40px;height:44px; color: #FFFFFF; float: right;font-size: 14px; font-weight: bold; line-height: 25px; margin-top: -10px;text-align: center;background:url(images/discount.png) no-repeat scroll 0 0 transparent;">
                        <div> <%# Eval("DiscountRate") %>% </div>
                    </div>
                    <div class="yoxview">
                         <a href="<%# Eval("ImageURL") %>" class="thumbnail">
                            <img class="lazy" src="img/grey.gif" data-original="<%# Eval("ImageURL") %>" title="<%# Eval("Title") %>" alt="<%# Eval("Title") %>">
                        </a>
                     &nbsp;</div>
                    <p><%# Eval("Title").ToString().Length <= 80 ? Eval("Title") : Eval("Title").ToString().Substring(0,80) %>...</p>
                        
                    <div style="margin: 5px 0 5px 0;">
                        <span class="label label-info" style="width:120px;font-size:large;padding:5px;">Rs. <%# Eval("DiscountedPrice") %>/=</span>
                    </div>
                    <div style="margin: 5px 0 5px 0;">
                        <span class="label label-warning" style="width:120px; text-decoration:line-through;font-size:large;padding:5px;">Rs. <%# Eval("Value") %>/=</span>
                    </div>
                    <a href="viewDeal.aspx?dealID=<%# Eval("DealID") %>" class="btn btn-success">View Deal <i class="icon-arrow"></i></a>
                    
                </div>
                
            </ItemTemplate>     
            <FooterTemplate>
                

            </FooterTemplate>
        </asp:Repeater>
         <% }  %>
    </div>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="RightPanelPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="FooterImports" Runat="Server">
</asp:Content>

