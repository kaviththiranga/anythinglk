<%@ Control Language="C#" CodeFile="DateTime_Edit.ascx.cs" Inherits="DateTime_EditField" %>


<div class="input-append date " id="datetimepicker1">
	<asp:TextBox ID="TextBox2" runat="server"  data-format="dd/MM/yyyy hh:mm:ss"></asp:TextBox><span class="add-on "><i data-date-icon="icon-calendar" data-time-icon="icon-time" class="icon-calendar"></i></span>
</div>
<script src="<%= Page.ResolveUrl("~/Administrator/js/bootstrap-datetimepicker.min.js") %>"></script>
<script>
    $(function () {
        $('#datetimepicker1').datetimepicker({
            language: 'pt-BR'
        });
    });
</script>
<asp:TextBox ID="TextBox1" Visible="true" runat="server" CssClass="DDTextBox" Text='<%# FieldValueEditString %>' Columns="20"></asp:TextBox>


