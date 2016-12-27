<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web.master" AutoEventWireup="true" CodeFile="SenderDetails.aspx.cs" Inherits="Pages_SenderDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="Server">
    <table style="width: 100%; min-height: 470px; border: 0px; background: url(../images/31.jpg); background-size: cover;">
        <tr>
            <td></td>
            <td style="text-align: left; color: maroon; font-style: oblique; font-size: x-large; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-weight: bold;"
                colspan="2">Sender Details
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger; width: 45%;">E-mail Id:</td>
            <td style="width: 15%;">
                <asp:TextBox ID="emailId" runat="server" TextMode="Email"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="checkEmail" runat="server" Display="Dynamic" ControlToValidate="emailId" ErrorMessage="E-mail Id is required."
                    ForeColor="White" Font-Size="Large"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; color: white; font-size: larger;">Full Name:</td>
            <td>
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
            <td style="text-align: right; color: white; font-size: larger">Mobile No.:</td>
            <td>
                <asp:TextBox ID="phone" runat="server" TextMode="Phone"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="checkPhone" runat="server" Display="Dynamic" ControlToValidate="phone" ErrorMessage="Mobile Number is required."
                    ForeColor="White" Font-Size="Large"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td style="text-align: left;" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Proceed" OnClick="Button_Click" Font-Size="Medium" />
            </td>
        </tr>
    </table>
</asp:Content>
