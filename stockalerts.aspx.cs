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

public partial class stock_alerts : System.Web.UI.Page
{

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
            dTable = p.bllStockAlert();
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


    protected void Page_Load(object sender, EventArgs e)
    {
        bind();
    }
    protected void lnkordermore_Click(object sender, EventArgs e)
    {
        Response.Redirect("stockordergrid.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("stockreport.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
       // Response.Redirect("stockOrderHistory.aspx");
    }
}
