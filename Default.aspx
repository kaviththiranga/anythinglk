<%@ Page Title="" Language="C#" MasterPageFile="~/anything.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<%@ MasterType VirtualPath="~/anything.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
<style>

div.bgcarousel{ /* CSS for main carousel container */
background: black url(ajaxload.gif) center center no-repeat; /* loading gif while caoursel is loading */
width:700px; /* default dimensions of carousel */
height:500px;
}

img.navbutton{ /* CSS for the nav buttons */
margin:5px;
opacity:0.7;
}

div.slide{ /* CSS for each image's DIV container within main container */
background-color: black;
background-position: center center; /* center image within carousel */
background-repeat: no-repeat;
background-size: cover; /* CSS3 property to scale image within container? "cover" or "contain" */
color: black;
}

div.selectedslide{ /* CSS for currently selected slide */
}

div.slide div.desc{ /* DIV that contains the textual description inside .slide */
position: absolute;
color: white;
left: 40px;
top: 100px;
width:200px;
padding: 10px;
font: bold 16px sans-serif, Arial;
text-shadow: 0 -1px 1px #8a8a8a; /* CSS3 text shadow */
z-index:5;
}

div.selectedslide div.desc{ /* CSS for currently selected slide's desc div */
}

div.slide div.desc h2{
font-size:150%;
margin:0;
}

div.slide div.desc a{
color:yellow;
text-decoration:none;
}

</style>

<script src="bootstrap/js/bgcarousel.js" type="text/javascript">

</script>
    <script type="text/javascript">
     (function ($) {
            $(document).ready(function () {
                $('#homenav').addClass('active');
            });
        })(jQuery);
    </script>

<script type="text/javascript">

    var firstbgcarousel = new bgCarousel({
        wrapperid: 'imageslider', //ID of blank DIV on page to house carousel
        imagearray: [
            ['images/slides/baba.jpg', '<h2></h2>'], //["image_path", "optional description"]
            ['images/slides/biona.jpg', '<h2></h2>'],
            ['images/slides/funboxlk.jpg', ''],
            ['images/slides/mmi.jpg', ''],
            ['images/slides/samasungs4.jpg', ''],
            ['images/slides/starpoints.jpg', ''],
            ['images/slides/Top-Banner2.jpg', ''],
            ['images/slides/litrogas.jpg', ''] //<--no trailing comma after very last image element!
        ],
        displaymode: { type: 'auto', pause: 3000, cycles: 2, stoponclick: false, pauseonmouseover: true },
        navbuttons: ['images/slideshowbtns/left.gif', 'images/slideshowbtns/right.gif', 'images/slideshowbtns/up.gif', 'images/slideshowbtns/down.gif'], // path to nav images
        activeslideclass: 'selectedslide', // CSS class that gets added to currently shown DIV slide
        orientation: 'h', //Valid values: "h" or "v"
        persist: true, //remember last viewed slide and recall within same session?
        slideduration: 500 //transition duration (milliseconds)
    });

</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BannerPlaceHolder" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CartInfoPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SildeShowContentPlaceHolder" Runat="Server">
    <div id="imageslider" class="" style="height:200px;margin-bottom:20px;text-align:center;"></div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentAreaPlaceHolder" Runat="Server">
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />

    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
    <p>dfdfdfdfdfdf</p><br />
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="RightPanelPlaceHolder" Runat="Server">
    <div class="btn-group btn-group-vertical">
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-list"></i> <asp:Literal runat="server" Text="<%$ Resources:LangResources, DailyDealsLabel  %>" /></button>
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-shopping-cart"></i> <asp:Literal ID="Literal1" runat="server" Text="<%$ Resources:LangResources, StoreLabel  %>" /></button>
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-calendar"></i> <asp:Literal ID="Literal2" runat="server" Text="<%$ Resources:LangResources, EventsLabel  %>" /></button>
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-plane"></i> <asp:Literal ID="Literal3" runat="server" Text="<%$ Resources:LangResources, TravelLabel  %>" /></button>
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-book"></i> <asp:Literal ID="Literal4" runat="server" Text="<%$ Resources:LangResources, BooksLabel  %>" /></button>
    </div>
</asp:Content>

