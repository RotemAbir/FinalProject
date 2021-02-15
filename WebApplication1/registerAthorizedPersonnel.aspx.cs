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
    public partial class registerAthorizedPersonnel : System.Web.UI.Page
    {

        public void Button_Click(object sender, EventArgs e)
        {
            Object o = ConfigurationManager.ConnectionStrings;
            Object o2 = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            connection.Open();
            System.Text.StringBuilder displayValues =
            new System.Text.StringBuilder();

            try
            {
                string sql = "INSERT INTO AuthorziedPersonnel (visitorID,firstName,lastName,phone,aptNumber,visitDate,purposeOfVisit) values (@ID,@fName,@lName,@phone,@apt,@date,@visit)";
                SqlCommand cmd = new SqlCommand(sql, connection);

                cmd.Parameters.Add("@ID", SqlDbType.Int);
                int IDD = int.Parse(ID.Value);
                cmd.Parameters["@ID"].Value = IDD;

                cmd.Parameters.Add("@fName", SqlDbType.VarChar);
                string first = fName.Value;
                cmd.Parameters["@fName"].Value = first;

                cmd.Parameters.Add("@lName", SqlDbType.VarChar);
                string last = lName.Value;
                cmd.Parameters["@lName"].Value = last;

                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                string num = phone.Value;
                cmd.Parameters["@phone"].Value = num;

                cmd.Parameters.Add("@apt", SqlDbType.TinyInt);
                int aptt = int.Parse(apt.Value);
                cmd.Parameters["@apt"].Value = aptt;

                cmd.Parameters.Add("@date", SqlDbType.DateTime);
                DateTime ddt = DateTime.Parse(date.Value);
                cmd.Parameters["@date"].Value = ddt;

                cmd.Parameters.Add("@visit", SqlDbType.VarChar);
                string visitt = visit.Value;
                cmd.Parameters["@visit"].Value = visitt;

                cmd.ExecuteNonQuery();
            }


            catch
            {
                Response.Write("<script>alert('בבקשה הכנס מספר דירה תקני');</script>");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}