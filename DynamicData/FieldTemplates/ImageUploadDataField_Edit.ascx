<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ImageUploadDataField_Edit.ascx.cs" Inherits="DynamicData_FieldTemplates_ImageUploadDataField_EditField" %>

<ajaxToolkit:AjaxFileUpload ID="AjaxFileUpload1"
    ContextKeys="fred"
    AllowedFileTypes="jpg,jpeg"
    MaximumNumberOfFiles=10
    OnUploadComplete="AjaxFileUpload1_UploadComplete"
    UploaderStyle="Modern"
    OnClientUploadError=""
    runat="server"/>   
<asp:TextBox ID="TextBox1" runat="server" Text='<%# FieldValueEditString %>'></asp:TextBox>

<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="TextBox1" Display="Dynamic" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" ControlToValidate="TextBox1" Display="Dynamic" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" ControlToValidate="TextBox1" Display="Dynamic" />
