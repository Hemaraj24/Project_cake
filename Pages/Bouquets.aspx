<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web.master" AutoEventWireup="true" CodeFile="Bouquets.aspx.cs" Inherits="Pages_Bouquets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="Server">

    <div id="Div1">
        <div class="row" style="text-align: center;">
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/17.jpg" style="max-width: 100%; height: 200px;" alt="cake1" /><br />
                Pink Roses<br />
                US $35.00<br />
                <asp:Button ID="Button1" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="35.00,Pink Roses" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/18.jpg" style="max-width: 100%; height: 200px;" alt="cake1" /><br />
                Yellow Roses<br />
                US $35.00<br />
                <asp:Button ID="Button2" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="35.00,Yellow Roses" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/19.jpg" style="max-width: 100%; height: 200px;" alt="cake1" /><br />
                Dry Flowers<br />
                US $30.00<br />
                <asp:Button ID="Button3" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="30.00,Dry Flowers" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/20.jpg" style="max-width: 100%; height: 200px;" alt="cake1" /><br />
                Pink Flowers<br />
                US $30.00<br />
                <asp:Button ID="Button4" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="30.00,Pink Flowers" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/21.jpg" style="max-width: 100%; height: 200px;" alt="cake1" /><br />
                Yellow & Orange Roses<br />
                US $40.00<br />
                <asp:Button ID="Button5" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="40.00,Yellow & Orange Roses" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/22.jpg" style="max-width: 100%; height: 200px;" alt="cake1" /><br />
                Red Roses<br />
                US $40.00<br />
                <asp:Button ID="Button6" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="40.00,Red Roses" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/23.jpg" style="max-width: 100%; height: 200px;" alt="cake1" /><br />
                Mixed Flowers<br />
                US $50.00<br />
                <asp:Button ID="Button7" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="50.00,Mixed Flowers" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/24.jpg" style="max-width: 100%; height: 200px;" alt="cake1" /><br />
                Red Roses with Ferns<br />
                US $40.00<br />
                <asp:Button ID="Button8" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="40.00,Red Roses with Ferns" />
                <br />
                <br />
            </div>
        </div>
    </div>
</asp:Content>
