using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Pages_Bouquets : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_Click(object sender, EventArgs e)
    {
        string ConString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/DemoDb.mdb";

        Button clickedButton = (Button)sender;
        var data = clickedButton.CommandArgument.Split(',');
        var price = data[0];
        var cakeName = data[1];

        OleDbConnection Con = new OleDbConnection(ConString);
        OleDbCommand Command = Con.CreateCommand();
        Con.Open();
        Command.CommandText = "INSERT INTO OrderDetails (NAME_OF_THE_PRODUCT,PRICE_OF_THE_PRODUCT) VALUES ('" + cakeName + "','" + price + "')";
        Command.ExecuteNonQuery();
        Con.Close();
    }
}