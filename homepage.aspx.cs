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
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["user"] != null)
            {
                User user = geztoz_asp.User.getInitial();
                homepageButtons.Visible = false;
                welcomeText.InnerText = "Hoş geldin" + user.Name;
            }
        }
    }
}