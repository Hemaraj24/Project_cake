<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web.master" AutoEventWireup="true" CodeFile="OrderSummary.aspx.cs" Inherits="Pages_OrderSummary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="Server">

    <link id="Link1" rel="stylesheet" runat="server" href="../Content/custom.css" />

    <div class="custom-highlight">
        <div class="pager messageText">
            <asp:Label ID="message" Text="Order Details" runat="server" />
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="table-responsive custom-border">
                    <center>
                        <asp:GridView ID="orders" DataSourceID="srcStudents" AutoGenerateColumns="false" runat="server" CssClass="summaryTable"
                            OnRowCommand="orders_RowCommand" AllowSorting="true">
                            <Columns>
                                <asp:BoundField DataField="ID" HeaderText="ID" ShowHeader="true" Visible="false" />
                                <asp:BoundField DataField="PRODUCT" HeaderText="PRODUCT NAME" ShowHeader="true" Visible="true" />
                                <asp:BoundField DataField="PRICE" HeaderText="PRICE" ShowHeader="true" Visible="true" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton runat="server" CommandArgument='<%# Eval("ID") %>' CommandName="deleteRecord" Text="Remove" CssClass="custom-color" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <asp:AccessDataSource ID="srcStudents" DataFile="~/App_Data/DemoDb.mdb" runat="server"
                            SelectCommand="SELECT ID, NAME_OF_THE_PRODUCT as PRODUCT, PRICE_OF_THE_PRODUCT as PRICE FROM OrderDetails WHERE PAID = false" />
                    </center>
                    <br />
                    <center>
                        <asp:GridView ID="totals" DataSourceID="totalValue" runat="server" CssClass="summaryTable"></asp:GridView>
                        <asp:AccessDataSource ID="totalValue" DataFile="~/App_Data/DemoDb.mdb" runat="server"
                            SelectCommand="SELECT SUM(PRICE_OF_THE_PRODUCT) as TOTAL FROM OrderDetails WHERE PAID = false"></asp:AccessDataSource>
                    </center>
                    <br />
                    <center>
                        <asp:Button ID="Button1" runat="server" Text="Proceed" OnClick="Button1_Click" Font-Size="Medium" />
                </center>
                    <br />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
