<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web.master" AutoEventWireup="true" CodeFile="SenderPaymentDetails.aspx.cs" Inherits="Pages_SenderPaymentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="Server">
    <table style="width: 100%; min-height: 470px; border: 0px; background: url(../images/31.jpg); background-size: cover;">
        <tr>
            <td></td>
            <td style="text-align: left; color: maroon; font-style: oblique; font-size: x-large; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-weight: bold;"
                colspan="2">Sender Payment Details
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger; width: 40%;">Card Type:</td>
            <td style="text-align: center; width: 15%">
                <asp:RadioButtonList ID="cardType" runat="server" RepeatDirection="Horizontal" Font-Size="Larger" ForeColor="White">
                    <asp:ListItem Text="Debit"></asp:ListItem>
                    <asp:ListItem Text="Credit"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="checkType" runat="server" Display="Dynamic" ControlToValidate="cardType" ErrorMessage="Card Type is required"
                    Font-Size="Large" ForeColor="White"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger;">Card Number:</td>
            <td>
                <asp:TextBox ID="cardNumber" runat="server" MaxLength="25"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="checkCardNumber" runat="server" Display="Dynamic" ControlToValidate="cardNumber" ErrorMessage="Card Number is required"
                    Font-Size="Large" ForeColor="White"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="validateType" runat="server" Display="Dynamic" ControlToValidate="cardNumber" ErrorMessage="Please Enter a Number"
                    ValidationExpression="^[0-9]*$" Font-Size="Large" ForeColor="White"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger">Name on Card:</td>
            <td>
                <asp:TextBox ID="userName" runat="server" TextMode="Phone"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="checkUser" runat="server" Display="Dynamic" ControlToValidate="userName" ErrorMessage="Name on Card is required"
                    Font-Size="Large" ForeColor="White"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="validateUser" runat="server" Display="Dynamic" ControlToValidate="userName" ErrorMessage="Please Enter a Text"
                    ValidationExpression="^[a-zA-Z]*$" Font-Size="Large" ForeColor="White"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger">CVV Number:</td>
            <td>
                <asp:TextBox ID="cvv" runat="server" MaxLength="10"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="checkCvv" runat="server" Display="Dynamic" ControlToValidate="cvv" ErrorMessage="CVV is required"
                    Font-Size="Large" ForeColor="White"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="validateCvv" runat="server" Display="Dynamic" ControlToValidate="cvv" ErrorMessage="Please Enter a Number"
                    ValidationExpression="^[0-9]*$" Font-Size="Large" ForeColor="White"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger">Expiry Date:</td>
            <td>
                <asp:DropDownList ID="month" runat="server"></asp:DropDownList>
                <asp:DropDownList ID="year" runat="server"></asp:DropDownList>
            </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td style="text-align: left;" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Pay Now" text-align="center" OnClick="Button_Click" Font-Size="Medium" />
            </td>
        </tr>
    </table>
</asp:Content>
