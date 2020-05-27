using System;
using System.Collections.Generic;
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
                MessageBox.Show("Girilen şifreler uyuşmuyor!");
                
            }
            else
            {
                try
                {
                    userHandler.registerUser(signupName.Text, signUpSurname.Text, signupEmail.Text, signupPassword.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
            
        }
    }
}