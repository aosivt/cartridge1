using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace cartridge
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.func_con();
        }
        public void func_con()
        {

            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();

            DataSet DS = new DataSet();
            con.ConnectionString = "Data Source=SERVER-MON\\SQLEXPRESS;Initial Catalog=cartridge;User ID=frost;Password=452698745563";
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT     name_cart.name_cart AS [Наименование картриджа], printers.printer AS [Наименование принтера], sum.col AS [Общее количество], "+
            "sum.fill_col AS [Количество заправленных картриджей] " +
            "FROM         name_cart INNER JOIN "+
            "sum ON name_cart.id_cart = sum.id_cart INNER JOIN "+
            "printers ON sum.id_pri = printers.id_pr";
            com.ExecuteScalar();
            SqlDataAdapter DA = new SqlDataAdapter(com);

            DA.Fill(DS, "name_cart");
            reestr.DataSource = DS;
            reestr.DataMember = "name_cart";
            reestr.DataBind();
            con.Close();
            
        }
    }
}
