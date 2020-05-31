using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace geztoz_asp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            validateProfile.Visible = false;
            HttpCookie cookie = Request.Cookies["Preferences"];

            if (cookie == null)
            {
                Response.Redirect("homepage.aspx");
            }
            else
            {
                profileNameSurname.Text = (cookie["userName"].ToString()) + " " + cookie["userSurname"];
            }

        }

        protected void profileUpdateButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            HttpCookie cookie = Request.Cookies["Preferences"];
            UserHandler userHandler = UserHandler.getInitial();
            User user = userHandler.getUserByEmailFromDatabase(cookie["userEmail"].ToString());
           
            if (this.name.Text == "" && this.surname.Text == "" && this.email.Text == "" && this.password.Text == "")
            {
                validateProfile.Text = "En az bir alanı güncellemelisiniz. " ;
                validateProfile.BackColor = Color.FromArgb(232, 74, 95);
                validateProfile.ForeColor = Color.White;
                validateProfile.Visible = true;
            }
            else
            {
                if (this.email.Text != "")
                {
                    isValid = Validation.validateEmailIsAvailable(this.email.Text);
                }

                if (isValid)
                {
                    string name = this.name.Text == "" ? cookie["userName"].ToString() : this.name.Text;
                    string surname = this.surname.Text == "" ? cookie["userSurname"].ToString() : this.surname.Text;
                    string email = this.email.Text == "" ? cookie["userEmail"].ToString() : this.email.Text;
                    string password = this.password.Text == "" ? user.Password : this.password.Text;

                    if (userHandler.updateUser(name, surname, email, password))
                    {
                        cookie.Values["userName"] = name;
                        cookie.Values["userSurname"] = surname;
                        cookie.Values["userEmail"] = email;
                        Response.Cookies.Add(cookie);
                        validateProfile.Text = "Profilin başarıyla güncellendi " + name;
                        validateProfile.BackColor = Color.FromArgb(208, 234, 163);
                        validateProfile.ForeColor = Color.Black;
                        validateProfile.Visible = true;
                        profileNameSurname.Text = name + " " + surname;
                    }
                    else
                    {
                        validateProfile.Text = "Profilin güncellenemedi! " + name;
                        validateProfile.BackColor = Color.FromArgb(232, 74, 95);
                        validateProfile.ForeColor = Color.White;
                        validateProfile.Visible = true;
                    }
                }
                else
                {
                    validateProfile.Text = "Bu mail adresi kullanılmakta! ";
                    validateProfile.BackColor = Color.FromArgb(232, 74, 95);
                    validateProfile.ForeColor = Color.White;
                    validateProfile.Visible = true;
                }
                
            }
           

        }

        protected void logout_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Preferences"];
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            new LogOut();
            Response.Redirect("homepage.aspx");
        }
    }
}