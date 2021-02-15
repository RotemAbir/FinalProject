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
    public partial class showBuildingServices : System.Web.UI.Page
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
                string sql = "SELECT typeOfService,serviceDescription,price,buildingIndentfier FROM BuildingServices";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell des = new TableCell();
                    TableCell type = new TableCell();
                    TableCell price = new TableCell();
                    TableCell ID = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    type.Text += reader["typeOfService"];
                    row.Cells.Add(type);
                    row.Cells.Add(type);
                    row.Cells.Add(type);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    des.Text += reader["serviceDescription"];
                    row.Cells.Add(des);
                    row.Cells.Add(des);
                    row.Cells.Add(des);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    price.Text += reader["price"];
                    row.Cells.Add(price);
                    row.Cells.Add(price);
                    row.Cells.Add(price);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    ID.Text += reader["buildingIndentfier"];
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);

                }

            }

            else if (List.SelectedValue == "pool")
            {
                string sql = "SELECT typeOfService,serviceDescription,price,buildingIndentfier FROM BuildingServices WHERE serviceDescription='מציל' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell des = new TableCell();
                    TableCell type = new TableCell();
                    TableCell price = new TableCell();
                    TableCell ID = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    type.Text += reader["serviceDescription"];
                    row.Cells.Add(type);
                    row.Cells.Add(type);
                    row.Cells.Add(type);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    des.Text += reader["typeOfService"];
                    row.Cells.Add(des);
                    row.Cells.Add(des);
                    row.Cells.Add(des);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    price.Text += reader["price"];
                    row.Cells.Add(price);
                    row.Cells.Add(price);
                    row.Cells.Add(price);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    ID.Text += reader["buildingIndentfier"];
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);

                }

            }

            else if (List.SelectedValue == "gym")
            {
                string sql = "SELECT typeOfService,serviceDescription,price,buildingIndentfier FROM BuildingServices WHERE serviceDescription='מדריך חדר כושר' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell des = new TableCell();
                    TableCell type = new TableCell();
                    TableCell price = new TableCell();
                    TableCell ID = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    type.Text += reader["serviceDescription"];
                    row.Cells.Add(type);
                    row.Cells.Add(type);
                    row.Cells.Add(type);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    des.Text += reader["typeOfService"];
                    row.Cells.Add(des);
                    row.Cells.Add(des);
                    row.Cells.Add(des);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    price.Text += reader["price"];
                    row.Cells.Add(price);
                    row.Cells.Add(price);
                    row.Cells.Add(price);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    ID.Text += reader["buildingIndentfier"];
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);

                }
            }

            else if (List.SelectedValue == "service")
            {
                string sql = "SELECT typeOfService,serviceDescription,price,buildingIndentfier FROM BuildingServices WHERE serviceDescription='תחזוקה' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell des = new TableCell();
                    TableCell type = new TableCell();
                    TableCell price = new TableCell();
                    TableCell ID = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row);


                    type.Text += reader["serviceDescription"];
                    row.Cells.Add(type);
                    row.Cells.Add(type);
                    row.Cells.Add(type);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    des.Text += reader["typeOfService"];
                    row.Cells.Add(des);
                    row.Cells.Add(des);
                    row.Cells.Add(des);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    price.Text += reader["price"];
                    row.Cells.Add(price);
                    row.Cells.Add(price);
                    row.Cells.Add(price);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    ID.Text += reader["buildingIndentfier"];
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);

                }
            }

            else if (List.SelectedValue == "security")
            {
                string sql = "SELECT typeOfService,serviceDescription,price,buildingIndentfier FROM BuildingServices WHERE serviceDescription='אבטחה' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell des = new TableCell();
                    TableCell type = new TableCell();
                    TableCell price = new TableCell();
                    TableCell ID = new TableCell();
                    TableCell empty = new TableCell();
                    BulidingsTable.Rows.Add(row); ;


                    type.Text += reader["serviceDescription"];
                    row.Cells.Add(type);
                    row.Cells.Add(type);
                    row.Cells.Add(type);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    des.Text += reader["typeOfService"];
                    row.Cells.Add(des);
                    row.Cells.Add(des);
                    row.Cells.Add(des);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    price.Text += reader["price"];
                    row.Cells.Add(price);
                    row.Cells.Add(price);
                    row.Cells.Add(price);

                    empty.Text += " ";
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);
                    row.Cells.Add(empty);

                    ID.Text += reader["buildingIndentfier"];
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);
                    row.Cells.Add(ID);

                }

            }



        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}