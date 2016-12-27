<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web.master" AutoEventWireup="true" CodeFile="CakesByTheme.aspx.cs" Inherits="Pages_CakesByTheme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="server">

    <div id="Div1">
        <div class="row" style="text-align: center;">
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/9.jpg" style="max-width: 100%; height: 200px;" alt="cake1" /><br />
                1KG Happy Birthday Cake<br />
                US $35.00<br />
                <asp:Button ID="Button1" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="35.00,1KG Happy Birthday Cake" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/10.jpg" style="max-width: 100%; height: 200px;" alt="cake2" /><br />
                1KG Happy Mothersday Cake<br />
                US $35.00<br />
                <asp:Button ID="Button2" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="35.00,1KG Happy Mothersday Cake" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/11.jpg" style="max-width: 100%; height: 200px;" alt="cake3" /><br />
                3KG Wedding Cake<br />
                US $100.00<br />
                <asp:Button ID="Button3" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="100.00,3KG Wedding Cake" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/12.jpg" style="max-width: 100%; height: 200px;" alt="cake4" /><br />
                1KG Goodluck Cake<br />
                US $35.00<br />
                <asp:Button ID="Button4" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="35.00,1KG Goodluck Cake" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/13.jpg" style="max-width: 100%; height: 200px;" alt="cake5" /><br />
                3KG Happy Anniversary Cake<br />
                US $120.00<br />
                <asp:Button ID="Button5" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="120.00,3KG Happy Anniversary Cake" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/14.jpg" style="max-width: 100%; height: 200px;" alt="cake6" /><br />
                3KG Happy Birthday Cake<br />
                US $120.00<br />
                <asp:Button ID="Button6" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="120.00,3KG Happy Birthday Cake" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/15.jpg" style="max-width: 100%; height: 200px;" alt="cake7" /><br />
                5KG Happy Anniversary Cake<br />
                US $200.00<br />
                <asp:Button ID="Button7" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="200.00,5KG Happy Anniversary Cake" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/16.jpg" style="max-width: 100%; height: 200px;" alt="cake8" /><br />
                1KG Happy Birthday Cake<br />
                US $40.00<br />
                <asp:Button ID="Button8" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="40.00,1KG Happy Birthday Cake" />
                <br />
                <br />
            </div>
        </div>
    </div>
</asp:Content>
