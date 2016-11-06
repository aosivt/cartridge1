using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace cartridge
{
    public partial class update_re : System.Web.UI.Page
    {
        string id_cart;

        string id_print;
        string text_print;

        string id_sec;
        string text_sec;

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=SERVER-MON\\SQLEXPRESS;Initial Catalog=cartridge;User ID=frost;Password=452698745563";
            con.Open();

            try
            {
                DataSet DS_pri = new DataSet();
                com.Connection = con;
                com.CommandText = "SELECT *  FROM [cartridge].[dbo].[printers]";
                com.ExecuteScalar();
                SqlDataAdapter DA_pri = new SqlDataAdapter(com);

                DA_pri.Fill(DS_pri, "printers");
                this.DropDownList1.DataSource = DS_pri.Tables[0];
                this.DropDownList1.DataValueField = "id_pr";
                this.DropDownList1.DataTextField = "printer";
                this.DropDownList1.DataBind();

                DataSet DS_sec = new DataSet();
                com.Connection = con;
                com.CommandText = "SELECT *  FROM [cartridge].[dbo].[sec]";
                com.ExecuteScalar();
                SqlDataAdapter DA_sec = new SqlDataAdapter(com);

                DA_sec.Fill(DS_sec, "dbo.sec");
                this.DropDownList2.DataSource = DS_sec.Tables[0];
                this.DropDownList2.DataValueField = "id_sec";
                this.DropDownList2.DataTextField = "sec";
                this.DropDownList2.DataBind();

                DataSet DS_cart = new DataSet();
                com.Connection = con;
                com.CommandText = "SELECT *  FROM [cartridge].[dbo].[name_cart]";
                com.ExecuteScalar();
                SqlDataAdapter DA_cart = new SqlDataAdapter(com);

                DA_cart.Fill(DS_cart, "dbo.name_cart");
                this.DropDownList3.DataSource = DS_cart.Tables[0];
                this.DropDownList3.DataValueField = "id_cart";
                this.DropDownList3.DataTextField = "name_cart";
                this.DropDownList3.DataBind();
            }
            catch
            {
                Response.Write("<script>alert('Одное из наименований пустое')</script>");
            }

            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=SERVER-MON\\SQLEXPRESS;Initial Catalog=cartridge;User ID=frost;Password=452698745563";
            con.Open();

            com.Connection = con;
            com.CommandText = "DELETE FROM [cartridge].[dbo].[sum]";
            com.ExecuteNonQuery();
            com.CommandText = "DELETE FROM [cartridge].[dbo].[name_cart]";
            com.ExecuteNonQuery();
            com.CommandText = "DELETE FROM [cartridge].[dbo].[printers]";
            com.ExecuteNonQuery();
            com.CommandText = "DELETE FROM [cartridge].[dbo].[sec]";
            com.ExecuteNonQuery();

            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=SERVER-MON\\SQLEXPRESS;Initial Catalog=cartridge;User ID=frost;Password=452698745563";
            con.Open();

            com.Connection = con;
            com.CommandText = "DELETE FROM [cartridge].[dbo].[sum]";
            com.ExecuteNonQuery();
            com.CommandText = "DELETE FROM [cartridge].[dbo].[name_cart]";
            com.ExecuteNonQuery();
            com.CommandText = "DELETE FROM [cartridge].[dbo].[printers]";
            com.ExecuteNonQuery();
            com.CommandText = "DELETE FROM [cartridge].[dbo].[sec]";
            com.ExecuteNonQuery();

            con.Close();
        }
    }
}