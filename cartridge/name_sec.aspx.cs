using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace cartridge
{
    public partial class name_sec : System.Web.UI.Page
    {
        
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

            }
            catch
            {
                Response.Write("<script>alert('Одное из наименований пустое')</script>");
            }

            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            func_enter_sec();
        }

                    public void func_enter_sec()
        {
            
                con.ConnectionString = "Data Source=SERVER-MON\\SQLEXPRESS;Initial Catalog=cartridge;User ID=frost;Password=452698745563";
                con.Open();

                com.Connection = con;

                
            

                    if (this.TextBox2.Text.Length > 1)
                    {
                        this.text_print = this.TextBox2.Text.ToString();
                        com.CommandText = "INSERT INTO [cartridge].[dbo].[printers] ([printer]) VALUES"
                        + " ('" + this.text_print + "')";
                        com.ExecuteNonQuery();
                        com.CommandText = "select max(id_pr) from [printers]";
                        this.id_print = com.ExecuteScalar().ToString();

                    }
                    else  if (this.TextBox2.Text.Length < 1)
                    {
                        // this.text_print = this.DropDownList2.Text.ToString();
                        // com.CommandText = "select id_pr from [printers] where [printers].[printer] = '"+ this.text_print + "'";
                        this.id_print = this.DropDownList1.SelectedValue.ToString();
                    }

                   

                if (this.TextBox1.Text.Length > 1)
                {
                    this.text_sec = this.TextBox1.Text.ToString();
                    com.CommandText = "INSERT INTO [cartridge].[dbo].[sec] ([sec]) VALUES"
                    + " ('" + this.text_sec + "')";
                    com.ExecuteNonQuery();
                    com.CommandText = "select max(id_sec) from [sec]";
                    this.id_sec = com.ExecuteScalar().ToString();

                }
                else if (this.TextBox1.Text.Length < 1)
                {
                    // this.text_print = this.DropDownList2.Text.ToString();
                    // com.CommandText = "select id_pr from [printers] where [printers].[printer] = '"+ this.text_print + "'";
                    this.id_sec = this.DropDownList2.SelectedValue.ToString();
                }

                com.CommandText = "update [cartridge].[dbo].[printers] set [id_sec] = " + id_sec + 
                    " where [id_pr] = " + this.id_print;


                
                com.ExecuteNonQuery();

                // Response.Write("<script>alert('"+ id_cart + "')</script>");

                con.Close();
            
        }
        }
   
}