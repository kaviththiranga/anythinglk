<%@ Page Title="" Language="C#" MasterPageFile="~/anything.master" AutoEventWireup="true" CodeFile="Terms.aspx.cs" Inherits="Terms" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BannerPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CartInfoPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SildeShowContentPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentAreaPlaceHolder" Runat="Server">
    <div><asp:Literal ID="Literal1" runat="server" Text="<%$ Resources:LangResources, termscondtions  %>" /></div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="RightPanelPlaceHolder" Runat="Server">
    <div class="btn-group btn-group-vertical">
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-list"></i> <asp:Literal ID="Literal2" runat="server" Text="<%$ Resources:LangResources, DailyDealsLabel  %>" /></button>
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-shopping-cart"></i> <asp:Literal ID="Literal3" runat="server" Text="<%$ Resources:LangResources, StoreLabel  %>" /></button>
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-calendar"></i> <asp:Literal ID="Literal4" runat="server" Text="<%$ Resources:LangResources, EventsLabel  %>" /></button>
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-plane"></i> <asp:Literal ID="Literal5" runat="server" Text="<%$ Resources:LangResources, TravelLabel  %>" /></button>
        <button class="btn" style="width:150px;text-align:left;background:lightgray;"><i class="icon-book"></i> <asp:Literal ID="Literal6" runat="server" Text="<%$ Resources:LangResources, BooksLabel  %>" /></button>
    </div>
</asp:Content>

