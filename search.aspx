﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="geztoz_asp.search" %>

<%@ Import Namespace="System.Web.Script.Serialization" %>
<%@ Import Namespace="geztoz_asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css" />

    <link rel="stylesheet" href="css/utilities.css" />
    <link rel="stylesheet" href="css/style.css" />
    <link rel="stylesheet" href="css/responsive.css" />
    <title>GezToz | Hayatı Yakala</title>



</head>
<body>
    <form id="form1" runat="server">
    <asp:Button ID="Button_1" runat="server" CssClass="btn" Text="Bu Yolculuğa Katıl" OnClick="btnJoinTravel" Visible="False" />
    <asp:Button ID="Button_2" runat="server" CssClass="btn" Text="Bu Yolculuğa Katıl" OnClick="btnJoinTravel" Visible="False" />
    <asp:Button ID="Button_3" runat="server" CssClass="btn" Text="Bu Yolculuğa Katıl" OnClick="btnJoinTravel" Visible="False" />
    <asp:Button ID="Button_4" runat="server" CssClass="btn" Text="Bu Yolculuğa Katıl" OnClick="btnJoinTravel" Visible="False" />
    <asp:Button ID="Button_5" runat="server" CssClass="btn" Text="Bu Yolculuğa Katıl" OnClick="btnJoinTravel" Visible="False" />
        <div class="body ">
            <header class="hero search">
                <nav class="navbar">
                    <div class="logo">
                        <a href="homepage.aspx">
                            <img src="/aspects/images/logo.png" alt="logo" /></a>
                    </div>
                    <ul>
                        <li>
                            <a href="search.aspx"><i class="fas fa-search"></i>Yolculuk Ilanı Ara</a>
                        </li>
                        <li>
                            <a href="advertize.aspx"><i class="fas fa-search-plus"></i>Yolculuk İlanı Ver</a>
                        </li>
                    </ul>
                </nav>

                <div class="content">
                    <h1>Keşfet Dünyayı - Gez Toz</h1>
                </div>
            </header>

            <main class="search-main">
                <!-- Search Section -->
                <section class="search-icons icons bg-light">
                    <div class="flex-items">
                        <div>
                            <i class="fas fa-map-marker fa-5x"></i>
                            <div>
                                <h3>Nereden Gidiyorsun?</h3>
                                <div>
                                    <asp:TextBox ID="from" runat="server" placeholder="İzmir"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div>
                            <i class="fas fa-location-arrow fa-5x"></i>
                            <div>
                                <h3>Nereye Gidiyorsun?</h3>
                                <div>
                                    <asp:TextBox ID="to" runat="server" placeholder="İstanbul"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div>
                            <i class="fas fa-users fa-5x"></i>
                            <div>
                                <h3>Kaç Kişi Gidiyorsun?</h3>
                                <div>

                                    <asp:TextBox ID="wantedSeat" runat="server" TextMode="Number" placeholder="1"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div>
                            <i class="fas fa-calendar-day fa-5x"></i>
                            <div>
                                <h3>Ne Zaman Gidiyorsun?</h3>
                                <div>
                                    <asp:TextBox ID="travelDate" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div>
                        <asp:Button ID="searchButton" runat="server" CssClass="btn btn-secondary" Text="Ara" OnClick="searchButton_Click" />
                    </div>
                    <asp:Label ID="validateSearch" runat="server" Visible="False" Text="Label"></asp:Label>
                </section>
                <!-- Road List -->
                <asp:Panel ID="filteredTravelsPanel" runat="server">
                </asp:Panel>
                <section id="availableTravel" runat="server" Visible="False" class="road-list flex-columns">
                    <div class="row">
                        <div class="column">
                            <div class="column-1">
                                <h4>Şoför Bilgileri</h4>
                                <div class="content-container">
                                    <div class="contents">
                                        <div class="content-items">
                                            <i class="far fa-user"></i>
                                            <h3>İsim:</h3>
                                            <p id="driverName" runat="server">Orhan</p>
                                        </div>
                                        <div class="content-items">
                                            <i class="fas fa-user"></i>
                                            <h3>Soyisim:</h3>
                                            <p id="driverSurname" runat="server">Özkerçin</p>
                                        </div>

                                        <div class="content-items">
                                            <i class="fas fa-calendar-alt"></i>
                                            <h3>Yaş:</h3>
                                            <p id="driverAge" runat="server">22</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="column">
                            <div class="column-2">
                                <h4>Yolculuk Bilgileri</h4>
                                <div class="content-container">
                                    <div class="contents">
                                        <div class="content-items">
                                            <i class="fas fa-map-marker"></i>
                                            <h3>Nereden:</h3>
                                            <p id="fromDestination" runat="server">İzmir</p>
                                        </div>

                                        <div class="content-items">
                                            <i class="fas fa-location-arrow"></i>
                                            <h3>Nereye:</h3>
                                            <p id="toDestination" runat="server">İstanbul</p>
                                        </div>

                                        <div class="content-items">
                                            <i class="fas fa-calendar-day"></i>
                                            <h3>Ne zaman:</h3>
                                            <p id="date" runat="server">23 Haziran</p>
                                        </div>

                                        <div class="last-item">
                                            <div class="content-items">
                                                <i class="fas fa-user"></i>
                                                <h3>Toplam Kişi:</h3>
                                                <p id="totalSeat" runat="server">3</p>
                                            </div>
                                            <div class="content-items">
                                                <i class="far fa-user"></i>
                                                <h3>Kalan Kişi:</h3>
                                                <p id="availableSeat" runat="server">2</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="column">
                            <div class="column-3">
                                <h4>Yolculuk Seni Bekler</h4>
                                <div class="content-container">
                                    <div class="contents">
                                        <button class="btn">Bu yolculuğa Katıl</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </main>
            <footer id="footer"  class="bg-dark search-footer">
                <p>Copyright &copy; 2020</p>
                <p>Made with ❤ by Orhan Özkerçin & Nur Sultan Bolel</p>
            </footer>
        </div>
    </form>


</body>
</html>
