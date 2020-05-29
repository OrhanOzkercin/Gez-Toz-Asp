using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using Button = System.Web.UI.WebControls.Button;
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
            try
            {
                List<Travel> filteredTravels = travelHandler.getTravels(@from.Text, to.Text, int.Parse(wantedSeat.Text), DateTime.Parse(travelDate.Text).Date);
                for (int i = 0; i < filteredTravels.Count; i++)
                {
                    filteredTravelsPanel.Controls.Add(createAvailableTravel(filteredTravels[i], i));
                }

            }
            catch (Exception exception)
            {
                validateSearch.Text = "Aradığınız kriterlere uygun yolculuk bulunamadı!";
                validateSearch.BackColor = Color.FromArgb(214, 51, 71);
                validateSearch.ForeColor = Color.White;
                validateSearch.Visible = true;
            }

            
        }

        private HtmlGenericControl createAvailableTravel(Travel travel, int idNumber)
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
            iconUser1.Attributes.Add("class", "far fa-user");

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


            HtmlGenericControl column1ContentItems_3 = new HtmlGenericControl("div");
            column1ContentItems_3.Attributes.Add("class", "content-items");

            contents.Controls.Add(column1ContentItems_3);

            HtmlGenericControl iconUser3 = new HtmlGenericControl("i");
            iconUser3.Attributes.Add("class", "far fa-user");

            column1ContentItems_3.Controls.Add(iconUser3);

            HtmlGenericControl h3_3 = new HtmlGenericControl("h3");
            h3_3.InnerText = "Yaş:";

            column1ContentItems_3.Controls.Add(h3_3);

            HtmlGenericControl p_3 = new HtmlGenericControl("p");
            p_3.InnerText = "23:düzelt";

            column1ContentItems_3.Controls.Add(p_3);



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
            iconUser2_1.Attributes.Add("class", "far fa-user");

            column2ContentItems_1.Controls.Add(iconUser2_1);

            HtmlGenericControl h3_2_1 = new HtmlGenericControl("h3");
            h3_2_1.InnerText = "Nereden:";

            column2ContentItems_1.Controls.Add(h3_2_1);

            HtmlGenericControl p_2_1 = new HtmlGenericControl("p");
            p_2_1.InnerText = travel.FromDestination;

            column2ContentItems_1.Controls.Add(p_2_1);

            HtmlGenericControl column2ContentItems_2 = new HtmlGenericControl("div");
            column2ContentItems_2.Attributes.Add("class", "content-items");

            contents_2.Controls.Add(column2ContentItems_2);

            HtmlGenericControl iconUser2_2 = new HtmlGenericControl("i");
            iconUser2_2.Attributes.Add("class", "far fa-user");

            column2ContentItems_2.Controls.Add(iconUser2_2);

            HtmlGenericControl h3_2_2 = new HtmlGenericControl("h3");
            h3_2_2.InnerText = "Nereye:";

            column2ContentItems_2.Controls.Add(h3_2_2);

            HtmlGenericControl p_2_2 = new HtmlGenericControl("p");
            p_2_2.InnerText = travel.ToDestination;

            column2ContentItems_2.Controls.Add(p_2_2);


            HtmlGenericControl column2ContentItems_3 = new HtmlGenericControl("div");
            column2ContentItems_3.Attributes.Add("class", "content-items");

            contents_2.Controls.Add(column2ContentItems_3);

            HtmlGenericControl iconUser2_3 = new HtmlGenericControl("i");
            iconUser2_3.Attributes.Add("class", "far fa-user");

            column2ContentItems_3.Controls.Add(iconUser2_3);

            HtmlGenericControl h3_2_3 = new HtmlGenericControl("h3");
            h3_2_3.InnerText = "Ne Zaman:";

            column2ContentItems_3.Controls.Add(h3_2_3);

            HtmlGenericControl p_2_3 = new HtmlGenericControl("p");
            p_2_3.InnerText = travel.TravelDate.ToString();

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
            iconUser3_2.Attributes.Add("class", "far fa-user");

            content_items_2.Controls.Add(iconUser3_2);

            HtmlGenericControl h3_3_2 = new HtmlGenericControl("h3");
            h3_3_2.InnerText = "Toplam Kişi:";

            content_items_2.Controls.Add(h3_3_2);

            HtmlGenericControl p_3_2 = new HtmlGenericControl("p");
            p_3_2.InnerText = travel.TotalSeat.ToString();

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

            Button btnYolculugaKatıl = new Button();
            btnYolculugaKatıl.Attributes.Add("class", "btn");
            btnYolculugaKatıl.Text = "Bu yolculuğa Katıl";
            btnYolculugaKatıl.Click += new EventHandler(btnYolculugaKatıl_click);


            contentContainer3_contents.Controls.Add(btnYolculugaKatıl);

            return section;
        }


        protected void btnYolculugaKatıl_click(object sender, EventArgs e)
        {
            MessageBox.Show("aaa");
        }

    }
}