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
        <li><a href="#">View Deal</a><span class="divider">/</span></li>
	    <li class="active"><a href="viewDeal.aspx?dealID=<%= selectedDeal.DealID %>"><%= selectedDeal.Title %></a></li>
	</ul>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentAreaPlaceHolder" Runat="Server">
    <div class="span11 well" style="padding:20px;">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <h4 id="title"><%# Eval("Title")%></h4>
            </br>
            <div class="row">
                <div class="span7" style="margin-right:20px;">
                    <div style="position:relative;right:-15px;top:25px; padding-top:0; width:40px;height:44px; color: #FFFFFF; float: left;font-size: 14px; font-weight: bold; line-height: 25px; margin-top: -10px;text-align: center;background:url(images/discount.png) no-repeat scroll 0 0 transparent;">
                        <div> <%# Eval("DiscountRate") %>% </div>
                    </div>
                    <div class="yoxview">
                        <a href="<%# Eval("ImageURL") %>" class="thumbnail">
                            <img class="lazy" src="img/grey.gif" title="<%# Eval("Title") %>" data-original="<%# Eval("ImageURL") %>" alt="<%# Eval("Title") %>">
                        </a>
                    </div>
                    </br>
                    </br>
                </div>
                <div class="span4">
                    <div style="margin: 5px 0 5px 0px;"><p id="msgP"></p></div>
                    <div style="margin: 5px 0 15px 0px;">
                        <a class="btn btn-success" href="#title" id="addToWishList">Add to WishList</a>
                        <a class="btn btn-primary" href="purchase.aspx?dealID=<%# Eval("DealID") %>" id="buyDeal">Buy a Voucher</a>

                    </div>
                    <div style="margin: 5px 0 5px 0px;">
                        <p>Discounted Price&nbsp
                        <span class="label label-info" style="width:120px;font-size:large;padding:5px;">Rs. <%# Eval("DiscountedPrice") %>/=</span>
                        </p>
                    </div>
                    <div style="margin: 5px 0 5px 0px;">
                        <p>Original Price  &nbsp &nbsp &nbsp 
                        <span class="label label-error" style="width:120px; text-decoration:line-through;font-size:large;padding:5px;">Rs. <%# Eval("Value") %>/=</span>
                        </p>
                    </div
                     <div style="margin: 5px 0 25px 0px;">
                        <p>You Save  &nbsp &nbsp &nbsp  &nbsp &nbsp &nbsp  &nbsp
                        <span class="label label-warning" style="width:120px; text-decoration:underline;font-size:large;padding:5px;">Rs. <%= (selectedDeal.Value - selectedDeal.DiscountedPrice).ToString() %>/=</span>
                        </p>
                    </div
                     
                    <div class="well" style="text-align:justify;margin: 15px 0 5px 0px;">
                        <p><%# Eval("OtherDesc") %></p>
                    </div>
                </div>
            </div>
            <div class="row"></div>
            <div class="row well">
                <div><p><%# Eval("Terms") %></p></div>

            </div>
            
            
        </ItemTemplate>

    </asp:Repeater>
       
     </div>
     
</asp:Content>


<asp:Content ID="Content7" ContentPlaceHolderID="RightPanelPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="FooterImports" Runat="Server">
    <script type="text/javascript">
        $(document).ready(function () {
            // Add the page method call as an onclick handler for the div.
            $("#addToWishList").click(function () {
                $.ajax({
                    type: "POST",
                    url: "UserProfile.aspx/addToWishList",
                    data: "{dealID:<%= selectedDeal.DealID %>}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        // Replace the div's content with the page method's return.
                        $("#msgP").text(msg.d);
                    }
                });
            });
        });
    </script>
</asp:Content>

