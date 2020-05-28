using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using HtmlElement = System.Windows.Forms.HtmlElement;

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
            List<Travel> filteredTravels = travelHandler.getTravels(@from.Text, to.Text, int.Parse(wantedSeat.Text), DateTime.Parse(travelDate.Text).Date);

            for (int i = 0; i < filteredTravels.Count; i++)
            {
                filteredTravelsPanel.Controls.Add(createAvailableTravel(filteredTravels[i], i));
            }
        }

        private HtmlGenericControl createAvailableTravel(Travel travel, int idNumber)
        {

            //HtmlGenericControl section = new HtmlGenericControl("section");
            //section.Attributes.Add("class", "road-list flex-columns");
            //HtmlGenericControl row= new HtmlGenericControl("div");
            //row.Attributes.Add("class","row");
            //HtmlGenericControl column = new HtmlGenericControl("div");
            //column.Attributes.Add("class","column");
            //HtmlGenericControl column1= new HtmlGenericControl("div");
            //column1.Attributes.Add("class","column-1");
            //HtmlGenericControl h4 = new HtmlGenericControl("h4");
            //h4.InnerText = "Şoför Bilgileri";
            //HtmlGenericControl contentContainer = new HtmlGenericControl("div");
            //contentContainer.Attributes.Add("class","content-container");
            //HtmlGenericControl contents = new HtmlGenericControl("div");
            //contents.Attributes.Add("class", "contents");
            //HtmlGenericControl column1ContentItems_1 = new HtmlGenericControl("div");
            //column1ContentItems_1.Attributes.Add("class","content-items");
            //HtmlGenericControl iconUser = new HtmlGenericControl("i");
            //iconUser.Attributes.Add("class","far fa-user");
            //HtmlGenericControl h3 = new HtmlGenericControl("h3");
            //h4.InnerText = "İsim:";
            //HtmlGenericControl p = new HtmlGenericControl("p");
            //p.InnerText = travel.DriverName;


            //HtmlGenericControl column1ContentItems_2 = new HtmlGenericControl("div");
            //column1ContentItems_1.Attributes.Add("class", "content-items");


            //contents.Controls.Add(column1ContentItems_1);
            //contentContainer.Controls.Add(contents);
            //column1.Controls.Add(contentContainer);
            //column1.Controls.Add(h4);
            //column.Controls.Add(column1);
            //row.Controls.Add(column);
            //section.Controls.Add(row);


            //return section;
            /*
             *  <section Visible='False' ID='availableTravel' runat='server' class='road-list flex-columns'>
                    <div class='row'>
                        <div class='column'>
                            <div class='column-1'>
                                <h4>Şoför Bilgileri</h4>
                                <div class='content-container'>
                                    <div class='contents'>
                                        <div class='content-items'>
                                            <i class='far fa-user'></i>
                                            <h3>İsim:</h3>
                                            <p ID='driverName' runat='server' >Orhan</p>
                                        </div>
                                        <div class='content-items'>
                                            <i class='fas fa-user'></i>
                                            <h3>Soyisim:</h3>
                                            <p ID='driverSurname' runat='server' >Özkerçin</p>
                                        </div>
                                       
                                        <div class='content-items'>
                                            <i class='fas fa-calendar-alt'></i>
                                            <h3>Yaş:</h3>
                                            <p ID='driverAge' runat='server' >22</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class='column'>
                            <div class='column-2'>
                                <h4>Yolculuk Bilgileri</h4>
                                <div class='content-container'>
                                    <div class='contents'>
                                        <div class='content-items'>
                                            <i class='fas fa-map-marker'></i>
                                            <h3>Nereden:</h3>
                                            <p ID='fromDestination' runat='server' >İzmir</p>
                                        </div>

                                        <div class='content-items'>
                                            <i class='fas fa-location-arrow'></i>
                                            <h3>Nereye:</h3>
                                            <p ID='toDestination' runat='server' >İstanbul</p>
                                        </div>

                                        <div class='content-items'>
                                            <i class='fas fa-calendar-day'></i>
                                            <h3>Ne zaman:</h3>
                                            <p ID='date' runat='server' >23 Haziran</p>
                                        </div>

                                        <div class='last-item'>
                                            <div class='content-items'>
                                                <i class='fas fa-user'></i>
                                                <h3>Toplam Kişi:</h3>
                                                <p ID='totalSeat' runat='server' >3</p>
                                            </div>
                                            <div class='content-items'>
                                                <i class='far fa-user'></i>
                                                <h3>Kalan Kişi:</h3>
                                                <p ID='availableSeat' runat='server' >2</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class='column'>
                            <div class='column-3'>
                                <h4>Yolculuk Seni Bekler</h4>
                                <div class='content-container'>
                                    <div class='contents'>
                                        <button class='btn'>Bu yolculuğa Katıl</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
             */

            HtmlGenericControl section = new HtmlGenericControl();

            section = availableTravel;

            section.Visible = true;

            //section.ID += "-" + idNumber.ToString();
            //driverName.ID += "-" + idNumber.ToString();
            //driverSurname.ID += "-" + idNumber.ToString();
            //driverAge.ID += "-" + idNumber.ToString(); ;

            //fromDestination.ID += "-" + idNumber.ToString();
            //toDestination.ID += "-" + idNumber.ToString();
            //date.ID += "-" + idNumber.ToString();
            //totalSeat.ID += "-" + idNumber.ToString();
            //availableSeat.ID += "-" + idNumber.ToString();


            //driverName.InnerText = travel.DriverName;
            //driverSurname.InnerText = travel.DriverSurname;
            //driverAge.InnerText = (DateTime.Now.Year - travel.TravelDate.Year).ToString();

            //fromDestination.InnerText = travel.FromDestination;
            //toDestination.InnerText = travel.ToDestination;
            //date.InnerText = travel.TravelDate.ToString();
            //totalSeat.InnerText = travel.TotalSeat.ToString();
            //availableSeat.InnerText = travel.AvailableSeat.ToString();


            return section;
        }
    }
}