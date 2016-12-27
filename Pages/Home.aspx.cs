using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Pages_Home : System.Web.UI.Page
{
    #region "Declarations"

    string _strSql = "";
    DataTable _dt = new DataTable();

    #endregion


    #region "Page Events"

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Initialization();
        }
    }

    #endregion


    #region "Local Procedures"

    protected void Initialization()
    {
        ltlCarouselIndicators.Text = "";
        ltlCarouselItems.Text = "";

        _strSql = "SELECT * " +
                  "  FROM ADVERTISMENTS " +
                  " WHERE FORMAT(iif(IsNull(START_DATE_ACTIVE),now(),START_DATE_ACTIVE),'YYYYMMDD') <= FORMAT(now(),'YYYYMMDD') " +
                  "   AND FORMAT(iif(IsNull(END_DATE_ACTIVE),now(),END_DATE_ACTIVE),'YYYYMMDD') >= FORMAT(now(),'YYYYMMDD') " +
                  " ORDER BY START_DATE_ACTIVE DESC, ADVERTISMENT_ID ASC ";

        _dt = Sql.GetDataTable("DemoDb", _strSql);

        if (_dt.Rows.Count == 0)
        {
            pnlAdvertisment.Visible = false;
        }
        else
        {
            pnlAdvertisment.Visible = true;
            int i = 0;
            ltlCarouselIndicators.Text += "<ol class='carousel-indicators'>";
            ltlCarouselItems.Text += "<div class='carousel-inner' role='listbox' style='width: 80%; margin: 0 auto;'>";

            foreach (DataRow row in _dt.Rows)
            {
                if (i == 0)
                {
                    ltlCarouselIndicators.Text += "<li data-target='#carousel-example-generic' data-slide-to='" + i.ToString() + "' class='active'></li>";
                    ltlCarouselItems.Text += "<div class='item active'>" +
                                             "    <a href='" + row.Field<string>("URL") + "' target='_blank' ><img src='../media/advertisments/" + row.Field<string>("IMAGE_FILE") + "' style='width: 100%;' alt='" + row.Field<string>("ALTERNATE_TEXT") + "' class='img-responsive' /></a>" +
                                             "    <div class='carousel-caption'>" +
                                                     row.Field<string>("SUBJECT") +
                                             "    </div>" +
                                             "</div>";
                }
                else
                {
                    ltlCarouselIndicators.Text += "<li data-target='#carousel-example-generic' data-slide-to='" + i.ToString() + "'></li>";
                    ltlCarouselItems.Text += "<div class='item'>" +
                                             "    <a href='" + row.Field<string>("URL") + "' target='_blank' ><img src='../media/advertisments/" + row.Field<string>("IMAGE_FILE") + "' style='width: 100%;' alt='" + row.Field<string>("ALTERNATE_TEXT") + "' class='img-responsive' /></a>" +
                                             "    <div class='carousel-caption'>" +
                                                     row.Field<string>("SUBJECT") +
                                             "    </div>" +
                                             "</div>";
                }

                i++;
            }

            ltlCarouselIndicators.Text += "</ol>";
            ltlCarouselItems.Text += "</div>";
        }
    }

    #endregion


    #region "Control Events"

    #endregion
}