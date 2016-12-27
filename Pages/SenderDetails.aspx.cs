using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Pages_SenderDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_Click(object sender, EventArgs e)
    {
        string ConString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/DemoDb.mdb";

        var email = emailId.Text;
        var name = fullName.Text;
        var mobile = phone.Text;

        if (Page.IsValid)
        {
            OleDbConnection Con = new OleDbConnection(ConString);
            OleDbCommand Command = Con.CreateCommand();
            Con.Open();
            Command.CommandText = "INSERT INTO SenderDetails (Full_Name, Email_id, Mobile_No) VALUES ('" + name + "','" + email + "','" + mobile + "')";
            Command.ExecuteNonQuery();
            Con.Close();

            Response.Redirect("ReceiverDetails.aspx");
        }
    }
}