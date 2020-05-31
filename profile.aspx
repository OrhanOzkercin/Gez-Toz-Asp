<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="geztoz_asp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
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
        <div class="body">
            <header class="hero search login-header">
                <nav class="navbar">
                    <div class="logo">
                        <a href="homepage.aspx">
                            <img src="./aspects/images/logo.png" alt="logo" /></a>
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
                    <h1>Maceraya Katıl - Gez Toz</h1>
                </div>
            </header>
            <main>
                <section class="profile flex-columns">
                    <div class="row">
                        <div class="column">
                            <div class="column-1 bg-light">
                                <img src="/aspects/images/orhan.png" alt="" />
                                <asp:Label ID="profileNameSurname" runat="server" CssClass="h2"></asp:Label>
                                <div class="profile-side">
                                    <asp:Button ID="logout" runat="server" CssClass="btn" Text="Çıkış" OnClick="logout_Click" />
                                </div>
                            </div>
                        </div>
                        <div class="column">
                            <div class="column-2 profile-tab">
                                <div class="flex-items">
                                    <div class="flex-item">
                                        <div class="flex-item">
                                            <label class="profile-label" for="name">İsim</label>
                                            <asp:TextBox ID="name" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="flex-item">
                                            <label class="profile-label" for="surname">Soyisim</label>
                                            <asp:TextBox ID="surname" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="flex-item">
                                        <div class="flex-item">
                                            <label class="profile-label" for="email">Email</label>
                                            <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
                                        </div>
                                        <div class="flex-item">
                                            <label class="profile-label" for="password">Şifre</label>
                                            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="flex-item">
                                        <asp:Button ID="profileUpdateButton" runat="server" CssClass="btn" Text="Güncelle" OnClick="profileUpdateButton_Click" />
                                    </div>
                                    <asp:Label ID="validateProfile" runat="server" Visible="False"></asp:Label>
                                </div>
                            </div>
                        </div>
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
