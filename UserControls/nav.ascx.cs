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


public partial class UserControls_nav : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.User.Identity.IsAuthenticated)
        {

            lbluser.Text = "Welcome &nbsp" + HttpContext.Current.User.Identity.Name;
            lnklogin.Visible = false;
            lnkSignout.Visible = true;
            lnkorderhistory.Visible = true;
            lnkviewcart.Visible = true;
        }
        else
        {
            lbluser.Text = "Welcome Guest";
            lnklogin.Visible = true;
            lnkSignout.Visible = false;
            lnkviewcart.Visible = false;
            lnkorderhistory.Visible = false;
        }

        if (HttpContext.Current.User.IsInRole("Admin"))
        {
            lnkadmin.Visible = true;
        }
        else
        {
            lnkadmin.Visible = false;

        }


    }
    protected void lnkSignout_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Session.Abandon();

        // clear authentication cookie
        HttpCookie cookie1 = new HttpCookie(FormsAuthentication.FormsCookieName, "");
        cookie1.Expires = DateTime.Now.AddYears(-1);
        Response.Cookies.Add(cookie1);

        // clear session cookie (not necessary for your current problem but i would recommend you do it anyway)
        HttpCookie cookie2 = new HttpCookie("ASP.NET_SessionId", "");
        cookie2.Expires = DateTime.Now.AddYears(-1);
        Response.Cookies.Add(cookie2);

        FormsAuthentication.RedirectToLoginPage();
        Response.Redirect("Default.aspx");
    }
    protected void lnklogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void lnkviewcart_Click(object sender, EventArgs e)
    {
        Response.Redirect("shoppingcart.aspx");

    }
    protected void lnkadmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminmenu.aspx");
    }
    protected void lnkorderhistory_Click(object sender, EventArgs e)
    {
        Response.Redirect("userOrder.aspx");
    }
}