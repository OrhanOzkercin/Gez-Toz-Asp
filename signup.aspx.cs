using System;
using System.Collections.Generic;
using System.Drawing;


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
                if (Validation.validateEmailIsAvailable(signupEmail.Text))
                {
                    try
                    {
                        if (userHandler.registerUser(signupName.Text, signUpSurname.Text, signupEmail.Text, signupPassword.Text))
                        {
                            validateSignup.Text = "Kaydınız Tamamlandı";
                            validateSignup.BackColor = Color.FromArgb(168, 230, 95);
                            validateSignup.ForeColor = Color.White;
                            validateSignup.Visible = true;

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
                else
                {
                    validateSignup.Text = "Bu mail adresi kullanılıyor.";
                    validateSignup.BackColor = Color.FromArgb(232, 74, 95);
                    validateSignup.ForeColor = Color.White;
                    validateSignup.Visible = true;
                }
                
            }
            
        }
    }
}