<%@ Page Title="" Language="C#" MasterPageFile="~/anything.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        function emailvalidate(src, args) {
            $.ajax({
                type: "POST",
                url: "Register.aspx/isEmailNotRegistered",
                data: "{'email': '" + args.Value + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: false,
                success: function (msg) {
                    args.IsValid = msg.d;
                }
            });
        }
        
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BannerPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CartInfoPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SildeShowContentPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentAreaPlaceHolder" Runat="Server">
    <div class="form-horizontal">
        <div class="control-group">
            <label class="control-label" for="inputFirstName"><asp:Literal ID="Literal44" runat="server" Text="<%$ Resources:LangResources, FirstNameText  %>" /></label>
            <div class="controls">
                <asp:TextBox ID="inputFirstName"  runat="server" placeholder="<%$ Resources:LangResources, FirstNameText  %>"></asp:TextBox>
                
                <span class="help-inline">
                    <asp:Label ID="inputFirstNameHelp" CssClass="text-error" runat="server" Text=""></asp:Label>
                </span>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label" for="inputLastName"><asp:Literal ID="Literal1" runat="server" Text="<%$ Resources:LangResources, LastNameText  %>" /></label>
            <div class="controls">
                <asp:TextBox ID="inputLastName"  runat="server" placeholder="<%$ Resources:LangResources, LastNameText  %>"></asp:TextBox>
                <span class="help-inline">
                    <asp:Label ID="inputLastNameHelp" CssClass="text-error" runat="server" Text=""></asp:Label>
                </span>
            </div>
        </div>
        
        <div class="control-group">
            <label class="control-label" for="inputEmail"><asp:Literal ID="Literal3" runat="server" Text="<%$ Resources:LangResources, EmailText  %>" /></label>
            <div class="controls">
                <asp:TextBox ID="inputEmail"  runat="server" placeholder="<%$ Resources:LangResources, EmailText  %>"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="text-error" ID="RequiredFieldValidatorEmail" runat="server"
                    ControlToValidate="inputEmail" ErrorMessage="Required field cannot be left blank."
                    Display="Dynamic">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" CssClass="text-error"
                    ErrorMessage="Invalid email address." ControlToValidate="inputEmail"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    Display="Dynamic">
                </asp:RegularExpressionValidator>
                <span class="help-inline">
                     <asp:CustomValidator ID="CustomValidatorEmail" CssClass="text-error" ControlToValidate="inputEmail" ClientValidationFunction="emailvalidate" runat="server" ErrorMessage="This Email is already registered"></asp:CustomValidator>
                    <asp:Label ID="inputEmailHelp" CssClass="text-error" runat="server" Text=""></asp:Label>
                </span>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label" for="inputPassword"><asp:Literal ID="Literal4" runat="server" Text="<%$ Resources:LangResources, PasswordText  %>" /></label>
            <div class="controls">
                <asp:TextBox ID="inputPassword" runat="server" placeholder="<%$ Resources:LangResources, PasswordText  %>" ></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="text-error" ID="RequiredFieldValidatorPassword" runat="server"
                    ControlToValidate="inputPassword" ErrorMessage="Required field cannot be left blank."
                    Display="Dynamic">
                </asp:RequiredFieldValidator>
                <span class="help-inline">
                    <asp:Label ID="inputPasswordHelp" CssClass="text-error" runat="server" Text=""></asp:Label>
                </span>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label" for="inputPassword2"><asp:Literal ID="Literal5" runat="server" Text="<%$ Resources:LangResources, ConfirmPasswordText  %>" /></label>
            <div class="controls">
                <asp:TextBox ID="inputPassword2" runat="server" placeholder="<%$ Resources:LangResources, ConfirmPasswordText  %>" ></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="text-error" ID="RequiredFieldValidatorPassword2" runat="server"
                    ControlToValidate="inputPassword2" ErrorMessage="Required field cannot be left blank."
                    Display="Dynamic">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorPassword" CssClass="text-error" runat="server"
                    ErrorMessage="Passwords do not match." ControlToCompare="inputPassword"
                    ControlToValidate="inputPassword2">
                </asp:CompareValidator>
                <span class="help-inline">
                    <asp:Label CssClass="text-error" ID="inputPassword2Help" runat="server" Text=""></asp:Label>
                </span>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label" for="inputContact"><asp:Literal ID="Literal6" runat="server" Text="<%$ Resources:LangResources, ContactNoText  %>" /></label>
            <div class="controls">
                <asp:TextBox ID="inputContact" runat="server" placeholder="<%$ Resources:LangResources, ContactNoText  %>" ></asp:TextBox>
                <span class="help-inline">
                    <asp:Label CssClass="text-error" ID="inputContactHelp" runat="server" Text=""></asp:Label>
                </span>
            </div>
        </div>
        <div class="control-group">
            <div class="controls">
                <asp:Button ID="Button1" CssClass="btn btn-link" runat="server" Text="<%$ Resources:LangResources, RegisterLabel  %>" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="RightPanelPlaceHolder" Runat="Server">
    <div class="btn-group btn-group-vertical">
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-list"></i> <asp:Literal ID="Literal7" runat="server" Text="<%$ Resources:LangResources, DailyDealsLabel  %>" /></button>
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-shopping-cart"></i> <asp:Literal ID="Literal8" runat="server" Text="<%$ Resources:LangResources, StoreLabel  %>" /></button>
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-calendar"></i> <asp:Literal ID="Literal9" runat="server" Text="<%$ Resources:LangResources, EventsLabel  %>" /></button>
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-plane"></i> <asp:Literal ID="Literal10" runat="server" Text="<%$ Resources:LangResources, TravelLabel  %>" /></button>
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-book"></i> <asp:Literal ID="Literal11" runat="server" Text="<%$ Resources:LangResources, BooksLabel  %>" /></button>
    </div>
</asp:Content>

