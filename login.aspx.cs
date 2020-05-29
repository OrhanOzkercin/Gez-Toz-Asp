using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace geztoz_asp
{
    public partial class login : System.Web.UI.Page
    {
        private UserHandler userHandler = UserHandler.getInitial();
        private DatabaseHandler dh = DatabaseHandler.getInitial();

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Preferences"];
            if (cookie != null)
            {
                Response.Redirect("homepage.aspx");
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Preferences"];

            if (userHandler.loginUser(loginEmail.Text,loginPassword.Text))
            {
                User user = dh.getUser(loginEmail.Text);
                addCookie(user);
                Response.Redirect("homepage.aspx");
            }
            else
            {
                validateLabel.Text = "Kullanıcı adı ya da şifre hatalı!";
                validateLabel.BackColor = Color.FromArgb(214,51,71);
                validateLabel.ForeColor = Color.White;
                validateLabel.Visible = true;
            }
        }

        public HttpCookie addCookie(User user)
        {
            HttpCookie cookie = new HttpCookie("Preferences");
            cookie["userId"] = user.Id;
            cookie["userName"] = user.Name;
            cookie["userSurname"] = user.Surname;
            cookie["userEmail"] = user.Email;
            
            Response.Cookies.Add(cookie);

            return cookie;
        }
    }
}