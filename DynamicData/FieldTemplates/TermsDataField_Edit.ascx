<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TermsDataField_Edit.ascx.cs" Inherits="DynamicData_TermsDataField_EditField" %>

<script src="<%= Page.ResolveUrl("~/Administrator/js/ckeditor/ckeditor.js") %>"></script>


<asp:TextBox ID="TextBox1" runat="server" ClientIDMode="Static" TextMode="MultiLine" Text='<%# FieldValueEditString %>' Columns="80" Rows="5"></asp:TextBox>
<script type="text/javascript">
    CKEDITOR.replace('TextBox1');
</script>

<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="TextBox1" Display="Dynamic" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" ControlToValidate="TextBox1" Display="Dynamic" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" ControlToValidate="TextBox1" Display="Dynamic" />
