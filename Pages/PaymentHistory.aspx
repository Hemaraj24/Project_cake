<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web.master" AutoEventWireup="true" CodeFile="PaymentHistory.aspx.cs" Inherits="Pages_PaymentHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="server">

    <link rel="stylesheet" runat="server" href="../Content/custom.css" />

    <div class="custom-highlight">
        <div class="pager messageText">
            <asp:Label ID="message" Text="Your Payment History" runat="server" />
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="table-responsive custom-border">
                    <center>
                        <asp:GridView ID="payment" DataSourceID="payments" runat="server" AutoGenerateColumns="false" CssClass="summaryTable">
                            <Columns>
                                <asp:TemplateField HeaderText="Card Type">
                                    <ItemTemplate>
                                        <asp:Label ID="cardType" runat="server"
                                            Text='<%# (bool)Eval("Debit") == true ? "Debit" : "Credit" %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Debit" HeaderText="Debit" ShowHeader="true" Visible="false" />
                                <asp:BoundField DataField="Credit" HeaderText="Credit" ShowHeader="true" Visible="false" />
                                <asp:BoundField DataField="Card_Number" HeaderText="Card Number" ShowHeader="true" Visible="true" />
                                <asp:BoundField DataField="Name_on_Card" HeaderText="Name On Card" ShowHeader="true" Visible="true" />
                                <asp:BoundField DataField="CVV_Number" HeaderText="CVV Number" ShowHeader="true" Visible="true" />
                                <asp:BoundField DataField="Payment_Date" HeaderText="Payment Date" ShowHeader="true" Visible="true" DataFormatString="{0:yyyy-MM-dd}" />
                                <asp:BoundField DataField="Expiry_date" HeaderText="Expiry Date" ShowHeader="true" Visible="true" DataFormatString="{0:yyyy-MM-dd}" />
                            </Columns>
                        </asp:GridView>
                        <asp:AccessDataSource ID="payments" DataFile="~/App_Data/DemoDb.mdb" runat="server"
                            SelectCommand="SELECT Debit,Credit,Card_Number,Name_on_Card,CVV_Number,Expiry_date,Payment_Date FROM SenderPaymentDetails" />
                        </center>
                    <br />
                    <br />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
