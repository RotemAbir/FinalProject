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
    public partial class payments : System.Web.UI.Page
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

                string sql = "SELECT tenantID, paymentReason, amount, paymentStatus FROM TenantPayment";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell ID = new TableCell();
                    TableCell reason = new TableCell();
                    TableCell amount = new TableCell();
                    TableCell status = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    ID.Text += reader["tenantID"];
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    reason.Text += reader["paymentReason"];
                    row.Cells.Add(reason);
                    row.Cells.Add(reason);
                    row.Cells.Add(reason);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    amount.Text += reader["amount"];
                    row.Cells.Add(amount);
                    row.Cells.Add(amount);
                    row.Cells.Add(amount);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    status.Text += reader["paymentStatus"];
                    row.Cells.Add(status);
                    row.Cells.Add(status);
                    row.Cells.Add(status);


                }
            }

            else if (List.SelectedValue == "Closed")
            {

                string sql = "SELECT tenantID, paymentReason, amount, paymentStatus FROM TenantPayment WHERE paymentStatus='closed' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell ID = new TableCell();
                    TableCell reason = new TableCell();
                    TableCell amount = new TableCell();
                    TableCell status = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    ID.Text += reader["tenantID"];
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    reason.Text += reader["paymentReason"];
                    row.Cells.Add(reason);
                    row.Cells.Add(reason);
                    row.Cells.Add(reason);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    amount.Text += reader["amount"];
                    row.Cells.Add(amount);
                    row.Cells.Add(amount);
                    row.Cells.Add(amount);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    status.Text += reader["paymentStatus"];
                    row.Cells.Add(status);
                    row.Cells.Add(status);
                    row.Cells.Add(status);
                }
            }
            else if (List.SelectedValue == "Open")
            {

                string sql = "SELECT tenantID, paymentReason, amount, paymentStatus FROM TenantPayment WHERE paymentStatus='open' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell ID = new TableCell();
                    TableCell reason = new TableCell();
                    TableCell amount = new TableCell();
                    TableCell status = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    ID.Text += reader["tenantID"];
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    reason.Text += reader["paymentReason"];
                    row.Cells.Add(reason);
                    row.Cells.Add(reason);
                    row.Cells.Add(reason);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    amount.Text += reader["amount"];
                    row.Cells.Add(amount);
                    row.Cells.Add(amount);
                    row.Cells.Add(amount);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    status.Text += reader["paymentStatus"];
                    row.Cells.Add(status);
                    row.Cells.Add(status);
                    row.Cells.Add(status);
                }

            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}