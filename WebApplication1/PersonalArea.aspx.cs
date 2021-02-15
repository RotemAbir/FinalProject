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
    public partial class PersonalArea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Object o = ConfigurationManager.ConnectionStrings;
            Object o2 = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            connection.Open();
            System.Text.StringBuilder displayValues =
            new System.Text.StringBuilder();

            string sql = "SELECT ID, firstName,lastName, buildingIdentifier, apt_number, floorNumber FROM Neighbors where ID = '313234189'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Label first;
                Label last;
                Label space;
                first = new Label();
                last = new Label();
                space = new Label();
                first.Text += reader["firstName"];
                space.Text += " ";
                last.Text += reader["lastName"];
                Name.Controls.Add(first);
                Name.Controls.Add(space);
                Name.Controls.Add(last);

                Label build;
                Label apt;
                Label floor;
               
                build = new Label();
                apt = new Label();
                space = new Label();
                floor = new Label();
                build.Text += reader["buildingIdentifier"];
                space.Text += " ";
                apt.Text += reader["apt_number"];
                space.Text += " ";
                floor.Text += reader["floorNumber"];
                Num.Controls.Add(build);
                
                Apt.Controls.Add(apt);
               
                Floor.Controls.Add(floor);
            }

        }

        public void Button_Click(object sender, EventArgs e)
        {
            Object o = ConfigurationManager.ConnectionStrings;
            Object o2 = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            connection.Open();
            System.Text.StringBuilder displayValues =
            new System.Text.StringBuilder();

            string sql = "SELECT tenantID, paymentID, paymentReason, amount, paymentDate, paymentStatus FROM TenantPayment where tenantID = '313234189'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                TableRow row = new TableRow();
                TableCell ID = new TableCell();
                TableCell Reason = new TableCell();
                TableCell Amount = new TableCell();
                TableCell Date = new TableCell();
                TableCell Status = new TableCell();
                TableCell empty = new TableCell();
                PaymentTable.Rows.Add(row);


                ID.Text += reader["paymentID"];
                row.Cells.Add(ID);
                row.Cells.Add(ID);
                row.Cells.Add(ID);

                empty.Text += " ";
                row.Cells.Add(empty);
                row.Cells.Add(empty);
                row.Cells.Add(empty);

                Reason.Text += reader["paymentReason"];
                row.Cells.Add(Reason);
                row.Cells.Add(Reason);
                row.Cells.Add(Reason);

                empty.Text += " ";
                row.Cells.Add(empty);
                row.Cells.Add(empty);
                row.Cells.Add(empty);

                Amount.Text += reader["amount"];
                row.Cells.Add(Amount);
                row.Cells.Add(Amount);
                row.Cells.Add(Amount);

                empty.Text += " ";
                row.Cells.Add(empty);
                row.Cells.Add(empty);
                row.Cells.Add(empty);

                Date.Text += reader["paymentDate"];
                row.Cells.Add(Date);
                row.Cells.Add(Date);
                row.Cells.Add(Date);

                empty.Text += " ";
                row.Cells.Add(empty);
                row.Cells.Add(empty);
                row.Cells.Add(empty);

                Status.Text += reader["paymentStatus"];
                row.Cells.Add(Status);
                row.Cells.Add(Status);
                row.Cells.Add(Status);

            }

        }

        public void Payment(object sender, EventArgs e)
        {

            Response.Redirect("tenantPayment.aspx");


        }
    }
}