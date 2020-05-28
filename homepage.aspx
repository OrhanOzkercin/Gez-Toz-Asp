<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="geztoz_asp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css"
    />

    <link rel="stylesheet" href="css/style.css" />
    <link rel="stylesheet" href="css/utilities.css" />
    <link rel="stylesheet" href="css/responsive.css" />
    <title>GezToz | Hayatı Yakala</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="body">
		<header class="hero">
			<nav class="navbar">
				<div class="logo">
					<img src="/aspects/images/logo.png" alt="logo" />
				</div>
				<ul id="homepageButtons" runat="server">
					<li>
						<a href="login.aspx" class="btn btn-primary">Giriş Yap</a>
					</li>
					<li>
						<a href="signup.aspx" class="btn btn-secondary">Üye Ol</a>
					</li>
				</ul>
				<div id="loginedSide" runat="server" Visible="False">
                    <p id="welcomeText" runat="server" >Hoş geldin </p>
					<div>
					<asp:Button runat="server" CssClass="btn btn-primary" Text="Profil"/>
                    <asp:Button runat="server" CssClass="btn btn-secondary" Text="Çıkış" OnClick="Unnamed2_Click"/>
                    </div>
                </div>
				
			</nav>

			<div class="content">
				<h1>Keşfet Dünyayı - Gez Toz</h1>
				<p>Birlikte gezip görmek istiyoruz</p>
				<div class="buttons">
					<a href="search.aspx" class="btn btn-primary"
						><i class="fas fa-chevron-right"></i> Yolculuk Bul</a
					>
					<a href="advertize.aspx" class="btn btn-secondary"
						><i class="fas fa-chevron-right"></i> Yol Arkadaşı Bul</a
					>
				</div>
			</div>
		</header>
		<main>
			<!-- İcons section -->
			<section class="icons bg-light">
				<div class="flex-items">
					<div>
						<i class="fas fa-car fa-3x"></i>
						<div>
							<h3>Bi yere mi gidiyorsun?</h3>
							<p>
								Seçeneklerin arasından sana uygun olan yolculukları listele ve
								hemen iletişime geç.
							</p>
						</div>
					</div>
					<div>
						<i class="fas fa-phone-volume fa-3x"></i>
						<div>
							<h3>Hemen iletişim kur</h3>
							<p>
								İhtiyaçlarını karşılayan sana uygun yolculuğu buldun mu? Ne
								duruyorsun! Hemen iletişime geç ve özgürlüğünü hisset!
							</p>
						</div>
					</div>
					<div>
						<i class="fas fa-road fa-3x"></i>
						<div>
							<h3>Yolculuk başlasın</h3>
							<p>
								Birlikte yola çıkın ve keyifli vakitler hikayeler biriktirin.
								Keşmek ve deneyimlemek hiç bu kadar kolay olmamıştı.
							</p>
						</div>
					</div>
				</div>
			</section>
			<!-- Host Section -->
			<section class="host flex-columns">
				<div class="row">
					<div class="column">
						<div class="column-1 bg-primary">
							<h4>Sürücü müsün?</h4>
							<h2>Yol arkadaşı mı arıyorsun?</h2>
							<p>
								Yapacağın yolculuk için hem maaliyetlerini azaltıp hem de
								yolculuğunu zevkli bir hale getirmek için yanında bir yol
								arkadaşı ister misin? Eğer cevabın evet ise hemen yolculuk ilanı
								ver!
							</p>
							<a href="advertize.aspx" class="btn btn-outline"
								><i class="fas fa-chevron"></i> Yolculuk İlanı Ver</a
							>
						</div>
					</div>
					<div class="column">
						<div class="column-2">
							<img src="https://image.freepik.com/free-photo/female-tourists-hand-have-happy-travel-map_1150-7412.jpg" alt="" />
						</div>
					</div>
				</div>
			</section>
		</main>
		<footer id="footer" class="bg-dark">
			<p>Copyright &copy; 2020</p>
			<p>Made with ❤ by Orhan Özkerçin & Nur Sultan Bolel</p>
		</footer>
	</div>
    </form>
</body>
</html>
