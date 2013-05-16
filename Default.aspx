<%@ Page Title="" Language="C#" MasterPageFile="~/anything.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<%@ MasterType VirtualPath="~/anything.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <style>
        div.bgcarousel{background:#000 url(ajaxload.gif) center center no-repeat;width:700px;height:500px}
        img.navbutton{opacity:0.7;margin:5px}
        div.slide{background-color:#000;background-position:center center;background-repeat:no-repeat;background-size:cover;color:#000}
        div.slide div.desc{position:absolute;color:#FFF;left:40px;top:100px;width:200px;font:bold 16px sans-serif, Arial;text-shadow:0 -1px 1px #8a8a8a;z-index:5;padding:10px}
        div.slide div.desc h2{font-size:150%;margin:0}
        div.slide div.desc a{color:#FF0;text-decoration:none}
    </style>

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BannerPlaceHolder" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CartInfoPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SildeShowContentPlaceHolder" Runat="Server">
    <div id="imageslider" class="" style="height:200px;margin-bottom:20px;text-align:center;"></div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentAreaPlaceHolder" Runat="Server">
    <div class="row">
        <asp:Repeater ID="DailyDRepeater" runat="server">
            <HeaderTemplate>
                <div id="dailydeals" class="span8 label label-info" style="margin-bottom:20px;">
                    <div class="label label-info"><h5><i class="icon-list"></i> &nbsp Daily Deals</h5></div>
                </div>
            </HeaderTemplate>
            <ItemTemplate>
                <div class="span2 well" style="text-align:center;">                    

                     <a href="<%# Eval("ImageURL") %>" class="thumbnail">
                        <img class="lazy" src="img/grey.gif" data-original="<%# Eval("ImageURL") %>" alt="<%# Eval("Title") %>">
                    </a>
                    <p;><%# Eval("Title") %></p>
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
    </div>
    <div class="row">
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <div id="dailydeals" class="span8 label label-info" style="margin-bottom:20px;">
                    <div class="label label-info"><h5><i class="icon-list"></i> &nbsp Daily Deals</h5></div>
                </div>
            </HeaderTemplate>
            <ItemTemplate>
                <div class="span2 well" style="text-align:center;">                    

                     <a href="<%# Eval("ImageURL") %>" class="thumbnail">
                        <img class="lazy" src="img/grey.gif" data-original="<%# Eval("ImageURL") %>" alt="<%# Eval("Title") %>">
                    </a>
                    <p;><%# Eval("Title") %></p>
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
    </div>
    <div class="row">
        <asp:Repeater ID="Repeater2" runat="server">
            <HeaderTemplate>
                <div id="dailydeals" class="span8 label label-info" style="margin-bottom:20px;">
                    <div class="label label-info"><h5><i class="icon-list"></i> &nbsp Daily Deals</h5></div>
                </div>
            </HeaderTemplate>
            <ItemTemplate>
                <div class="span2 well" style="text-align:center;">                    

                     <a href="<%# Eval("ImageURL") %>" class="thumbnail">
                        <img class="lazy" src="img/grey.gif" data-original="<%# Eval("ImageURL") %>" alt="<%# Eval("Title") %>">
                    </a>
                    <p;><%# Eval("Title") %></p>
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
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="RightPanelPlaceHolder" Runat="Server">
    <div id="JumpLinks"class="btn-group btn-group-vertical">
        <a class="btn" href="#dailydeals" style="width:120px;text-align:left;background:lightgray;"><i class="icon-list"></i> <asp:Literal runat="server" Text="<%$ Resources:LangResources, DailyDealsLabel  %>" /></a>
        <a class="btn" style="width:120px;text-align:left;background:lightgray;"><i class="icon-calendar"></i> <asp:Literal ID="Literal2" runat="server" Text="<%$ Resources:LangResources, EventsLabel  %>" /></a>
        <a class="btn" style="width:120px;text-align:left;background:lightgray;"><i class="icon-plane"></i> <asp:Literal ID="Literal3" runat="server" Text="<%$ Resources:LangResources, TravelLabel  %>" /></a>
        <a class="btn" style="width:120px;text-align:left;background:lightgray;"><i class="icon-book"></i> <asp:Literal ID="Literal4" runat="server" Text="<%$ Resources:LangResources, BooksLabel  %>" /></a>
    </div>

</asp:Content>

<asp:Content ID="Content7" ContentPlaceHolderID="FooterImports" Runat="Server">
    <script src="bootstrap/js/bgcarousel.js" type="text/javascript">

    </script>
    <script type="text/javascript">
        (function ($) { $(document).ready(function () { $('#homenav').addClass('active') }) })(jQuery);
    </script>

    <script type="text/javascript">
        var firstbgcarousel = new bgCarousel({
            wrapperid: 'imageslider', imagearray: [['images/slides/baba.jpg', '<h2></h2>'], ['images/slides/biona.jpg', '<h2></h2>'], ['images/slides/funboxlk.jpg', ''], ['images/slides/mmi.jpg', ''], ['images/slides/samasungs4.jpg', ''], ['images/slides/starpoints.jpg', ''], ['images/slides/Top-Banner2.jpg', ''], ['images/slides/litrogas.jpg', '']], displaymode: { type: 'auto', pause: 3000, cycles: 2, stoponclick: false, pauseonmouseover: true }, navbuttons: ['images/slideshowbtns/left.gif', 'images/slideshowbtns/right.gif', 'images/slideshowbtns/up.gif', 'images/slideshowbtns/down.gif'], activeslideclass: 'selectedslide', orientation: 'h', persist: true, slideduration: 500
        });
    </script>
    <script type="text/javascript">
        (function ($) {
            $('#JumpLinks, a').click(function () {
                $('html, body').animate({
                    scrollTop: $($.attr(this, 'href')).offset().top
                }, 500);
                return false;
            });
        })(jQuery);
    </script>
</asp:Content>