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
    public partial class ReportingIssue : System.Web.UI.Page
    {

        public void Button_Click(object sender, EventArgs e)
        {
            Object o = ConfigurationManager.ConnectionStrings;
            Object o2 = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            connection.Open();
            System.Text.StringBuilder displayValues =
            new System.Text.StringBuilder();
            Random rnd = new Random();
            int num = rnd.Next(1, 10000);

            string sql = "INSERT INTO IssuesAndRequests (issueID,tenantID,issueType,dateOfOpen,issueDescription,typeOfUser,issueStatus) values (@ID,@tenant,@isuue,@Odate,@problemSummary,@typeOfUser,@issueStatus)";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.Add("@ID", SqlDbType.Int);
            int IDD = num;
            cmd.Parameters["@ID"].Value = IDD;
                cmd.Parameters.Add("@tenant", SqlDbType.Int);
                int tttenent = int.Parse(tenant.Value);
                cmd.Parameters["@tenant"].Value = tttenent;
                cmd.Parameters.Add("@isuue", SqlDbType.VarChar);
                cmd.Parameters["@isuue"].Value = dropDown.SelectedItem.ToString();
                cmd.Parameters.Add("@Odate", SqlDbType.DateTime);
                DateTime ddt = DateTime.Parse(Odate.Value);
                cmd.Parameters["@Odate"].Value = ddt;
                cmd.Parameters.Add("@problemSummary", SqlDbType.VarChar);
                String xxx = problemSummary.Value;
                cmd.Parameters["@problemSummary"].Value = xxx;
                cmd.Parameters.Add("@typeOfUser", SqlDbType.VarChar);
                cmd.Parameters["@typeOfUser"].Value = "neighbor";
                cmd.Parameters.Add("@issueStatus", SqlDbType.VarChar);
                cmd.Parameters["@issueStatus"].Value = "open";
                cmd.ExecuteNonQuery();
  

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}