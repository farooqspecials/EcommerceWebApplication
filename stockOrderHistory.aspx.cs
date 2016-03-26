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

public partial class stockOrderHistory : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    ecprops pro = new ecprops();
   // Businesslayer bus = new Businesslayer();

   /* private void LoadGridView()
    {
        //conn.Open();
        string query = "Select * from stock where ProductId='" + Request.QueryString["ID"] + "'";// or ProductName='"+Request.QueryString["Name"]+"'";
        //DataSet ds = new DataSet();
        DataSet ds = obj.fillgrid(query);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind(); ;
        //conn.Close();
    }*/
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            LoadGridView();




        }
    }

    private void LoadGridView()
    {
         
        GridView1.DataSource = GridDataSource();
        GridView1.DataBind();
    }

    private DataTable GridDataSource()
    {
        
        Businesslayer p = new Businesslayer();
        DataTable dTable = new DataTable();
        pro.proid = Request.QueryString["ID"];
        try
        {
            dTable = p.bllstockhistory(pro);
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

    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        Response.Redirect("stockalerts.aspx");
    }
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        Response.Redirect("stockreport.aspx");
    }
}
