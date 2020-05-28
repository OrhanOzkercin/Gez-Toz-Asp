using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace geztoz_asp
{
    public partial class search : System.Web.UI.Page
    {
        TravelHandler travelHandler = TravelHandler.getInitial();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            List<Travel> fiteredTravels = travelHandler.getTravels(@from.Text, to.Text, int.Parse(wantedSeat.Text), DateTime.Parse(travelDate.Text).Date);
        }

        private void createAvailableTravel()
        {

        }
    }
}