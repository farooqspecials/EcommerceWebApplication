using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class salemanagement : System.Web.UI.Page
{

   dbcon obj = new dbcon();
   // public static string connectionString = "Data Source=FAROOQPC\\SQLEXPRESS; Initial Catalog=shop; Integrated Security=True";
    //string query = "select Sum(totalAmount) from Orders where OrderDate between '" + startDate + "' and '" + endDate + "'";
   
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string querydr = "select OrderDate from Orders";
            SqlDataReader dr = obj.fillcomb(querydr);
            DropDownList1.DataSource = dr;
            DropDownList1.DataValueField = "OrderDate";
            DropDownList1.DataBind();
            
        }

        if (!IsPostBack)
        {
            string querydr = "select OrderDate from Orders";
            SqlDataReader dr = obj.fillcomb(querydr);
            DropDownList2.DataSource = dr;
            DropDownList2.DataValueField = "OrderDate";
            DropDownList2.DataBind();

        }
   
       
    }

    public void bind()
    {
        //string query = "select * from ESK_Products";
        string query = "SELECT * FROM Orders Where OrderDate between '" + DropDownList1.Text + "' and '" + DropDownList2.Text + "'"; ;
        DataSet ds = obj.fillgrid(query);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bind();
      /*  
        try
        {
            SqlConnection MAconn = new SqlConnection();
            MAconn.ConnectionString = connectionString;
            MAconn.Open();
            //int c = System.Convert.ToInt32(txtamount.Text);

            SqlCommand MAcmd = MAconn.CreateCommand();
            DateTime startDate, endDate;
            DateTime.TryParse(TextBox1.Text, out startDate);
            DateTime.TryParse(TextBox2.Text, out endDate);
            if (startDate != null && endDate != null && !string.IsNullOrEmpty(startDate.ToString()) && !string.IsNullOrEmpty(endDate.ToString()) && endDate.CompareTo(startDate) >= 0)
            {
                //MAcmd.CommandText = "select Sum(price) from sale where startdate between @startDate and @endDate";
               // MAcmd.CommandText = "select Sum(price) from sale where startdate between '" + startDate + "' and '" + endDate + "'";
                MAcmd.CommandText = "select Sum(totalAmount) from Orders where OrderDate between '" + startDate + "' and '" + endDate + "'";
                
                
                //MAcmd.Parameters.AddWithValue("@startDate", startDate.ToString());
                //MAcmd.Parameters.AddWithValue("@endDate", endDate.ToString());
                lblsale.Text = System.Convert.ToString(MAcmd.ExecuteScalar());
                lblres.Visible = false;
                //Response.Redirect("salemanagement.aspx");

            }
            else
            {
                lblres.Visible = true;
                lblres.Text = "oh date entered is not in range the range is between '" + TextBox1.Text + "' and '" + TextBox2.Text + "'";
            }


            MAconn.Close();
            //Response.Redirect("profit.aspx");
        }
        catch (Exception ex)
        {
            lblres.Text = "oh date entered is not in range" + ex;
        } */
    }
}
