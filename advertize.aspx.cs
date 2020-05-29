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

        }

        protected void advertizeButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Preferences"];
            if (cookie == null)
            {
                MessageBox.Show("Önce giriş yapın");
            }
            else
            {
                try
                {
                    string driverId = ParseHandler.parseStringToUtf8(cookie["userId"]);
                    string driverName = ParseHandler.parseStringToUtf8(cookie["userName"]);
                    string driverSurname = ParseHandler.parseStringToUtf8(cookie["userSurname"]);
                    string fromDestination = (this.@from.Text);
                    string toDestination = this.to.Text;
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
    }
}