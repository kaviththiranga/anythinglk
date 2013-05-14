<%@ Control Language="C#" CodeFile="MultilineText_Edit.ascx.cs" Inherits="MultilineText_EditField" %>

<script src="<%= Page.ResolveUrl("~/Administrator/js/tiny_mce/jquery.tinymce.js")%>"></script>
<script type="text/javascript">
    $(function() {
    $('textarea.tinymce').tinymce({
    // Location of TinyMCE script
        script_url: '<%= Page.ResolveUrl("~/Administrator/js/tiny_mce/tiny_mce.js")%>',
    // General options
    theme : "advanced",
    plugins : "autolink,lists,pagebreak,style,layer,table,save,advhr,advimage,advlink,emotions,iespell,inlinepopups,insertdatetime,preview,media,searchreplace,print,contextmenu,paste,directionality,fullscreen,noneditable,visualchars,nonbreaking,xhtmlxtras,template,advlist",
    // Theme options
    theme_advanced_buttons1 : "save,newdocument,|,bold,italic,underline,strikethrough,|,justifyleft,justifycenter,justifyright,justifyfull,styleselect,formatselect,fontselect,fontsizeselect",
    theme_advanced_buttons2 : "cut,copy,paste,pastetext,pasteword,|,search,replace,|,bullist,numlist,|,outdent,indent,blockquote,|,undo,redo,|,link,unlink,anchor,image,cleanup,help,code,|,insertdate,inserttime,preview,|,forecolor,backcolor",
    theme_advanced_buttons3 : "tablecontrols,|,hr,removeformat,visualaid,|,sub,sup,|,charmap,emotions,iespell,media,advhr,|,print,|,ltr,rtl,|,fullscreen",
    theme_advanced_buttons4 : "insertlayer,moveforward,movebackward,absolute,|,styleprops,|,cite,abbr,acronym,del,ins,attribs,|,visualchars,nonbreaking,template,pagebreak",
    theme_advanced_toolbar_location : "top",
    theme_advanced_toolbar_align : "left",
    theme_advanced_statusbar_location : "bottom",
    theme_advanced_resizing : true,
    // Example content CSS (should be your site CSS)
    content_css: "<%= Page.ResolveUrl("~/Administrator/css/content.css")%>",
    // Drop lists for link/image/media/template dialogs
    template_external_list_url : "<%= Page.ResolveUrl("~/Administrator/lists/template_list.js")%>",
        external_link_list_url : "<%= Page.ResolveUrl("~/Administrator/lists/link_list.js")%>",
        external_image_list_url : "<%= Page.ResolveUrl("~/Administrator/lists/image_list.js")%>",
        media_external_list_url: "<%= Page.ResolveUrl("~/Administrator/lists/media_list.js")%>",
    // Replace values for the template plugin
    template_replace_values : {
    username : "Some User",
    staffid : "991234"
    }
    });
    });
</script>

<asp:TextBox ID="TextBox1" runat="server" CssClass="tinymce" TextMode="MultiLine" Text='<%# FieldValueEditString %>' Columns="80" Rows="5"></asp:TextBox>

<asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" CssClass="DDControl DDValidator" ControlToValidate="TextBox1" Display="Static" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" CssClass="DDControl DDValidator" ControlToValidate="TextBox1" Display="Static" Enabled="false" />
<asp:DynamicValidator runat="server" id="DynamicValidator1" CssClass="DDControl DDValidator" ControlToValidate="TextBox1" Display="Static" />

