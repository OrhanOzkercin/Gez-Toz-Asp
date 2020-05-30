<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="geztoz_asp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
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
		<header class="hero search login-header">
			<nav class="navbar">
				<div class="logo">
					<a href="homepage.aspx"><img src="./aspects/images/logo.png" alt="logo" /></a>
				</div>
				<ul>
					<li>
						<a href="search.aspx"
							><i class="fas fa-search"></i>Yolculuk Ilanı Ara</a
						>
					</li>
					<li>
						<a href="advertize.aspx"><i class="fas fa-search-plus"></i>Yolculuk İlanı Ver</a>
					</li>
				</ul>
			</nav>
			<div class="content">
				<h1>Maceraya Katıl - Gez Toz</h1>
			</div>
		</header>

		<main>
			<section class="profile flex-columns">
				<div class="row">
					<div class="column">
						<div class="column-1 bg-light">
							<img src="/aspects/images/orhan.png" alt="" />
                            <asp:Label ID="profileNameSurname" runat="server" CssClass="h2"  ></asp:Label>

							<%--<h2>Orhan Özkerçin</h2>--%>
							<div class="profile-side">
								<%--<a href="">Profil</a>
								<a href="#old-travels">Geçmiş yolculuklar</a>
								<a href="#waiting-travels">Bekleyen yolculuklar</a>--%>
								<a href="" class="btn">Çıkış</a>
							</div>
						</div>
					</div>
					<div class="column">
						<div class="column-2 profile-tab">
							<div class="flex-items">
								<div class="flex-item">
									<div class="flex-item">
										<label class="profile-label" for="name">İsim</label>
										
                                        <asp:TextBox  ID="name" runat="server" ></asp:TextBox>
										<%--<input type="text" name="name" id="name" />--%>
									</div>
									<div class="flex-item">
										<label class="profile-label" for="surname">Soyisim</label>
                                        <asp:TextBox  ID="surname" runat="server" ></asp:TextBox>

										<%--<input type="text" name="surname" id="surname" />--%>
									</div>
								</div>
								<div class="flex-item">
									<div class="flex-item">
										<label class="profile-label" for="email">Email</label>
                                        <asp:TextBox  ID="email" runat="server" TextMode="Email" ></asp:TextBox>

										<%--<input type="email" name="email" id="email" />--%>
									</div>
									<div class="flex-item">
										<label class="profile-label" for="password">Şifre</label>
										
                                        <asp:TextBox  ID="password" runat="server" TextMode="Password"></asp:TextBox>
										<%--<input type="password" name="password" id="password" />--%>
									</div>
								</div>
								
                                <asp:Label ID="validateProfile" runat="server"  Visible="False"></asp:Label>

								<div class="flex-item">
									
                                   
                                    <asp:Button ID="profileUpdateButton" runat="server"  CssClass="btn" Text="Güncelle" OnClick="profileUpdateButton_Click"  />

									<%--<a href="#" class="btn">Güncelle</a>--%>
								</div>
							</div>
						</div>
					</div>
					<%--<div class="column" style="display: none;">
						<div class="column-2 profile-tab old-travel-passenger">
							<table>
								<tr>
									<th>Şöför Adı</th>
									<th>Nereden</th>
									<th>Nereye</th>
									<th>Yolculuk Zamanı</th>
									<th>Kişi Sayısı</th>
								</tr>
								<tr>
									<td>Orhan Özkerçin</td>
									<td>Izmir</td>
									<td>Ankara</td>
									<td>23 Haziran</td>
									<td>4</td>
								</tr>
							</table>
						</div>
					</div>--%>
				</div>
			</section>
		</main>
		<footer id="footer" class="bg-dark profile-footer">
			<p>Copyright &copy; 2020</p>
			<p>Made with ❤ by Orhan Özkerçin & Nur Sultan Bolel</p>
		</footer>
	</div>
    </form>
</body>
</html>
