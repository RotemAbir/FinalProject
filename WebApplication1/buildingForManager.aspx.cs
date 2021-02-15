using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Sql;


namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public void Button_Click(object sender, EventArgs e)
        {
            Object o = ConfigurationManager.ConnectionStrings;
            Object o2 = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            connection.Open();
            System.Text.StringBuilder displayValues =
            new System.Text.StringBuilder();

         

            if (List.SelectedValue == "1")
            {
                string sql = "SELECT ID, firstName,lastName,phone,email,apt_number,buildingIdentifier FROM Neighbors where buildingIdentifier = '1'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell nameCell = new TableCell();
                    TableCell name2Cell = new TableCell();
                    TableCell email = new TableCell();
                    TableCell apt = new TableCell();
                    TableCell build = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    nameCell.Text += reader["firstName"];
                    row.Cells.Add(nameCell);
                    row.Cells.Add(nameCell);
                    row.Cells.Add(nameCell);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    name2Cell.Text += reader["lastName"];
                    row.Cells.Add(name2Cell);
                    row.Cells.Add(name2Cell);
                    row.Cells.Add(name2Cell);

                    nameCell.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    email.Text += reader["email"];
                    row.Cells.Add(email);
                    row.Cells.Add(email);
                    row.Cells.Add(email);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    apt.Text += reader["apt_number"];
                    row.Cells.Add(apt);
                    row.Cells.Add(apt);
                    row.Cells.Add(apt);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    build.Text += reader["buildingIdentifier"];
                    row.Cells.Add(build);
                    row.Cells.Add(build);
                    row.Cells.Add(build);

                }

            }
            else
            {
                string sql = "SELECT ID, firstName,lastName,phone,email,apt_number,buildingIdentifier FROM Neighbors where buildingIdentifier = '2'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell nameCell = new TableCell();
                    TableCell name2Cell = new TableCell();
                    TableCell email = new TableCell();
                    TableCell apt = new TableCell();
                    TableCell build = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    nameCell.Text += reader["firstName"];
                    row.Cells.Add(nameCell);
                    row.Cells.Add(nameCell);
                    row.Cells.Add(nameCell);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    name2Cell.Text += reader["lastName"];
                    row.Cells.Add(name2Cell);
                    row.Cells.Add(name2Cell);
                    row.Cells.Add(name2Cell);

                    nameCell.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    email.Text += reader["email"];
                    row.Cells.Add(email);
                    row.Cells.Add(email);
                    row.Cells.Add(email);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    apt.Text += reader["apt_number"];
                    row.Cells.Add(apt);
                    row.Cells.Add(apt);
                    row.Cells.Add(apt);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    build.Text += reader["buildingIdentifier"];
                    row.Cells.Add(build);
                    row.Cells.Add(build);
                    row.Cells.Add(build);

                }

            }
        }
        protected void Page_Load(object sender, EventArgs e) {
   
              
       }
    }

}