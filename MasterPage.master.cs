using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class MasterPage : System.Web.UI.MasterPage
{
    dbcon obj = new dbcon();
  public string proid;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        ecprops prop = new ecprops();
        prop.customerid = HttpContext.Current.User.Identity.Name;
        Businesslayer bus = new Businesslayer();

        int count = bus.bll_viewcart(prop);

       
           


        if (HttpContext.Current.User.Identity.IsAuthenticated)
        {

            lbluser.Text = "Welcome &nbsp" + HttpContext.Current.User.Identity.Name;
            lnksignin.Visible = false;
            lnksignout.Visible = true;
            lnkorderhistory.Visible = true;
            lnkviewcart.Visible = true;
            //top menu
            Lnktopsignin.Visible = false;
            lnktopsignout.Visible = true;
            lnktoporders.Visible = true;
            lnktopviewcart.Visible = true;
            lnktopregister.Visible = false;
            lblshow.Text = " " + count + "  items in cart";


        }
        else
        {
            lbluser.Text = "Welcome Guest";
            lnksignin.Visible = true;
            lnksignout.Visible = false;
            lnkviewcart.Visible = false;
            lnkorderhistory.Visible = false;

            //top menu

            Lnktopsignin.Visible = true;
            lnktopsignout.Visible = false;
            lnktopviewcart.Visible = false;
            lnktoporders.Visible = false;
            lnktopregister.Visible = true;
        }

        if (HttpContext.Current.User.IsInRole("Admin"))
        {
            lnkadmin.Visible = true;
            lnkadminmenu.Visible = true;
        }
        else
        {
            lnkadmin.Visible = false;
            lnkadminmenu.Visible = false;

        }
        
         
    }

    public void links()
    {
        string querydr = "select * from Products";
        SqlDataReader dr = obj.fillcomb(querydr);

        while (dr.Read())
        {

            if (proid == String.Empty)
            {
                proid = dr["ProductID"].ToString();
            }
            else
            {
                proid += "," + dr["ProductID"].ToString();
            }


        }



        //Response.Redirect("ProductCatalog.aspx?ID=" + proid + "&LoadGridView=true");
            
    }

    public void tc()
    {
        string querydr = "select * from Products";
        SqlDataReader dr = obj.fillcomb(querydr);

        while (dr.Read())
        {

            if (proid == String.Empty)
            {
                proid = dr["ProductID"].ToString();
            }
            else
            {
                proid += "," + dr["ProductID"].ToString();
            }


        }



        Response.Redirect("ProductCatalog.aspx?ID=" + proid + "&method2=true");

    }
   
   
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
         links();
         Response.Redirect("ProductCatalog.aspx?ID=" + proid + "&LoadGridView=true");
              

    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        links();
        Response.Redirect("ProductCatalog.aspx?ID=" + proid + "&method2=true");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        links();
        Response.Redirect("ProductCatalog.aspx?ID=" + proid + "&method3=true");

    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        links();
        Response.Redirect("ProductCatalog.aspx?ID=" + proid + "&method4=true");

    }
    protected void lnksignout_Click(object sender, EventArgs e)
    {
        /*FormsAuthentication.SignOut();
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
        Response.Redirect("Default.aspx");*/
        signout();
    }

    public void signout()
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

    protected void lnksignin_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void lnkorderhistory_Click(object sender, EventArgs e)
    {
        Response.Redirect("userOrder.aspx");
    }
    protected void lnkviewcart_Click(object sender, EventArgs e)
    {
        Response.Redirect("shoppingcart.aspx");

    }
    protected void lnkadmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminmenu.aspx");
    }
    protected void lnksignup_Click(object sender, EventArgs e)
    {
        if (HttpContext.Current.User.Identity.IsAuthenticated)
        {
            lblsignup.Text = "You are already SignIn";

            lnkadmin.Visible = false;
            lbluser.Visible = false;
            lblsignup.Visible = true;
        }
        else
        {
            Response.Redirect("Register.aspx");
            
        }
    }
    protected void lnkforget_Click(object sender, EventArgs e)
    {
        if (HttpContext.Current.User.Identity.IsAuthenticated)
        {
            lblsignup.Text = "You are already SignIn";

            lnkadmin.Visible = false;
            lbluser.Visible = false;
            lblsignup.Visible = true;
        }
        else
        {
            Response.Redirect("forget.aspx");

        }
    }
    protected void lnkadminmenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminmenu.aspx");
        
    }
    protected void lnktopsignout_Click(object sender, EventArgs e)
    {
        signout();
    }
    protected void Lnktopsignin_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void lnktopviewcart_Click(object sender, EventArgs e)
    {
        Response.Redirect("shoppingcart.aspx");   
    }
    protected void lnktoporders_Click(object sender, EventArgs e)
    {
        Response.Redirect("userOrder.aspx");
    }
    protected void lnktopregister_Click(object sender, EventArgs e)
    {

        if (HttpContext.Current.User.Identity.IsAuthenticated)
        {
            lnktopregister.Visible = false;
        }
        else
        {
            Response.Redirect("Register.aspx");

        }

    }
}
