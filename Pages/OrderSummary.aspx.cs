using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Pages_OrderSummary : System.Web.UI.Page
{
    string ConString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/DemoDb.mdb";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection Con = new OleDbConnection(ConString);
        OleDbCommand Command = Con.CreateCommand();
        Con.Open();
        Command.CommandText = "SELECT SUM(PRICE_OF_THE_PRODUCT) as TOTAL FROM OrderDetails WHERE PAID = false";
        var data = Command.ExecuteReader();
        var sum = "";
        while (data.Read())
        {
            sum = data[0].ToString();
        }
        data.Close();
        Con.Close();

        if (sum != "")
            Response.Redirect("SenderDetails.aspx");

    }

    protected void orders_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "deleteRecord")
            {
                var itemId = int.Parse(e.CommandArgument.ToString());

                OleDbConnection Con = new OleDbConnection(ConString);
                OleDbCommand Command = Con.CreateCommand();
                Con.Open();
                Command.CommandText = "DELETE * FROM OrderDetails WHERE ID=" + itemId;
                Command.ExecuteNonQuery();
                Con.Close();
                Response.Redirect("OrderSummary.aspx");
            }
        }
        catch (Exception exception)
        {

        }
    }
}