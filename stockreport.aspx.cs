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

public partial class stockreport : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    /*(public void bind()
    {
        string query = "select * from Products";
        DataSet ds = obj.fillgrid(query);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }*/
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }

    }

    private void bind()
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
            dTable = p.bllstockreport();
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


    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        Response.Redirect("stockalerts.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminmenu.aspx");
    }
}
