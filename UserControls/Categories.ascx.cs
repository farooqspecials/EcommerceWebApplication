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
using System.Data;

public partial class UserControls_Categories : System.Web.UI.UserControl
{
    dbcon obj = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    {
       // LoadGridView();
        BindGrid();
    }


     private void BindGrid()
    {
        GridView1.DataSource = GridDataSource();
        GridView1.DataBind();
    }

     private DataTable GridDataSource()
     {
         Businesslayer p = new Businesslayer();
         DataTable dTable = new DataTable();
         try
         {
             dTable = p.bll_catnav();
         }
         catch (Exception ee)
         {
             //lblMessage.Text = ee.Message.ToString();
         }
         finally
         {
             p = null;
         }

         return dTable;
     }
   /* private void LoadGridView()
    {
        //conn.Open();
        string query="Select CategoryID,CategoryName from Categories";
        DataSet ds=obj.fillgrid(query);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind(); 
        //conn.Close();
    }*/
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect(Request.Url.AbsoluteUri);
    }
}
