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


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // Response.Cache.Expires(DateTime.Now); 
      /* if (User.Identity.IsAuthenticated)
        {

            lbluser.Text = "Welcome &nbsp" + User.Identity.Name;
            lnklogin.Visible = false;
            lnkSignout.Visible = true;
        }
        else
            { 
            lbluser.Text = "Welcome Guest";
            lnklogin.Visible = true;
            lnkSignout.Visible = false;
            }

        if (User.IsInRole("Admin"))
        {
            lnkadmin.Visible = true;
        }
        else
        {
            lnkadmin.Visible = false;
            
        }*/

        if (!IsPostBack)
       {
            
            bind();
            BindList();
        }
        

       
    }
    protected void lnkSignout_Click(object sender, EventArgs e)
    {
       
     /*   
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
        */
    }
    protected void lnklogin_Click(object sender, EventArgs e)
    {
      /* 
        Response.Redirect("login.aspx");*/
        
    }
    dbcon obj = new dbcon();
    /*public void bind()
    {
        string query = "select * from Products";
        DataSet ds = obj.fillgrid(query);
        //ViewState["ds"] = ds;
        DataList1.DataSource = ds;
        DataList1.DataBind();
        
    }*/


    private void bind()
    {
       
            DataList1.DataSource = GridDataSource();
            //GridView1.DataBind();
            DataList1.DataBind();
        
        
    }

    private DataSet GridDataSource()
    {
        Businesslayer p = new Businesslayer();
        //DataTable dTable = new DataTable();
        DataSet dTable = new DataSet();
        try
        {
            Global.currentpage = 0;
            dTable = p.bllLoadDt();
            ViewState["ds"] =dTable ;
            
            
            
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

    public void BindList()
    {
        PagedDataSource pg = new PagedDataSource();
        pg.AllowPaging = true;
        pg.PageSize = 12;
        pg.CurrentPageIndex = Global.currentpage;
        DataSet ds = (DataSet)ViewState["ds"];
        pg.DataSource = ds.Tables[0].DefaultView;
        LinkButton8.Enabled = !pg.IsFirstPage;
        LinkButton9.Enabled = !pg.IsLastPage;



        DataList1.DataSource = pg;
        DataList1.DataBind();

    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Global.currentpage -= 1;
        BindList();
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Global.currentpage += 1;
        BindList();
    }
}
