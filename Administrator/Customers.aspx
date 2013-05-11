<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/anythingadmin.master" AutoEventWireup="true" CodeFile="Customers.aspx.cs" Inherits="Administrator_Customers" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentWrapper" Runat="Server">
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataClassesDataContext" EntityTypeName="" OrderBy="FirstName, LastName" TableName="Users" EnableDelete="True" EnableInsert="True" EnableUpdate="True" Where="UserID == @UserID">
       
    </asp:LinqDataSource>
    
</asp:Content>




