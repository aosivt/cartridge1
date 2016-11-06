using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace cartridge
{
    

    public partial class nameCart : System.Web.UI.Page
    {
        string id_cart;
        
        string id_print = "0";
        string text_print;

        string id_sec;
        string text_sec;

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();


        public void func_enter_cart()
        {
            if (this.TextBox1.Text.Length < 1 || this.TextBox3.Text.Length < 1 || this.TextBox4.Text.Length < 1)
            {
                Response.Write("<script>alert('Пустое наименование')</script>");
            }
            else
            {
                con.ConnectionString = "Data Source=SERVER-MON\\SQLEXPRESS;Initial Catalog=cartridge;User ID=frost;Password=452698745563";
                con.Open();

                com.Connection = con;

                com.CommandText = "INSERT INTO [cartridge].[dbo].[name_cart] ([name_cart]) VALUES"
                                    + " ('" + this.TextBox1.Text + "')";

                com.ExecuteNonQuery();

                com.CommandText = "select max(id_cart) from name_cart";

                id_cart = com.ExecuteScalar().ToString();

                if (this.TextBox2.Text.Length > 1)
                {
                    this.text_print = this.TextBox2.Text.ToString();
                    com.CommandText = "INSERT INTO [cartridge].[dbo].[printers] ([printer]) VALUES"
                    + " ('" + this.text_print + "')";
                    com.ExecuteNonQuery();
                    com.CommandText = "select max(id_pr) from [printers]";
                    this.id_print = com.ExecuteScalar().ToString();

                }
                else
                {
                    this.id_print = this.DropDownList2.SelectedItem.Value.ToString();
                    //this.text_print = this.DropDownList2.SelectedItem.Value.ToString();
                    //com.CommandText = "select id_pr from [printers] where [printers].[printer] = '" + this.text_print + "'";
                    //this.id_print = this.com.ExecuteScalar().ToString();
                    //this.id_print = this.DropDownList2.SelectedValue.ToString();
                }

                com.CommandText = "INSERT INTO [cartridge].[dbo].[sum] ([id_pri],[id_cart],[col],[fill_col]) VALUES"
                    + " (" + this.id_print + "," + this.id_cart + "," + this.TextBox3.Text.ToString() + "," + this.TextBox4.Text.ToString() + ")";
                com.ExecuteNonQuery();

                // Response.Write("<script>alert('"+ id_cart + "')</script>");

                con.Close();

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

           
                con.ConnectionString = "Data Source=SERVER-MON\\SQLEXPRESS;Initial Catalog=cartridge;User ID=frost;Password=452698745563";
                con.Open();

                if (Page.IsPostBack)
                {
                  //  con.Close();
                  //  this.func_enter_cart();
                    // Response.Write("<script>alert('Работает не?')</script>");

                }
                else
                {
                    try
                    {
                        DataSet DS_pri = new DataSet();
                        com.Connection = con;
                        com.CommandText = "SELECT *  FROM [cartridge].[dbo].[printers]";
                        com.ExecuteScalar();
                        SqlDataAdapter DA_pri = new SqlDataAdapter(com);

                        DA_pri.Fill(DS_pri, "printers");
                        this.DropDownList2.DataSource = DS_pri.Tables[0];
                        this.DropDownList2.DataValueField = "id_pr";
                        this.DropDownList2.DataTextField = "printer";
                        this.DropDownList2.DataBind();

                        DataSet DS_sec = new DataSet();
                        com.Connection = con;
                        com.CommandText = "SELECT *  FROM [cartridge].[dbo].[sec]";
                        com.ExecuteScalar();
                        SqlDataAdapter DA_sec = new SqlDataAdapter(com);


                    }
                    catch
                    {
                        Response.Write("<script>alert('Одное из наименований пустое')</script>");
                    }
                }
                con.Close();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.id_print = "123";

            func_enter_cart();

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