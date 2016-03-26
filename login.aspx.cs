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

public partial class login : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

        if (User.Identity.IsAuthenticated && Request.QueryString["ReturnUrl"] != null)
        {
            //Response.Redirect("Default.aspx");
            lblMessage.Text = "some problem";
        }

        

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        ecprops _user = new ecprops();
         dbcon dbo = new dbcon();
        _user = dbo.CheckUser(txtUserid.Text);
        if (_user != null)
        {
            if (_user.Password == txtPassword.Text)
            {
                FormsAuthenticationTicket Authticket = new FormsAuthenticationTicket(
                                                        1,
                                                        txtUserid.Text,
                                                        DateTime.Now,
                                                        DateTime.Now.AddMinutes(30),
                                                        chkRemeberMe.Checked,
                                                        _user.RoleName,
                                                        FormsAuthentication.FormsCookiePath);

                string hash = FormsAuthentication.Encrypt(Authticket);

                HttpCookie Authcookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);

                if (Authticket.IsPersistent) Authcookie.Expires = Authticket.Expiration;

                Response.Cookies.Add(Authcookie);

                string returnUrl = Request.QueryString["ReturnUrl"];
                if (returnUrl == null) returnUrl = "Default.aspx";

                Response.Redirect(returnUrl);

                
            }
            else
            {
                lblMessage.Text = "Password does'nt match.";
            }
        }
        else
        {
            lblMessage.Text = "User not exists.";
        }
    }

    protected void lnknewuser_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void lnkforget_Click(object sender, EventArgs e)
    {
        Response.Redirect("forget.aspx");
    }
}
