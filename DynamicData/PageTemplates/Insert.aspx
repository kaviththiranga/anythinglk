<%@ Page Language="C#" MasterPageFile="~/Administrator/anythingadmin.master" CodeFile="Insert.aspx.cs" Inherits="Insert" %>

<asp:Content ID="headContent" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DynamicDataManager ID="DynamicDataManager1" runat="server" AutoLoadForeignKeys="true">
        <DataControls>
            <asp:DataControlReference ControlID="FormView1" />
        </DataControls>
    </asp:DynamicDataManager>

    <div class="widget-head orange"><h3>Add new  <%= table.DisplayName %></h3></div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="widget-container">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="true"
                    HeaderText="List of validation errors" CssClass="DDValidator" />
                <asp:DynamicValidator runat="server" ID="DetailsViewValidator" ControlToValidate="FormView1" Display="None" CssClass="DDValidator" />

                <asp:FormView runat="server" ID="FormView1" DataSourceID="DetailsDataSource" DefaultMode="Insert"
                    OnItemCommand="FormView1_ItemCommand" OnItemInserted="FormView1_ItemInserted" RenderOuterTable="false">
                    <InsertItemTemplate>
                        <table id="detailsTable" class="table table-striped" >
                            <asp:DynamicEntity runat="server" Mode="Insert" />
                            
                            <tr class="td">
                                <td colspan="2">
                                    <asp:LinkButton CssClass="btn btn-sucess" runat="server" CommandName="Insert" Text="Insert" />
                                    <asp:LinkButton CssClass="btn btn-warning" runat="server" CommandName="Cancel" Text="Cancel" CausesValidation="false" />
                                </td>
                            </tr>
                        </table>
                    </InsertItemTemplate>
                </asp:FormView>

                <asp:LinqDataSource ID="DetailsDataSource" runat="server" EnableInsert="true" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

