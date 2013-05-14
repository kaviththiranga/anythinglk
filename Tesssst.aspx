<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tesssst.aspx.cs" Inherits="Tesssst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- styles -->
<link href="<%= Page.ResolveUrl("~/Administrator/css/bootstrap.css") %>" rel="stylesheet">
<link href="<%= Page.ResolveUrl("~/Administrator/css/bootstrap-responsive.css") %>" rel="stylesheet">
 <%= Page.ResolveUrl("") %>

<link rel="stylesheet" href=" <%= Page.ResolveUrl("~/Administrator/css/font-awesome.css") %>">
 

<!--[if IE 7]>
<link rel="stylesheet" href="css/font-awesome-ie7.min.css">
<![endif]-->
<link  href="<%= Page.ResolveUrl("~/Administrator/css/styles.css") %>" rel="stylesheet">
<!--[if IE 7]>
<link rel="stylesheet" type="text/css" href="css/ie/ie7.css" />
<![endif]-->
<!--[if IE 8]>
<link rel="stylesheet" type="text/css" href="css/ie/ie8.css" />
<![endif]-->
<!--[if IE 9]>
<link rel="stylesheet" type="text/css" href="css/ie/ie9.css" />
<![endif]-->

<link href='http://fonts.googleapis.com/css?family=Dosis' rel='stylesheet' type='text/css'>
<link href="<%= Page.ResolveUrl("~/Administrator/css/DDs.css") %>" rel='stylesheet' type='text/css'>
<link href="<%= Page.ResolveUrl("~/Administrator/ico/favicon.ico") %>">
<!--============ javascript ===========-->
<script src="<%= Page.ResolveUrl("~/Administrator/js/jquery.js") %>"></script>
<script src="<%= Page.ResolveUrl("~/Administrator/js/jquery-ui-1.8.16.custom.min.js") %>"></script>
<script src="<%= Page.ResolveUrl("~/Administrator/js/bootstrap.js") %>"></script>
 

<script src="<%= Page.ResolveUrl("~/Administrator/js/accordion.nav.js") %>"></script>
 
<script src="<%= Page.ResolveUrl("~/Administrator/js/custom.js") %>"></script>
<script src="<%= Page.ResolveUrl("~/Administrator/js/respond.min.js") %>"></script>
<script src="<%= Page.ResolveUrl("~/Administrator/js/ios-orientationchange-fix.js") %>"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <script src="<%= Page.ResolveUrl("~/Administrator/js/tiny_mce/jquery.tinymce.js") %>"></script>

<script type="text/javascript">
            $(function () {
                $('textarea.tinymce').tinymce({
                    // Location of TinyMCE script
                    script_url: '<%= Page.ResolveUrl("~/Administrator/js/tiny_mce/tiny_mce.js") %>',
                    // General options
                    theme: "advanced",
                    plugins: "autolink,lists,pagebreak,style,layer,table,save,advhr,advimage,advlink,emotions,iespell,inlinepopups,insertdatetime,preview,media,searchreplace,print,contextmenu,paste,directionality,fullscreen,noneditable,visualchars,nonbreaking,xhtmlxtras,template,advlist",
                    // Theme options
                    theme_advanced_buttons1: "save,newdocument,|,bold,italic,underline,strikethrough,|,justifyleft,justifycenter,justifyright,justifyfull,styleselect,formatselect,fontselect,fontsizeselect",
                    theme_advanced_buttons2: "cut,copy,paste,pastetext,pasteword,|,search,replace,|,bullist,numlist,|,outdent,indent,blockquote,|,undo,redo,|,link,unlink,anchor,image,cleanup,help,code,|,insertdate,inserttime,preview,|,forecolor,backcolor",
                    theme_advanced_buttons3: "tablecontrols,|,hr,removeformat,visualaid,|,sub,sup,|,charmap,emotions,iespell,media,advhr,|,print,|,ltr,rtl,|,fullscreen",
                    theme_advanced_buttons4: "insertlayer,moveforward,movebackward,absolute,|,styleprops,|,cite,abbr,acronym,del,ins,attribs,|,visualchars,nonbreaking,template,pagebreak",
                    theme_advanced_toolbar_location: "top",
                    theme_advanced_toolbar_align: "left",
                    theme_advanced_statusbar_location: "bottom",
                    theme_advanced_resizing: true,
                    // Example content CSS (should be your site CSS)
                    content_css: "css/content.css",
                    // Drop lists for link/image/media/template dialogs
                    template_external_list_url: "<%= Page.ResolveUrl("~/Administrator/lists/template_list.js") %>",
                    external_link_list_url: "<%= Page.ResolveUrl("~/Administrator/lists/link_list.js") %>",
                    external_image_list_url: "<%= Page.ResolveUrl("~/Administrator/lists/image_list.js") %>",
                    media_external_list_url: "<%= Page.ResolveUrl("~/Administrator/lists/media_list.js") %>",
                    // Replace values for the template plugin
                    template_replace_values: {
                        username: "Some User",
                        staffid: "991234"
                    }
                });
            });

           
        </script>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="tinymce" TextMode="MultiLine" Text='ssdsdsd' Columns="80" Rows="5"></asp:TextBox>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
