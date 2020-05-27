using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace geztoz_asp
{
    public partial class login : System.Web.UI.Page
    {
        UserHandler userHandler = new UserHandler();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                Response.Redirect("homepage.aspx");
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            if (userHandler.loginUser(loginEmail.Text,loginPassword.Text))
            {
                User user = geztoz_asp.User.getInitial();
                Session["user"] = user;
                Response.Redirect("homepage.aspx");
            }

            
        }
    }
}