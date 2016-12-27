<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web.master" AutoEventWireup="true" CodeFile="ReceiverDetails.aspx.cs" Inherits="Pages_ReceiverDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="Server">
    <table style="width: 100%; min-height: 470px; border: 0px; background: url(../images/31.jpg); background-size: cover;">
        <tr>
            <td style="text-align: right;"></td>
            <td style="color: maroon; font-style: oblique; font-size: x-large; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-weight: bold;"
                colspan="2">Receiver Details
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger; width: 45%;">Receiver Full Name:</td>
            <td style="width: 15%;">
                <asp:TextBox ID="fullName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="checkName" runat="server" Display="Dynamic" ControlToValidate="fullName" ErrorMessage="Name is required."
                    ForeColor="White" Font-Size="Large"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="validateUser" runat="server" Display="Dynamic" ControlToValidate="fullName" ErrorMessage="Please Enter a Text"
                    ValidationExpression="^[a-zA-Z]*$" Font-Size="Large" ForeColor="White"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger">Delivery Address:</td>
            <td>
                <asp:TextBox ID="address" runat="server" TextMode="MultiLine" Rows="4" Columns="21"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="checkAddress" runat="server" Display="Dynamic" ControlToValidate="address" ErrorMessage="Address is required."
                    ForeColor="White" Font-Size="Large"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger">Delivery Date:</td>
            <td>
                <asp:TextBox ID="deliveryDate" runat="server" TextMode="Date" Width="164px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="checkDate" runat="server" Display="Dynamic" ControlToValidate="deliveryDate" ErrorMessage="Date is required."
                    ForeColor="White" Font-Size="Large"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger">Message on Cake:</td>
            <td colspan="2">
                <asp:TextBox ID="message" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger">Delivery City:</td>
            <td>
                <asp:TextBox ID="city" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="checkCity" runat="server" Display="Dynamic" ControlToValidate="city" ErrorMessage="City is required."
                    ForeColor="White" Font-Size="Large"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger">Receiver Mobile No.:</td>
            <td>
                <asp:TextBox ID="phone" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="checkPhone" runat="server" Display="Dynamic" ControlToValidate="phone" ErrorMessage="Mobile Number is required."
                    ForeColor="White" Font-Size="Large"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Proceed" OnClick="Button_Click" Font-Size="Medium" />
            </td>
        </tr>
    </table>
</asp:Content>
