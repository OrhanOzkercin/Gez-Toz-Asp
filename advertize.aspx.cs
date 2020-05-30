using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace geztoz_asp
{
    public partial class advertize : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Preferences"];

            if (cookie == null)
            {
                advertizeLogin.Visible = true;
                advertizeWelcomeLabel.InnerText = "Hoş Geldiniz";
                advertizeWelcomeParagraph.InnerText = "İlan verebilmek için giriş yapmalısınız!";
            }
            else
            {
                advertizeDiveder.Visible = true;
                advertizeButtons.Visible = true;
                p3.Visible = true;
                advertizeWelcomeLabel.InnerText= "Hoş Geldin" +" " + cookie["userName"];
                advertizeWelcomeParagraph.InnerText= "Yolculuk için güzel bir gün!";
                
            }
        }

        protected void advertizeButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Preferences"];
            if (cookie == null)
            {
                advertizeWelcomeLabel.InnerText = "Hoş Geldiniz";
                advertizeWelcomeParagraph.InnerText = "İlan verebilmek için giriş yapmalısınız!";
            }
            else
            {
                advertizeWelcomeLabel.InnerText = "Hoş Geldin" + cookie["userName"];
                advertizeWelcomeParagraph.InnerText = "Yolculuk için güzel bir gün!";
                advertizeButtons.Visible = true;
                try
                {
                    string driverId = cookie["userId"];
                    string driverName = (cookie["userName"]);
                    string driverSurname = (cookie["userSurname"]);
                    string fromDestination = (this.@from.Text).ToLower();
                    string toDestination = this.to.Text.ToLower();
                    int totalSeat = int.Parse(this.totalSeat.Text);
                    int availableSeat = totalSeat;
                    DateTime travelDate = Convert.ToDateTime(date.Text);
                    TravelHandler travelHandler = TravelHandler.getInitial();
                    travelHandler.registerTravel(driverId, driverName, driverSurname, totalSeat, availableSeat, fromDestination, toDestination, travelDate);
                }
                catch (Exception exception)
                {
                    validateAdvertize.Text = "Aradığınız kriterlere uygun yolculuk bulunamadı!";
                    validateAdvertize.BackColor = Color.FromArgb(214, 51, 71);
                    validateAdvertize.ForeColor = Color.White;
                    validateAdvertize.Visible = true;
                }
                
            }
        }

        protected void advertizeLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void exit_Click(object sender, EventArgs e)
        {
            LogOut logOut = new LogOut();
            Response.Redirect("homepage.aspx");
        }
    }
}