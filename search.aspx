<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="geztoz_asp.search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css" />

    <link rel="stylesheet" href="css/utilities.css" />
    <link rel="stylesheet" href="css/style.css" />
    <link rel="stylesheet" href="css/responsive.css" />
    <title>GezToz | Hayatı Yakala</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="body">
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

            <main>
                <!-- Search Section -->
                <section class="search-icons icons bg-light">
                    <div class="flex-items">
                        <div>
                            <i class="fas fa-map-marker fa-5x"></i>
                            <div>
                                <h3>Nereden Gidiyorsun?</h3>
                                <div>
                                    <asp:TextBox ID="from" runat="server" placeholder="İzmir"></asp:TextBox>
                                    <%--<input type="text" name="from" id="from" placeholder="İZMİR" />--%>
                                </div>
                            </div>
                        </div>
                        <div>
                            <i class="fas fa-location-arrow fa-5x"></i>
                            <div>
                                <h3>Nereye Gidiyorsun?</h3>
                                <div>
                                    <asp:TextBox ID="to" runat="server" placeholder="İstanbul"></asp:TextBox>

                                    <%--<input type="text" name="to" id="to" placeholder="İSTANBUL" />--%>
                                </div>
                            </div>
                        </div>
                        <div>
                            <i class="fas fa-users fa-5x"></i>
                            <div>
                                <h3>Kaç Kişi Gidiyorsun?</h3>
                                <div>

                                    <asp:TextBox ID="wantedSeat" runat="server" TextMode="Number" placeholder="1"></asp:TextBox>

                                    <%--<input
									type="number"
									name="people"
									id="people"
									placeholder="1"
								/>--%>
                                </div>
                            </div>
                        </div>
                        <div>
                            <i class="fas fa-calendar-day fa-5x"></i>
                            <div>
                                <h3>Ne Zaman Gidiyorsun?</h3>
                                <div>
                                    <asp:TextBox ID="travelDate" runat="server" TextMode="Date"></asp:TextBox>

                                    <%--<input type="date" name="date" id="date" />--%>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div>
                        <asp:Button ID="searchButton" runat="server" CssClass="btn btn-secondary" Text="Ara" OnClick="searchButton_Click" />
                        <%--<button class="btn btn-secondary">Ara</button>--%>
                    </div>
                </section>

                <!-- Road List -->
                <section class="road-list flex-columns">
                    <div class="row">
                        <div class="column">
                            <div class="column-1">
                                <h4>Şoför Bilgileri</h4>
                                <div class="content-container">
                                    <div class="contents">
                                        <div class="content-items">
                                            <i class="far fa-user"></i>
                                            <h3>İsim:</h3>
                                            <p>Orhan</p>
                                        </div>
                                        <div class="content-items">
                                            <i class="fas fa-user"></i>
                                            <h3>Soyisim:</h3>
                                            <p>Özkerçin</p>
                                        </div>
                                        <div class="content-items">
                                            <i class="fas fa-venus-mars"></i>
                                            <h3>Cinsiyet:</h3>
                                            <p>Erkek</p>
                                        </div>
                                        <div class="content-items">
                                            <i class="fas fa-calendar-alt"></i>
                                            <h3>Yaş:</h3>
                                            <p>22</p>
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
                                            <p>İzmir</p>
                                        </div>

                                        <div class="content-items">
                                            <i class="fas fa-location-arrow"></i>
                                            <h3>Nereye:</h3>
                                            <p>İstanbul</p>
                                        </div>

                                        <div class="content-items">
                                            <i class="fas fa-calendar-day"></i>
                                            <h3>Ne zaman:</h3>
                                            <p>23 Haziran</p>
                                        </div>

                                        <div class="last-item">
                                            <div class="content-items">
                                                <i class="fas fa-user"></i>
                                                <h3>Toplam Kişi:</h3>
                                                <p>3</p>
                                            </div>
                                            <div class="content-items">
                                                <i class="far fa-user"></i>
                                                <h3>Kalan Kişi:</h3>
                                                <p>2</p>
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
                   <%-- <div class="row">
                        <div class="column">
                            <div class="column-1">
                                <h4>Şoför Bilgileri</h4>
                                <div class="content-container">
                                    <div class="contents">
                                        <div class="content-items">
                                            <i class="far fa-user"></i>
                                            <h3>İsim:</h3>
                                            <p>Orhan</p>
                                        </div>
                                        <div class="content-items">
                                            <i class="fas fa-user"></i>
                                            <h3>Soyisim:</h3>
                                            <p>Özkerçin</p>
                                        </div>
                                        <div class="content-items">
                                            <i class="fas fa-venus-mars"></i>
                                            <h3>Cinsiyet:</h3>
                                            <p>Erkek</p>
                                        </div>
                                        <div class="content-items">
                                            <i class="fas fa-calendar-alt"></i>
                                            <h3>Yaş:</h3>
                                            <p>22</p>
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
                                            <p>İzmir</p>
                                        </div>

                                        <div class="content-items">
                                            <i class="fas fa-location-arrow"></i>
                                            <h3>Nereye:</h3>
                                            <p>İstanbul</p>
                                        </div>

                                        <div class="content-items">
                                            <i class="fas fa-calendar-day"></i>
                                            <h3>Ne zaman:</h3>
                                            <p>23 Haziran</p>
                                        </div>

                                        <div class="last-item">
                                            <div class="content-items">
                                                <i class="fas fa-user"></i>
                                                <h3>Toplam Kişi:</h3>
                                                <p>3</p>
                                            </div>
                                            <div class="content-items">
                                                <i class="far fa-user"></i>
                                                <h3>Kalan Kişi:</h3>
                                                <p>2</p>
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
                    </div>--%>
                    <%--<div class="row">
                        <div class="column">
                            <div class="column-1">
                                <h4>Şoför Bilgileri</h4>
                                <div class="content-container">
                                    <div class="contents">
                                        <div class="content-items">
                                            <i class="far fa-user"></i>
                                            <h3>İsim:</h3>
                                            <p>Orhan</p>
                                        </div>
                                        <div class="content-items">
                                            <i class="fas fa-user"></i>
                                            <h3>Soyisim:</h3>
                                            <p>Özkerçin</p>
                                        </div>
                                        <div class="content-items">
                                            <i class="fas fa-venus-mars"></i>
                                            <h3>Cinsiyet:</h3>
                                            <p>Erkek</p>
                                        </div>
                                        <div class="content-items">
                                            <i class="fas fa-calendar-alt"></i>
                                            <h3>Yaş:</h3>
                                            <p>22</p>
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
                                            <p>İzmir</p>
                                        </div>

                                        <div class="content-items">
                                            <i class="fas fa-location-arrow"></i>
                                            <h3>Nereye:</h3>
                                            <p>İstanbul</p>
                                        </div>

                                        <div class="content-items">
                                            <i class="fas fa-calendar-day"></i>
                                            <h3>Ne zaman:</h3>
                                            <p>23 Haziran</p>
                                        </div>

                                        <div class="last-item">
                                            <div class="content-items">
                                                <i class="fas fa-user"></i>
                                                <h3>Toplam Kişi:</h3>
                                                <p>3</p>
                                            </div>
                                            <div class="content-items">
                                                <i class="far fa-user"></i>
                                                <h3>Kalan Kişi:</h3>
                                                <p>2</p>
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
                    </div>--%>
                </section>
            </main>
            <footer id="footer" class="bg-dark">
                <p>Copyright &copy; 2020</p>
                <p>Made with ❤ by Orhan Özkerçin & Nur Sultan Bolel</p>
            </footer>
        </div>
    </form>

    <script type="text/javascript" src="js/search.js"></script>
</body>
</html>
