<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="geztoz_asp.login" %>

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
        <header class="hero search login-header">
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
                        <a href="advertize.aspx"><i class="fas fa-search-plus"></i>Yolculuk İlanı Ver</a>
                    </li>
                </ul>
            </nav>
            <div class="content">
                <h1>Maceraya Katıl - Gez Toz</h1>
            </div>
        </header>

        <main>
            <!-- Login Section -->
            <div class="login register">
                <div id="container-form">
                    <div class="form-wrap">
                        <h1>Giriş Yap</h1>
                        <form>
                            <div class="form-group">

                                <asp:Label ID="loginEmailLabel" runat="server" AssociatedControlID="loginEmail" Text="Email"></asp:Label>
                                <asp:TextBox  ID="loginEmail" runat="server"></asp:TextBox>

                               <%-- <label for="email">Email</label>
                                <input type="email" name="email" id="email" />--%>

                            </div>
                            <div class="form-group">
                                
                                <asp:Label ID="loginPasswordLabel" runat="server" AssociatedControlID="loginPassword" Text="Şifre"></asp:Label>
                                <asp:TextBox  ID="loginPassword" runat="server" TextMode="Password"></asp:TextBox>
                                

                               <%-- <label for="password">Şifre</label>
                                <input type="password" name="password" id="password" />--%>
                            </div>
                            <asp:Button ID="loginButton" runat="server"  CssClass="btn" Text="Giriş Yap" OnClick="loginButton_Click"  />

                            <%--<button type="submit" class="btn">Giriş Yap</button>--%>
                            <footer id="form-footer">
                                <p>Hesabın yok mu? <a href="signup.aspx">Kayıt ol</a></p>
                            </footer>
                        </form>
                    </div>
                    <asp:Label ID="validateLabel" runat="server" Visible="False" Text="Label">Kullanici adi veya şifre yanlış!</asp:Label>
                </div>
               

            </div>
        </main>
        <footer id="footer" class="bg-dark login-footer">
            <p>Copyright &copy; 2020</p>
            <p>Made with ❤ by Orhan Özkerçin & Nur Sultan Bolel
            </p>
        </footer>
        </div
    </form>
</body>
</html>
