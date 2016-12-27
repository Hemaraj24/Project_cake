<%@ Page Title="Home" Language="C#" MasterPageFile="~/MasterPages/Web.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Pages_Home" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <asp:Panel ID="pnlAdvertisment" runat="server">
        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel" style="width: 100%; margin: 0 auto;">
            <!-- Indicators -->
            <%--        <ol class='carousel-indicators'>
                <li data-target='#carousel-example-generic' data-slide-to='0' class='active'></li>
                <li data-target='#carousel-example-generic' data-slide-to='1'></li>
                <li data-target='#carousel-example-generic' data-slide-to='2'></li>
                <li data-target='#carousel-example-generic' data-slide-to='3'></li>
                <li data-target='#carousel-example-generic' data-slide-to='4'></li>
            </ol>--%>
            <asp:Literal ID="ltlCarouselIndicators" runat="server" />

            <!-- Wrapper for slides -->
            <%--            <div class='carousel-inner' role='listbox' style='width: 80%; margin: 0 auto;'>
                <div class='item active'>
                    <img src='../Images/AspNet.jpg' style='width: 100%;' alt='Asp.Net' class='img-responsive' />
                    <div class='carousel-caption'>
                        Microsoft Asp.Net
                    </div>
                </div>
                <div class='item'>
                    <img src='../Images/Bootstrap.bmp' alt='Bootstrap' class='img-responsive' />
                    <div class='carousel-caption'>
                        Twitter Bootstrap 
                    </div>
                </div>
                <div class='item'>
                    <img src='../Images/CSharp.bmp' alt='C Sharp' class='img-responsive' />
                    <div class='carousel-caption'>
                        C Sharp Language
                    </div>
                </div>
                <div class='item'>
                    <img src='../Images/MsAccess.bmp' alt='Access' class='img-responsive' />
                    <div class='carousel-caption'>
                        Microsoft Access
                    </div>
                </div>
                <div class='item'>
                    <img src='../Images/VisualStudio.bmp' alt='Visual Studio' class='img-responsive' />
                    <div class='carousel-caption'>
                        Microsoft Visual Studio
                    </div>
                </div>
            </div>--%>
            <asp:Literal ID="ltlCarouselItems" runat="server" />

            <!-- Controls -->
            <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
        <br />
    </asp:Panel>
</asp:Content>
