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

    public partial class Issues : System.Web.UI.Page
    {
        public void Button_Click(object sender, EventArgs e)
        {
            Object o = ConfigurationManager.ConnectionStrings;
            Object o2 = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            connection.Open();
            System.Text.StringBuilder displayValues =
            new System.Text.StringBuilder();

            if (List.SelectedValue == "All")
            {
                string sql = "SELECT issueID,issueType,dateOfOpen,issueDescription,issueStatus FROM IssuesAndRequests";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell ID = new TableCell();
                    TableCell IsuueType = new TableCell();
                    TableCell oDate = new TableCell();
                    TableCell status = new TableCell();
                    TableCell Summary = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    ID.Text += reader["issueID"];
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    IsuueType.Text += reader["issueType"];
                    row.Cells.Add(IsuueType);
                    row.Cells.Add(IsuueType);
                    row.Cells.Add(IsuueType);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    oDate.Text += reader["dateOfOpen"];
                    row.Cells.Add(oDate);
                    row.Cells.Add(oDate);
                    row.Cells.Add(oDate);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    Summary.Text += reader["issueDescription"];
                    row.Cells.Add(Summary);
                    row.Cells.Add(Summary);
                    row.Cells.Add(Summary);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    status.Text += reader["issueStatus"];
                    row.Cells.Add(status);
                    row.Cells.Add(status);
                    row.Cells.Add(status);



                }

            }
            else if (List.SelectedValue == "InProgress")
            {
                string sql = "SELECT issueID,issueType,dateOfOpen,issueDescription,issueStatus FROM IssuesAndRequests WHERE issueStatus='in progress' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell ID = new TableCell();
                    TableCell IsuueType = new TableCell();
                    TableCell oDate = new TableCell();
                    TableCell status = new TableCell();
                    TableCell Summary = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    ID.Text += reader["issueID"];
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    IsuueType.Text += reader["issueType"];
                    row.Cells.Add(IsuueType);
                    row.Cells.Add(IsuueType);
                    row.Cells.Add(IsuueType);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    oDate.Text += reader["dateOfOpen"];
                    row.Cells.Add(oDate);
                    row.Cells.Add(oDate);
                    row.Cells.Add(oDate);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    Summary.Text += reader["issueDescription"];
                    row.Cells.Add(Summary);
                    row.Cells.Add(Summary);
                    row.Cells.Add(Summary);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    status.Text += reader["issueStatus"];
                    row.Cells.Add(status);
                    row.Cells.Add(status);
                    row.Cells.Add(status);

                }

            }

            else if (List.SelectedValue == "Open")
            {
                string sql = "SELECT issueID,issueType,dateOfOpen,issueDescription,issueStatus FROM IssuesAndRequests WHERE issueStatus='open' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell ID = new TableCell();
                    TableCell IsuueType = new TableCell();
                    TableCell oDate = new TableCell();
                    TableCell status = new TableCell();
                    TableCell Summary = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    ID.Text += reader["issueID"];
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    IsuueType.Text += reader["issueType"];
                    row.Cells.Add(IsuueType);
                    row.Cells.Add(IsuueType);
                    row.Cells.Add(IsuueType);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    oDate.Text += reader["dateOfOpen"];
                    row.Cells.Add(oDate);
                    row.Cells.Add(oDate);
                    row.Cells.Add(oDate);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    Summary.Text += reader["issueDescription"];
                    row.Cells.Add(Summary);
                    row.Cells.Add(Summary);
                    row.Cells.Add(Summary);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    status.Text += reader["issueStatus"];
                    row.Cells.Add(status);
                    row.Cells.Add(status);
                    row.Cells.Add(status);

                }
            }

            else if (List.SelectedValue == "Closed")
            {
                string sql = "SELECT issueID,issueType,dateOfOpen,issueDescription,issueStatus FROM IssuesAndRequests WHERE issueStatus='closed' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell ID = new TableCell();
                    TableCell IsuueType = new TableCell();
                    TableCell oDate = new TableCell();
                    TableCell status = new TableCell();
                    TableCell Summary = new TableCell();
                    TableCell cDate = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    ID.Text += reader["issueID"];
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    IsuueType.Text += reader["issueType"];
                    row.Cells.Add(IsuueType);
                    row.Cells.Add(IsuueType);
                    row.Cells.Add(IsuueType);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    oDate.Text += reader["dateOfOpen"];
                    row.Cells.Add(oDate);
                    row.Cells.Add(oDate);
                    row.Cells.Add(oDate);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    Summary.Text += reader["issueDescription"];
                    row.Cells.Add(Summary);
                    row.Cells.Add(Summary);
                    row.Cells.Add(Summary);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    status.Text += reader["issueStatus"];
                    row.Cells.Add(status);
                    row.Cells.Add(status);
                    row.Cells.Add(status);


                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    cDate.Text += reader["dateOfClose"];
                    row.Cells.Add(cDate);
                    row.Cells.Add(cDate);
                    row.Cells.Add(cDate);

                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}