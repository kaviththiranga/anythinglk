<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TermsDataField_Edit.ascx.cs" Inherits="DynamicData_TermsDataField_EditField" %>

<script src="<%= Page.ResolveUrl("~/Administrator/js/ckeditor/ckeditor.js") %>"></script>


<asp:TextBox ID="TextBoxEditor" runat="server" ClientIDMode="Static" TextMode="MultiLine" Text='<%# FieldValueEditString %>' Columns="80" Rows="5"></asp:TextBox>
<script type="text/javascript">
    CKEDITOR.replace('TextBoxEditor');
</script>

<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="TextBoxEditor" Display="Dynamic" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" ControlToValidate="TextBoxEditor" Display="Dynamic" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" ControlToValidate="TextBoxEditor" Display="Dynamic" />
