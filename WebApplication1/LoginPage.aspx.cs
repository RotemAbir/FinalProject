using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data;
using System.Web.Security;

namespace WebApplication1
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Button_Click(object sender, EventArgs e)
        {

            /* Object o = ConfigurationManager.ConnectionStrings;
             Object o2 = ConfigurationManager.ConnectionStrings["DefaultConnection"];
             SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
             connection.Open();
             System.Text.StringBuilder displayValues =
             new System.Text.StringBuilder();*/

               string cmdText = @"SELECT ID,currentPassword FROM Users 
                           WHERE ID = @name AND currentPassword = @pass";

                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
                using (SqlCommand SelectCommand = new SqlCommand(cmdText, cnn))
                {
                    SelectCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = user.Text;
                    SelectCommand.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass.Text;
                    cnn.Open();
                   SqlDataReader myReader = SelectCommand.ExecuteReader();
                    using (myReader = SelectCommand.ExecuteReader())
                    {

                        if (myReader.HasRows)
                        {
                            string script = "alert(\"Login successful!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                        else
                        {
                            string script = "alert(\"Login Failed!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                }  
           
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
    }
}