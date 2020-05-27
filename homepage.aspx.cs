using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace geztoz_asp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private DatabaseHandler dh;
        private UserHandler userHandler;
        private User user;

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Preferences"];

            if (cookie != null)
            {
                User user = geztoz_asp.User.getInitial();
                homepageButtons.Visible = false;
                welcomeText.InnerText = "Hoş geldin " + cookie["userName"];
                loginedSide.Visible = true;
            }
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Preferences"];
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            new LogOut();
            Response.Redirect(Request.RawUrl);
            
        }
    }
}