using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class showAuthorizedPersonnel : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            Object o = ConfigurationManager.ConnectionStrings;
            Object o2 = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            connection.Open();
            System.Text.StringBuilder displayValues =
            new System.Text.StringBuilder();

            string sql = "SELECT aptNum FROM AuthorizedPersonnel";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<string> str = new List<string>();
            //int i = 0;
            while (reader.Read())
            {
                str.Add(reader.GetValue(0).ToString());
            }
            reader.Close();

            //List.Items.Add(new ListItem(txt_box1.Text));
        }
    }
}