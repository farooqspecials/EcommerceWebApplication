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

public partial class Admin_procat : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    {
        //dbcon obj = new dbcon();
        if (!IsPostBack)
        {
            string querydr = "select * from Categories";
            SqlDataReader dr = obj.fillcomb(querydr);
            DropDownList1.DataSource = dr;
            DropDownList1.DataValueField = "CategoryName";
            DropDownList1.DataBind();

           // Response.Redirect("procat.aspx");
         /*   if (!IsPostBack)
            {
                bind();

            }*/

        }
       
    }
    public void bind()
    {
        //string query = "select * from ESK_Products";
        string query = "SELECT * FROM Products LEFT JOIN Categories ON Categories.CategoryID=Products.CategoryID Where Categories.CategoryName='" + DropDownList1.Text + "'";  
        DataSet ds = obj.fillgrid(query);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
            bind();

        
    }
}
