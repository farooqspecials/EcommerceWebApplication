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

public partial class adminmenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void adminpro_Click(object sender, EventArgs e)
    {
        Response.Redirect("Products.aspx");
    }
    protected void roleman_Click(object sender, EventArgs e)
    {
        Response.Redirect("RoleManagement.aspx");
    }
    protected void admincat_Click(object sender, EventArgs e)
    {
        Response.Redirect("categoryManagement.aspx");
    }
    protected void procat_Click(object sender, EventArgs e)
    {
        Response.Redirect("procat.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminorders.aspx");
    }
    protected void lnkusers_Click(object sender, EventArgs e)
    {
        Response.Redirect("userman.aspx");
    }
    protected void Lnkstrpt_Click(object sender, EventArgs e)
    {
        Response.Redirect("stockreport.aspx");
    }
    protected void lnksale_Click(object sender, EventArgs e)
    {
        //Response.Redirect("salemanagement.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("profitloss.aspx");
    }
    protected void lnkstockalerts_Click(object sender, EventArgs e)
    {
        Response.Redirect("stockalerts.aspx");
    }
}
