<%@ Control Language="C#" CodeFile="ForeignKey_Edit.ascx.cs" Inherits="ForeignKey_EditField" %>

<link href="<%= Page.ResolveUrl("~/Administrator/css/chosen.css")%>" rel="stylesheet">
<script src="<%= Page.ResolveUrl("~/Administrator/js/chosen.jquery.js")%>"></script>

<script type="text/javascript">
    /*====Select Box====*/
    $(function () {
        $(".chzn-select").chosen();
        $(".chzn-select-deselect").chosen({
            allow_single_deselect: true
        });
    });
</script>
<asp:DropDownList ID="DropDownList1" runat="server" CssClass="chzn-select">
</asp:DropDownList>

<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" CssClass="DDControl DDValidator" ControlToValidate="DropDownList1" Display="Static" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" CssClass="DDControl DDValidator" ControlToValidate="DropDownList1" Display="Static" />

