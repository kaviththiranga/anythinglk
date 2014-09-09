<%@ Page Title="" Language="C#" MasterPageFile="~/anything.master" AutoEventWireup="true" CodeFile="CatView.aspx.cs" Inherits="CatView" %>

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
    <div class="span11 well">
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataClassesDataContext" EntityTypeName="" OrderBy="PlacedOn" TableName="Deals" Where="CatID == @CatID">
            <WhereParameters>
                <asp:QueryStringParameter DefaultValue="1" Name="CatID" QueryStringField="catID" Type="Int32" />
            </WhereParameters>
        </asp:LinqDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="LinqDataSource1">
            <HeaderTemplate>
                <div id="dailydeals" class="span10 label label-info" style="margin-bottom:20px;">
                    <div class="label label-info"><h5><i class="icon-list"></i> <asp:Literal ID="Literal1" runat="server" Text="<%$ Resources:LangResources, DailyDealsLabel  %>" /></h5></div>
                </div>
            </HeaderTemplate>
            <ItemTemplate>
                <div class="span2 well" style="text-align:center;min-height:320px;">                    
                    <div style="position:relative;right:-15px;top:25px; padding-top:0; width:40px;height:44px; color: #FFFFFF; float: right;font-size: 14px; font-weight: bold; line-height: 25px; margin-top: -10px;text-align: center;background:url(images/discount.png) no-repeat scroll 0 0 transparent;">
                        <div> <%# Eval("DiscountRate") %>% </div>
                    </div>
                    <div class="yoxview">
                         <a href="<%# Eval("ImageURL") %>" class="thumbnail">
                            <img class="lazy" src="img/grey.gif" data-original="<%# Eval("ImageURL") %>" title="<%# Eval("Title") %>" alt="<%# Eval("Title") %>">
                        </a>
                     &nbsp;</div>
                    <p><%# Eval("Title").ToString().Length <= 80 ? Eval("Title") : Eval("Title").ToString().Substring(0,80) %>...</p>
                        
                    <div style="margin: 5px 0 5px 0;">
                        <span class="label label-info" style="width:120px;font-size:large;padding:5px;">Rs. <%# Eval("DiscountedPrice") %>/=</span>
                    </div>
                    <div style="margin: 5px 0 5px 0;">
                        <span class="label label-warning" style="width:120px; text-decoration:line-through;font-size:large;padding:5px;">Rs. <%# Eval("Value") %>/=</span>
                    </div>
                    <a href="viewDeal.aspx?dealID=<%# Eval("DealID") %>" class="btn btn-success">View Deal <i class="icon-arrow"></i></a>
                    
                </div>
                
            </ItemTemplate>    
            <FooterTemplate>
                

            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="RightPanelPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="FooterImports" Runat="Server">
</asp:Content>

