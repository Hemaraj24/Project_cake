<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web.master" AutoEventWireup="true" CodeFile="CakesByFlavor.aspx.cs" Inherits="Pages_CakesByFlavor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="Server">

    <div id="Div1">
        <div class="row" style="text-align: center;">
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/1.jpg" style="max-width: 100%; height: 200px;" alt="cake1" /><br />
                2KG Black Forest<br />
                US $50.00<br />
                <asp:Button ID="Button9" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="50.00,2KG Black Forest" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/2.jpg" style="max-width: 100%; height: 200px;" alt="cake2" /><br />
                2KG Strawberry<br />
                US $50.00<br />
                <asp:Button ID="Button10" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="50.00,2KG Strawberry" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/3.jpg" style="max-width: 100%; height: 200px;" alt="cake3" /><br />
                1KG Truffle<br />
                US $25.00<br />
                <asp:Button ID="Button11" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="25.00,1KG Truffle" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/4.jpg" style="max-width: 100%; height: 200px;" alt="cake4" /><br />
                1KG Mixed fruit<br />
                US $25.00<br />
                <asp:Button ID="Button12" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="25.00,1KG Mixed fruit" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/5.jpg" style="max-width: 100%; height: 200px;" alt="cake5" /><br />
                1.5KG Pineapple<br />
                US $35.00<br />
                <asp:Button ID="Button13" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="35.00,1.5KG Pineapple" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/6.jpg" style="max-width: 100%; height: 200px;" alt="cake6" /><br />
                1KG Eggless blackForest<br />
                US $35.00<br />
                <asp:Button ID="Button14" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="35.00,1KG Eggless blackForest" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/71.jpg" style="max-width: 100%; height: 200px;" alt="cake7" /><br />
                1KG Strawberry<br />
                US $30.00<br />
                <asp:Button ID="Button15" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="30.00,1KG Strawberry" />
                <br />
                <br />
            </div>
            <div class='col-xs-12 col-sm-12 col-md-6 col-lg-3'>
                <img src="../images/8.jpg" style="max-width: 100%; height: 200px;" alt="cake8" /><br />
                1KG Eggless ButterScotch<br />
                US $35.00<br />
                <asp:Button ID="Button16" runat="server" Text="Add To Cart" OnClick="Button_Click" CommandArgument="35.00,1KG Eggless ButterScotch" />
                <br />
                <br />
            </div>
        </div>
    </div>
</asp:Content>
