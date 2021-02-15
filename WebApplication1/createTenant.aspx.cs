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
    public partial class createTenant : System.Web.UI.Page
    {
        public void Button_Click(object sender, EventArgs e)
        {

            Object o = ConfigurationManager.ConnectionStrings;
            Object o2 = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            connection.Open();
            System.Text.StringBuilder displayValues =
            new System.Text.StringBuilder();

            string sqlUser = "INSERT INTO Users (ID,currentPassword,typeOfUser) values (@tenant,@pass,@user)";
            SqlCommand cmdUser = new SqlCommand(sqlUser, connection);

            cmdUser.Parameters.Add("@tenant", SqlDbType.Int);
            int tttenent = int.Parse(tenant.Value);
            cmdUser.Parameters["@tenant"].Value = tttenent;

            cmdUser.Parameters.Add("@pass", SqlDbType.VarChar);
            string password = pass.Value;
            cmdUser.Parameters["@pass"].Value = password;

            cmdUser.Parameters.Add("@user", SqlDbType.VarChar);
            cmdUser.Parameters["@user"].Value = "neighbor";


          string sqlTenant = "INSERT INTO Neighbors (ID,firstName,lastName,phone,email,apt_number,floorNumber,numOfRooms,isOwner,typeOfUser,buildingIdentifier) values (@tenant,@fName,@lName,@phone,@email,@apt,@floor,@rooms,@owner,@user,@build)";
            SqlCommand cmdTenant = new SqlCommand(sqlTenant, connection);

            cmdTenant.Parameters.Add("@tenant", SqlDbType.Int);
            int tenantt = int.Parse(tenant.Value);
            cmdTenant.Parameters["@tenant"].Value = tenantt;

            cmdTenant.Parameters.Add("@fName", SqlDbType.VarChar);
            string first = fName.Value;
            cmdTenant.Parameters["@fName"].Value = first;

            cmdTenant.Parameters.Add("@lName", SqlDbType.VarChar);
            string last = lName.Value;
            cmdTenant.Parameters["@lName"].Value = last;

            cmdTenant.Parameters.Add("@phone", SqlDbType.Int);
            int phonee = int.Parse(phone.Value);
            cmdTenant.Parameters["@phone"].Value = phonee;

            cmdTenant.Parameters.Add("@email", SqlDbType.VarChar);
            string emaill = email.Value;
            cmdTenant.Parameters["@email"].Value = emaill;

            cmdTenant.Parameters.Add("@apt", SqlDbType.Int);
            int aptt = int.Parse(apt.Value);
            cmdTenant.Parameters["@apt"].Value = aptt;

            cmdTenant.Parameters.Add("@floor", SqlDbType.Int);
            int florr = int.Parse(floor.Value);
            cmdTenant.Parameters["@floor"].Value = florr;

            cmdTenant.Parameters.Add("@rooms", SqlDbType.Int);
            int room = int.Parse(rooms.Value);
            cmdTenant.Parameters["@rooms"].Value = room;

            if (owner.Checked == true)
            {
                cmdTenant.Parameters.Add("@owner", SqlDbType.VarChar);
                cmdTenant.Parameters["@owner"].Value = 'Y';
            } 
            else
            {
                cmdTenant.Parameters.Add("@owner", SqlDbType.VarChar);
                cmdTenant.Parameters["@owner"].Value = 'N';

            }

            cmdTenant.Parameters.Add("@user", SqlDbType.VarChar);
            cmdTenant.Parameters["@user"].Value = "neighbor";

            cmdTenant.Parameters.Add("@build", SqlDbType.Int);
            int building = int.Parse(build.Value);
            cmdTenant.Parameters["@build"].Value = building;

           cmdUser.ExecuteNonQuery();
          cmdTenant.ExecuteNonQuery();

            Response.Redirect("afterCreate.aspx");
        }

        

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}