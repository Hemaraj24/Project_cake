using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPages_Web : System.Web.UI.MasterPage
{
    #region "Declarations"


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
        lblCopyRight.Text = "&copy;  " + DateTime.Now.Year + " My Company. All Rights Reserved.";
    }

    #endregion


    #region "Control Events"

    #endregion
}
