<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ImageUploadDataField_Edit.ascx.cs" Inherits="DynamicData_FieldTemplates_ImageUploadDataField_EditField" %>

<ajaxToolkit:AjaxFileUpload ID="AjaxFileUpload1"
    ContextKeys="fred"
    AllowedFileTypes="jpg,jpeg"
    MaximumNumberOfFiles=10
    OnUploadComplete="AjaxFileUpload1_UploadComplete"
    UploaderStyle="Modern"
    OnClientUploadError="uploadError" 
    OnClientUploadComplete="uploadComplete"     
    runat="server"/>   
<script type="text/javascript">
    var imagUrl;
    var thumbUrl;
    function uploadError(sender, args) {
        addToClientTable(args.get_fileName(), "<span style='color:red;'>" + args.get_errorMessage() + "</span>");
    }
    function uploadComplete(sender, args) {
        imagUrl = 'uploadedImgs/<%= AdminController.getCurrentAdmin().User.FirstName %>' + args.get_fileName();
        thumbUrl = 'uploadedImgs/thumbs/<%= AdminController.getCurrentAdmin().User.FirstName %>' + args.get_fileName();
       
        $('TextBoxImages').val(imagUrl);
    }
    
    $('#<%= TextBoxImages.ClientID %>').val('sdsdsdsd');
  
</script>
<asp:TextBox ID="TextBoxImages" runat="server" Text='<%# FieldValueEditString %>' EnableViewState="False"></asp:TextBox>


<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="TextBoxImages" Display="Dynamic" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" ControlToValidate="TextBoxImages" Display="Dynamic" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" ControlToValidate="TextBoxImages" Display="Dynamic" />
