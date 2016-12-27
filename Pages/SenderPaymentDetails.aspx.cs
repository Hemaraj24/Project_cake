using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

public partial class Pages_SenderPaymentDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 1; i <= 12; i++)
        {
            month.Items.Add(i.ToString());
        }

        for (int i = 0; i < 50; i++)
        {
            year.Items.Add(System.DateTime.Now.AddYears(i).Year.ToString());
        }
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        string ConString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/DemoDb.mdb";

        try
        {
            var type = cardType.SelectedValue;
            var debit = type == "Debit" ? 1 : 0;
            var credit = type == "Credit" ? 1 : 0;
            var cardNo = cardNumber.Text;
            var user = userName.Text;
            var cvvNo = cvv.Text;
            var expiryMonth = month.Text;
            var expiryYear = year.Text;
            var expiryDate = new DateTime(int.Parse(expiryYear), int.Parse(expiryMonth), 1).ToString("yyyy-MM-dd");
            var today = DateTime.Today.ToString("yyyy-MM-dd");

            OleDbConnection Con = new OleDbConnection(ConString);
            OleDbCommand Command = Con.CreateCommand();
            Con.Open();
            Command.CommandText = "INSERT INTO SenderPaymentDetails (Debit, Credit, Card_Number, Name_on_Card, CVV_Number, Expiry_date, Payment_Date) VALUES "
                                    + "('" + debit + "','" + credit + "','" + cardNo + "','" + user + "','" + cvvNo + "','" + expiryDate + "','" + today + "')";
            Command.ExecuteNonQuery();

            Command.CommandText = "SELECT MAX(ORDER_NO) AS lastOrderNumber FROM OrderDetails";
            var data = Command.ExecuteReader();
            var lastOrderNumber = "";
            while (data.Read())
            {
                lastOrderNumber = data[0].ToString();
            }
            data.Close();
            var newOrderNumber = (lastOrderNumber == "") || (lastOrderNumber == null) ? 1 : int.Parse(lastOrderNumber) + 1;

            Command.CommandText = "UPDATE OrderDetails SET PAID = true, ORDER_NO = " + newOrderNumber + " where PAID = false";
            Command.ExecuteNonQuery();
            Con.Close();

            Response.Redirect("PaymentSummary.aspx");
        }
        catch (Exception exception)
        {

        }
    }
}