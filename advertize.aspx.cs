using System;
using System.Collections.Generic;
using System.Linq;
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
                string driverId = cookie["userId"].ToString();
                string driverName = cookie["userName"].ToString();
                string driverSurname = cookie["userSurname"].ToString();
                string fromDestination = this.@from.Text;
                string toDestination = this.to.Text;
                int totalSeat = int.Parse(this.totalSeat.Text);
                int availableSeat = 0;
                DateTime travelDate = Convert.ToDateTime(date.Text);
                TravelHandler travelHandler = TravelHandler.getInitial();
                travelHandler.registerTravel(driverId,driverName,driverSurname,totalSeat,availableSeat, fromDestination, toDestination,travelDate);
            }
        }
    }
}