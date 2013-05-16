<%@ Page Title="" Language="C#" MasterPageFile="~/anything.master" AutoEventWireup="true" CodeFile="viewDeal.aspx.cs" Inherits="viewDeal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Anything.lk - <%= selectedDeal.Title %></title>
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
        <li><a href="viewDeal.aspx">View Deal</a><span class="divider">/</span></li>
	    <li class="active"><a href="viewDeal.aspx?dealID=<%= selectedDeal.DealID %>"><%= selectedDeal.Title %></a></li>
	</ul>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentAreaPlaceHolder" Runat="Server">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <h4><%# Eval("Title")%></h4>
            </br>
            <a href="<%# Eval("ImageURL") %>" class="thumbnail" style="width:auto;">
                        <img src="<%# Eval("ImageURL") %>" alt="Image : <%# Eval("Title") %>">
            </a>
            </br>
            </br>
            
            <div style="margin: 5px 0 5px 0;">
                <p>Discounted Price&nbsp
                <span class="label label-info" style="width:120px;font-size:large;padding:5px;">Rs. <%# Eval("DiscountedPrice") %>/=</span>
                </p>
            </div>
            <div style="margin: 5px 0 5px 0;">
                <p>Original Price  &nbsp &nbsp &nbsp 
                <span class="label label-warning" style="width:120px; text-decoration:line-through;font-size:large;padding:5px;">Rs. <%# Eval("Value") %>/=</span>
                </p>
            </div>
            <div><%# Eval("Terms") %></div>

        </ItemTemplate>

    </asp:Repeater>
</asp:Content>


<asp:Content ID="Content7" ContentPlaceHolderID="RightPanelPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="FooterImports" Runat="Server">
</asp:Content>

