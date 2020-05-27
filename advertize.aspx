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
       	<body>
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
							<h3>Hoş Geldin Orhan</h3>
							<div>
								<i class="fas fa-car-side"></i>
								<p>Yolculuk için güzel bir gün</p>
							</div>
						</div>
						<div class="d-vertical"></div>
						<div class="column-3">
							
                            <asp:Button ID="newAdv" runat="server" CssClass="btn" Text="Yeni Bir İlan Ver" />
                            <asp:Button ID="profile" runat="server" CssClass="btn" Text="Profiline Git" />
                            <asp:Button ID="exit" runat="server" CssClass="btn" Text="Çıkış" />

							<%--<a href="#p3" class="btn">Yeni Bir İlan Ver</a>--%>
<%--							<a href="" class="btn">Profiline Git</a>
                            <a href="" class="btn">Çıkış</a>--%>
						</div>
					</div>
				</div>
			</div>

			<!-- Search Section -->
			<section id="p3" class="advertizes search-icons icons bg-light">
				
                <div class="flex-items">
                    <div>
                        <i class="fas fa-map-marker fa-5x"></i>
                        <div>
                            <h3>Nereden Gidiyorsun?</h3>
                            <div>
                                <asp:TextBox  ID="from" runat="server" placeholder="İzmir"></asp:TextBox>
                                <%--<input type="text" name="from" id="from" placeholder="İZMİR" />--%>
                            </div>
                        </div>
                    </div>
                    <div>
                        <i class="fas fa-location-arrow fa-5x"></i>
                        <div>
                            <h3>Nereye Gidiyorsun?</h3>
                            <div>
                                <asp:TextBox  ID="to" runat="server" placeholder="İstanbul"></asp:TextBox>

                                <%--<input type="text" name="to" id="to" placeholder="İSTANBUL" />--%>
                            </div>
                        </div>
                    </div>
                    <div>
                        <i class="fas fa-users fa-5x"></i>
                        <div>
                            <h3>Kaç Kişi Gidiyorsun?</h3>
                            <div>
								
                                <asp:TextBox  ID="people" runat="server" TextMode="Number" placeholder="1"></asp:TextBox>

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
                                <asp:TextBox  ID="date" runat="server" TextMode="Date" ></asp:TextBox>

                                <%--<input type="date" name="date" id="date" />--%>
                            </div>
                        </div>
                    </div>
                </div>
				<%--<div class="flex-items">
					<div>
						<i class="fas fa-map-marker fa-5x"></i>
						<div>
							<h3>Nereden Gidiyorsun?</h3>
							<div>
								<input type="text" name="from" id="from" placeholder="İZMİR" />
							</div>
						</div>
					</div>
					<div>
						<i class="fas fa-location-arrow fa-5x"></i>
						<div>
							<h3>Nereye Gidiyorsun?</h3>
							<div>
								<input type="text" name="to" id="to" placeholder="İSTANBUL" />
							</div>
						</div>
					</div>
					<div>
						<i class="fas fa-users fa-5x"></i>
						<div>
							<h3>Kaç Kişi Gidiyorsun?</h3>
							<div>
								<input
									type="number"
									name="people"
									id="people"
									placeholder="1"
								/>
							</div>
						</div>
					</div>
					<div>
						<i class="fas fa-calendar-day fa-5x"></i>
						<div>
							<h3>Ne Zaman Gidiyorsun?</h3>
							<div>
								<input type="date" name="date" id="date" />
							</div>
						</div>
					</div>
				</div>--%>
				<div>
					<button class="btn btn-secondary">İlan Ver!</button>
				</div>
			</section>
		</main>
		<footer id="footer" class="bg-dark">
			<p>Copyright &copy; 2020</p>
			<p>Made with ❤ by Orhan Özkerçin & Nur Sultan Bolel</p>
		</footer>
	</body>
    </form>
</body>
</html>
