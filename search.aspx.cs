using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using Button = System.Web.UI.WebControls.Button;


namespace geztoz_asp
{
    public partial class search : System.Web.UI.Page
    {
        DatabaseHandler dh = DatabaseHandler.getInitial();
        TravelHandler travelHandler = TravelHandler.getInitial();
        List<Button> btnList = new List<Button>();

        private int counter = 0;
        ArrayList idList = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            btnList.Add(Button_1);
            btnList.Add(Button_2);
            btnList.Add(Button_3);
            btnList.Add(Button_4);
            btnList.Add(Button_5);
            if (this.IsPostBack)
            {
                idList = (ArrayList)ViewState["uygun_seferler"];
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["uygun_seferler"] = idList;
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Travel> filteredTravels = travelHandler.getTravels(@from.Text.ToLower(), to.Text.ToLower(), int.Parse(wantedSeat.Text), DateTime.Parse(travelDate.Text).Date);
                counter = 0;
                if (filteredTravels.Count <= 0)
                {
                    validateSearch.Text = "Aradığınız kriterlere uygun yolculuk yoktur!";
                    validateSearch.BackColor = Color.FromArgb(232,74 , 95);
                    validateSearch.ForeColor = Color.White;
                    validateSearch.Visible = true;
                }
                else
                {
                    validateSearch.Visible = false;
                }
                for (int i = 0; i < filteredTravels.Count; i++)
                {
                    filteredTravelsPanel.Controls.Add(createAvailableTravel(filteredTravels[i]));
                    counter += 1;
                    idList.Add(filteredTravels[i].TravelId);
                }
            }
            catch (Exception exception)
            {
                validateSearch.Text = "Lütfen doğru şekilde arama yapınız!";
                validateSearch.BackColor = Color.FromArgb(214, 51, 71);
                validateSearch.ForeColor = Color.White;
                validateSearch.Visible = true;
            }
        }

        private HtmlGenericControl createAvailableTravel(Travel travel)
        {

            HtmlGenericControl section = new HtmlGenericControl("section");
            section.Attributes.Add("class", "road-list flex-columns");

            HtmlGenericControl row = new HtmlGenericControl("div");
            row.Attributes.Add("class", "row");

            section.Controls.Add(row);

            HtmlGenericControl column_1 = new HtmlGenericControl("div");
            column_1.Attributes.Add("class", "column");

            row.Controls.Add(column_1);

            HtmlGenericControl column1 = new HtmlGenericControl("div");
            column1.Attributes.Add("class", "column-1");

            column_1.Controls.Add(column1);

            HtmlGenericControl h4 = new HtmlGenericControl("h4");
            h4.InnerText = "Şoför Bilgileri";

            column1.Controls.Add(h4);

            HtmlGenericControl contentContainer = new HtmlGenericControl("div");
            contentContainer.Attributes.Add("class", "content-container");

            column1.Controls.Add(contentContainer);

            HtmlGenericControl contents = new HtmlGenericControl("div");
            contents.Attributes.Add("class", "contents");

            contentContainer.Controls.Add(contents);

            HtmlGenericControl column1ContentItems_1 = new HtmlGenericControl("div");
            column1ContentItems_1.Attributes.Add("class", "content-items");

            contents.Controls.Add(column1ContentItems_1);

            HtmlGenericControl iconUser1 = new HtmlGenericControl("i");
            iconUser1.Attributes.Add("class", "fas fa-user");

            column1ContentItems_1.Controls.Add(iconUser1);

            HtmlGenericControl h3_1 = new HtmlGenericControl("h3");
            h3_1.InnerText = "İsim:";

            column1ContentItems_1.Controls.Add(h3_1);

            HtmlGenericControl p_1 = new HtmlGenericControl("p");
            p_1.InnerText = travel.DriverName;

            column1ContentItems_1.Controls.Add(p_1);


            HtmlGenericControl column1ContentItems_2 = new HtmlGenericControl("div");
            column1ContentItems_2.Attributes.Add("class", "content-items");

            contents.Controls.Add(column1ContentItems_2);

            HtmlGenericControl iconUser2 = new HtmlGenericControl("i");
            iconUser2.Attributes.Add("class", "far fa-user");

            column1ContentItems_2.Controls.Add(iconUser2);

            HtmlGenericControl h3_2 = new HtmlGenericControl("h3");
            h3_2.InnerText = "Soyisim:";

            column1ContentItems_2.Controls.Add(h3_2);

            HtmlGenericControl p_2 = new HtmlGenericControl("p");
            p_2.InnerText = travel.DriverSurname;

            column1ContentItems_2.Controls.Add(p_2);

            HtmlGenericControl column_2 = new HtmlGenericControl("div");
            column_2.Attributes.Add("class", "column");

            row.Controls.Add(column_2);

            HtmlGenericControl column2 = new HtmlGenericControl("div");
            column2.Attributes.Add("class", "column-2");

            column_2.Controls.Add(column2);

            HtmlGenericControl h4_2 = new HtmlGenericControl("h4");
            h4_2.InnerText = "Yolculuk Bilgileri";

            column2.Controls.Add(h4_2);

            HtmlGenericControl contentContainer_2 = new HtmlGenericControl("div");
            contentContainer_2.Attributes.Add("class", "content-container");

            column2.Controls.Add(contentContainer_2);

            HtmlGenericControl contents_2 = new HtmlGenericControl("div");
            contents_2.Attributes.Add("class", "contents");

            contentContainer_2.Controls.Add(contents_2);

            HtmlGenericControl column2ContentItems_1 = new HtmlGenericControl("div");
            column2ContentItems_1.Attributes.Add("class", "content-items");

            contents_2.Controls.Add(column2ContentItems_1);

            HtmlGenericControl iconUser2_1 = new HtmlGenericControl("i");
            iconUser2_1.Attributes.Add("class", "fas fa-map-marker");

            column2ContentItems_1.Controls.Add(iconUser2_1);

            HtmlGenericControl h3_2_1 = new HtmlGenericControl("h3");
            h3_2_1.InnerText = "Nereden:";

            column2ContentItems_1.Controls.Add(h3_2_1);

            HtmlGenericControl p_2_1 = new HtmlGenericControl("p");
            p_2_1.InnerText = travel.FromDestination.ToUpper();

            column2ContentItems_1.Controls.Add(p_2_1);

            HtmlGenericControl column2ContentItems_2 = new HtmlGenericControl("div");
            column2ContentItems_2.Attributes.Add("class", "content-items");

            contents_2.Controls.Add(column2ContentItems_2);

            HtmlGenericControl iconUser2_2 = new HtmlGenericControl("i");
            iconUser2_2.Attributes.Add("class", "fas fa-location-arrow");

            column2ContentItems_2.Controls.Add(iconUser2_2);

            HtmlGenericControl h3_2_2 = new HtmlGenericControl("h3");
            h3_2_2.InnerText = "Nereye:";

            column2ContentItems_2.Controls.Add(h3_2_2);

            HtmlGenericControl p_2_2 = new HtmlGenericControl("p");
            p_2_2.InnerText = travel.ToDestination.ToUpper();

            column2ContentItems_2.Controls.Add(p_2_2);


            HtmlGenericControl column2ContentItems_3 = new HtmlGenericControl("div");
            column2ContentItems_3.Attributes.Add("class", "content-items");

            contents_2.Controls.Add(column2ContentItems_3);

            HtmlGenericControl iconUser2_3 = new HtmlGenericControl("i");
            iconUser2_3.Attributes.Add("class", "fas fa-calendar-day");

            column2ContentItems_3.Controls.Add(iconUser2_3);

            HtmlGenericControl h3_2_3 = new HtmlGenericControl("h3");
            h3_2_3.InnerText = "Ne Zaman:";

            column2ContentItems_3.Controls.Add(h3_2_3);

            HtmlGenericControl p_2_3 = new HtmlGenericControl("p");
            p_2_3.InnerText = travel.TravelDate.Month.ToString() + "/" + travel.TravelDate.Day.ToString() + "/" + travel.TravelDate.Year.ToString() + " - " + travel.TravelTime;

            column2ContentItems_3.Controls.Add(p_2_3);


            HtmlGenericControl last_item = new HtmlGenericControl("div");
            last_item.Attributes.Add("class", "last-item");

            contents_2.Controls.Add(last_item);

            HtmlGenericControl content_items_1 = new HtmlGenericControl("div");
            content_items_1.Attributes.Add("class", "content-items");

            last_item.Controls.Add(content_items_1);


            HtmlGenericControl iconUser3_1 = new HtmlGenericControl("i");
            iconUser3_1.Attributes.Add("class", "far fa-user");

            content_items_1.Controls.Add(iconUser3_1);

            HtmlGenericControl h3_3_1 = new HtmlGenericControl("h3");
            h3_3_1.InnerText = "Toplam Kişi:";

            content_items_1.Controls.Add(h3_3_1);

            HtmlGenericControl p_3_1 = new HtmlGenericControl("p");
            p_3_1.InnerText = travel.TotalSeat.ToString();

            content_items_1.Controls.Add(p_3_1);


            HtmlGenericControl content_items_2 = new HtmlGenericControl("div");
            content_items_2.Attributes.Add("class", "content-items");

            last_item.Controls.Add(content_items_2);


            HtmlGenericControl iconUser3_2 = new HtmlGenericControl("i");
            iconUser3_2.Attributes.Add("class", "fas fa-user");

            content_items_2.Controls.Add(iconUser3_2);

            HtmlGenericControl h3_3_2 = new HtmlGenericControl("h3");
            h3_3_2.InnerText = "Boş Yer:";

            content_items_2.Controls.Add(h3_3_2);

            HtmlGenericControl p_3_2 = new HtmlGenericControl("p");
            p_3_2.InnerText = travel.AvailableSeat.ToString();

            content_items_2.Controls.Add(p_3_2);


            HtmlGenericControl column_3 = new HtmlGenericControl("div");
            column_3.Attributes.Add("class", "column");

            row.Controls.Add(column_3);

            HtmlGenericControl column3 = new HtmlGenericControl("div");
            column3.Attributes.Add("class", "column-3");

            column_3.Controls.Add(column3);

            HtmlGenericControl h4_3 = new HtmlGenericControl("h4");
            h4_3.InnerText = "Yolculuk Seni Bekler";

            column3.Controls.Add(h4_3);

            HtmlGenericControl contentContainer3 = new HtmlGenericControl("div");
            contentContainer3.Attributes.Add("class", "content-container");

            column3.Controls.Add(contentContainer3);

            HtmlGenericControl contentContainer3_contents = new HtmlGenericControl("div");
            contentContainer3_contents.Attributes.Add("class", "contents");

            contentContainer3.Controls.Add(contentContainer3_contents);
            
            contentContainer3_contents.Controls.Add(btnList[counter]);
            btnList[counter].Visible = true;


            return section;
        }
        
        protected void btnJoinTravel(object sender, EventArgs e)
        {
            
            HttpCookie cookie = Request.Cookies["Preferences"];

            if (cookie == null)
            {
                validateSearch.Text = "Yolculuğa kayıt olabilmek için giriş yapmalısınız!";
                validateSearch.BackColor = Color.FromArgb(232, 74, 95);
                validateSearch.ForeColor = Color.White;
                validateSearch.Visible = true;
            }

            else
            {
                Button btn = (Button)sender;
                string[] words = btn.ID.Split('_');
                int index = Int32.Parse(words[1]);

                if (!dh.updatePassengers(idList[index - 1].ToString(), cookie["userId"].ToString()))
                {
                    validateSearch.Text = "Bu yolculuğa daha önce kayıt olmuşsunuz ya da yolculuk ilanı size ait!";
                    validateSearch.BackColor = Color.FromArgb(232, 74, 95);
                    validateSearch.ForeColor = Color.White;
                    validateSearch.Visible = true;
                }
                else
                {
                    if (dh.updateAvailableSeat(idList[index - 1].ToString(), int.Parse(wantedSeat.Text)))
                    {
                        validateSearch.Text = "Yolculuğa kaydınız başarı ile yapıldı.";
                        validateSearch.BackColor = Color.FromArgb(208, 234, 163);
                        validateSearch.ForeColor = Color.Black;
                        validateSearch.Visible = true;
                    }
                    else
                    {
                        validateSearch.Text = "Bu yolculukta yeterli alan yok";
                        validateSearch.BackColor = Color.FromArgb(232, 74, 95);
                        validateSearch.ForeColor = Color.White;
                        validateSearch.Visible = true;
                    }
                }


            }
        }

    }
}