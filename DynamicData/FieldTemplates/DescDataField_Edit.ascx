<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DescDataField_Edit.ascx.cs" Inherits="DynamicData_DescDataField_EditField" %>

<script src="<%= Page.ResolveUrl("~/Administrator/js/ckeditor/ckeditor.js") %>"></script>


<asp:TextBox ID="TextBox2" runat="server" ClientIDMode="Static" TextMode="MultiLine" Text='<%# FieldValueEditString %>' Columns="80" Rows="5"></asp:TextBox>
<script type="text/javascript">
    CKEDITOR.replace('TextBox2');
</script>

<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="TextBox2" Display="Dynamic" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" ControlToValidate="TextBox2" Display="Dynamic" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" ControlToValidate="TextBox2" Display="Dynamic" />
