using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Pages_ReceiverDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        deliveryDate.Attributes["min"] = DateTime.Now.ToString("yyyy-MM-dd");
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        string ConString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/DemoDb.mdb";

        var name = fullName.Text;
        var deliverTo = address.Text;
        var dateTime = deliveryDate.Text;
        var messages = message.Text;
        var place = city.Text;
        var mobile = phone.Text;

        if (Page.IsValid)
        {
            OleDbConnection Con = new OleDbConnection(ConString);
            OleDbCommand Command = Con.CreateCommand();
            Con.Open();
            Command.CommandText = "INSERT INTO ReceiverDetails (Receiver_Full_Name, Delivery_Address, Delivery_Date, Message_On_Cake, Delivery_City, Receiver_Mobile_No) "
                                    + "VALUES ('" + name + "','" + deliverTo + "','" + dateTime + "','" + messages + "','" + place + "','" + mobile + "')";
            Command.ExecuteNonQuery();
            Con.Close();

            Response.Redirect("SenderPaymentDetails.aspx");
        }
    }
}