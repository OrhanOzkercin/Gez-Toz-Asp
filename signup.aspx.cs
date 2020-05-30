using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace geztoz_asp
{
    public partial class signup : System.Web.UI.Page
    {
        UserHandler userHandler = UserHandler.getInitial();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void signupButton_Click(object sender, EventArgs e)
        {
            var isValid = Validation.validateVerifyPassword(signupPassword.Text, signupPasswordVerif.Text);
            if (!isValid)
            {
                validateSignup.Text = "Girilen şifreler uyuşmuyor!!";
                validateSignup.BackColor = Color.FromArgb(232, 74, 95);
                validateSignup.ForeColor = Color.White;
                validateSignup.Visible = true;

            }
            else
            {
                try
                {
                    if (userHandler.registerUser(signupName.Text, signUpSurname.Text, signupEmail.Text, signupPassword.Text))
                    {
                        Response.Redirect("homepage.aspx");
                    }
                        
                    else
                    {
                        validateSignup.Text = "Tüm alanları doğru bir şekilde doldurunuz";
                        validateSignup.BackColor = Color.FromArgb(232, 74, 95);
                        validateSignup.ForeColor = Color.White;
                        validateSignup.Visible = true;
                    }
                }
                catch (Exception exception)
                {
                   
                }
            }
            
        }
    }
}