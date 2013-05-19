<%@ Page Title="" Language="C#" MasterPageFile="~/anything.master" AutoEventWireup="true" CodeFile="EditProfile.aspx.cs" Inherits="EditProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BannerPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CartInfoPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="SildeShowContentPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentAreaPlaceHolder" Runat="Server">
    <div class="span9 well">
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
            <label class="control-label" for="inputPassword"><asp:Literal ID="Literal4" runat="server" Text="<%$ Resources:LangResources, PasswordText  %>" /></label>
            <div class="controls">
                <asp:TextBox ID="inputPassword" runat="server" placeholder="<%$ Resources:LangResources, PasswordText  %>" TextMode="Password" ></asp:TextBox>
                <ajaxToolkit:PasswordStrength ID="PS" runat="server"
                            TargetControlID="inputPassword"
                            DisplayPosition="RightSide"
                            StrengthIndicatorType="Text"
                            PreferredPasswordLength="8"
                            PrefixText="Strength:"
                            TextCssClass="label"
                            MinimumNumericCharacters="1"
                            MinimumSymbolCharacters="1"
                            RequiresUpperAndLowerCaseCharacters="false"
                            TextStrengthDescriptions="Very Poor;Weak;Average;Strong;Excellent"
                            TextStrengthDescriptionStyles="label-error;label-important;label-warning;label-success;label-info"
                            CalculationWeightings="50;15;15;20" />
                <asp:RequiredFieldValidator validationgroup="RegistrationForm" CssClass="text-error" ID="RequiredFieldValidatorPassword" runat="server"
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
                <asp:TextBox ID="inputPassword2" runat="server" placeholder="<%$ Resources:LangResources, ConfirmPasswordText  %>" TextMode="Password" ></asp:TextBox>
                <asp:RequiredFieldValidator validationgroup="RegistrationForm" CssClass="text-error" ID="RequiredFieldValidatorPassword2" runat="server"
                    ControlToValidate="inputPassword2" ErrorMessage="Required field cannot be left blank."
                    Display="Dynamic">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator validationgroup="RegistrationForm" ID="CompareValidatorPassword" CssClass="text-error" runat="server"
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
                <asp:Button ID="Button1" validationgroup="RegistrationForm" CssClass="btn btn-link" runat="server" Text="Update" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
     </div>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="RightPanelPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="FooterImports" Runat="Server">
</asp:Content>

