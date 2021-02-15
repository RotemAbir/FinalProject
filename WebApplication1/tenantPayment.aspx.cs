using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        public void Button_Click(object sender, EventArgs e)
        {

            Object o = ConfigurationManager.ConnectionStrings;
            Object o2 = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            connection.Open();
            System.Text.StringBuilder displayValues =
            new System.Text.StringBuilder();


            string sql = "INSERT INTO TenantPayment (tenantID,paymentID,paymentReason,amount,paymentDate,paymentStatus) values (@tenant,@payment,@reason,@amount,@date,@status)";
            SqlCommand cmd = new SqlCommand(sql, connection);

            cmd.Parameters.Add("@tenant", SqlDbType.Int);
            int tttenent = int.Parse(tenant.Value);
            cmd.Parameters["@tenant"].Value = tttenent;

            Random rnd = new Random();
            int num = rnd.Next(1, 10000);
            cmd.Parameters.Add("@payment", SqlDbType.Int);
            int paymentt =num;
            cmd.Parameters["@payment"].Value = paymentt;

            cmd.Parameters.Add("@reason", SqlDbType.VarChar);
            string reasonn = reason.Value;
            cmd.Parameters["@reason"].Value = reasonn;

            cmd.Parameters.Add("@amount", SqlDbType.Int);
            int amountt = int.Parse(amount.Value);
            cmd.Parameters["@amount"].Value = amountt;

            cmd.Parameters.Add("@date", SqlDbType.DateTime);
            DateTime ddt = DateTime.Parse(date.Value);
            cmd.Parameters["@date"].Value = ddt;

            cmd.Parameters.Add("@status", SqlDbType.VarChar);
            cmd.Parameters["@status"].Value = "open";

            cmd.ExecuteNonQuery();

            Response.Redirect("afterPayment.aspx");


        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}