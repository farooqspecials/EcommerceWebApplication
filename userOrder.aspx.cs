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

public partial class userOrder : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    {
        bind();
    }
    public void bind()
    {
        string query = "select OrderID,CustomerID,OrderDate,totalAmount,Status From Orders where CustomerID='"+User.Identity.Name+"'";
        DataSet ds = obj.fillgrid(query);
        GridView1.DataSource = ds.Tables[0];
        
        GridView1.DataBind();
    }
}
