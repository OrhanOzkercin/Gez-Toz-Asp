<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advertize.aspx.cs" Inherits="geztoz_asp.advertize" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css"
    />

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
					<a href="homepage.aspx"><img src="/aspects/images/logo.png" alt="logo" /></a>
				</div>
				<ul>
					<li>
						<a href="search.aspx"
							><i class="fas fa-search"></i>Yolculuk Ilanı Ara</a
						>
					</li>
					<li>
						<a href="#"><i class="fas fa-search-plus"></i>Yolculuk İlanı Ver</a>
					</li>
				</ul>
			</nav>
			<div class="content">
				<h1>Yol Arkadaşı Bul - Gez Toz</h1>
			</div>
		</header>

		<main>
			<!-- Welcome Section -->
			<div class="welcome flex-column">
				<div class="row">
					<div class="column">
						<%--<div class="column-1" style="display: none">
							<img src="/aspects/images/indir.png" alt="" />
						</div>
						<div class="d-vertical"></div>--%>
						<div class="column-2">
							<h3 ID="advertizeWelcomeLabel" runat="server"></h3>
							<div>
								<i class="fas fa-car-side"></i>
                                <p ID="advertizeWelcomeParagraph" runat="server">Yolculuk için güzel bir gün</p>
                            </div>
							
                            <asp:Button ID="advertizeLogin" runat="server"  Visible="False" CssClass="btn" Text="Giriş" OnClick="advertizeLogin_Click"/>
						</div>
						<div ID="advertizeDiveder" class="d-vertical" runat="server" Visible="False"></div>
						<div ID="advertizeButtons" class="column-3" runat="server" Visible="False">
                            <a href="#p3" class="btn">Yeni Bir İlan Ver</a>
                            <a href="profile.aspx" class="btn">Profiline Git</a>
                            <asp:Button ID="exit" runat="server" CssClass="btn" Text="Çıkış" OnClick="exit_Click" />
						</div>
					</div>
				</div>
			</div>

			<!-- Search Section -->
			<section id="p3" class="advertizes search-icons icons bg-light" runat="server" Visible="False">
				
                <div class="flex-items">
                    <div>
                        <i class="fas fa-map-marker fa-5x"></i>
                        <div>
                            <h3>Nereden Gidiyorsun?</h3>
                            <div>
                                <asp:TextBox  ID="from" runat="server" placeholder="İzmir"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div>
                        <i class="fas fa-location-arrow fa-5x"></i>
                        <div>
                            <h3>Nereye Gidiyorsun?</h3>
                            <div>
                                <asp:TextBox  ID="to" runat="server" placeholder="İstanbul"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div>
                        <i class="fas fa-users fa-5x"></i>
                        <div>
                            <h3>Kaç Kişi Gidiyorsun?</h3>
                            <div>
                                <asp:TextBox  ID="totalSeat" runat="server" TextMode="Number" placeholder="1"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div>
                        <i class="fas fa-calendar-day fa-5x"></i>
                        <div>
                            <h3>Ne Zaman Gidiyorsun?</h3>
                            <div>
                                <asp:TextBox  ID="date" runat="server" TextMode="Date" ></asp:TextBox>

                                <%--<input type="date" name="date" id="date" />--%>
                            </div>
                        </div>
                    </div>

					<div>
                        <i class="fas fa-clock fa-5x"></i>
                        <div>
                            <h3>Saat Kaçta Gidiyorsun?</h3>
                            <div>
                                <asp:TextBox  ID="time" runat="server" TextMode="Time" ></asp:TextBox>
                            </div>
                        </div>
                    </div>

                </div>

				<div>
                    <asp:Button ID="advertizeButton" runat="server"  CssClass="btn btn-secondary" Text="İlan Ver!" OnClick="advertizeButton_Click" />
                </div>
                <asp:Label ID="validateAdvertize" runat="server" Visible="False" Text="Label"></asp:Label>
			</section>
            

		</main>
		<footer id="footer" class="bg-dark advertize-footer">
			<p>Copyright &copy; 2020</p>
			<p>Made with ❤ by Orhan Özkerçin & Nur Sultan Bolel</p>
		</footer>
	</div>
        
    </form>
</body>
</html>
