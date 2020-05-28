<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="geztoz_asp.signup" %>

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
        <header class="hero search signup-header">
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
            <!-- Welcome for register Section -->
            <div class="register">
                <div id="container-form">
                    <div class="form-wrap">
                        <h1>Üye Ol</h1>
                        <p>Tamamen ücretsiz ve yalnızca bir kaç dakikanı alır</p>
                        <form>
                            <div class="form-group">
                                
                                <asp:Label ID="signupNameLabel" runat="server" AssociatedControlID="signupName" Text="isim"></asp:Label>
                                <asp:TextBox  ID="signupName" runat="server" ></asp:TextBox>

                                <%--<label for="first-name">İsim</label>
                                <input type="text" name="firstName" id="first-name" />--%>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="signUpSurnameLabel" runat="server" AssociatedControlID="signUpSurname" Text="Soyisim"></asp:Label>
                                <asp:TextBox  ID="signUpSurname" runat="server"></asp:TextBox>

                                <%--<label for="last-name">Soyisim</label>
                                <input type="text" name="lastName" id="last-name" />--%>
                            </div>
                            <div class="form-group">
                                
                                <asp:Label ID="signupEmailLabel" runat="server" AssociatedControlID="signupEmail" Text="Email"></asp:Label>
                                <asp:TextBox  ID="signupEmail" runat="server" TextMode="Email"></asp:TextBox>

                                <%--<label for="email">Email</label>
                                <input type="email" name="email" id="email" />--%>
                            </div>
                            <div class="form-group">
                                
                                <asp:Label ID="signupPasswordLabel" runat="server" AssociatedControlID="signupPassword" Text="Şifre"></asp:Label>
                                <asp:TextBox  ID="signupPassword" runat="server" TextMode="Password"></asp:TextBox>

                               <%-- <label for="password">Şifre</label>
                                <input type="password" name="password" id="password" />--%>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="signupPasswordVerifLabel" runat="server" AssociatedControlID="signupPasswordVerif" Text="Şifre Doğrulaması"></asp:Label>
                                <asp:TextBox  ID="signupPasswordVerif" runat="server" TextMode="Password"></asp:TextBox>
<%--                                <input type="password" name="signupPassword" id="signupPassword" />--%>
                            </div>
                            <asp:Button ID="signupButton" runat="server"  CssClass="btn" Text="Üye Ol" OnClick="signupButton_Click"  />
                        </form>
                    </div>
                    <footer id="form-footer">
                        <p>Zaten hesabın var mı? <a href="login.aspx">Giriş yap</a></p>
                    </footer>
                </div>
            </div>
        </main>
        <footer id="footer" class="bg-dark">
            <p>Copyright &copy; 2020</p>
            <p>Made with ❤ by Orhan Özkerçin & Nur Sultan Bolel</p>
        </footer>
        </div
    </form>
   
    
   
</body>
</html>
