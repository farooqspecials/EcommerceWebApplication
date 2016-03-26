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
using System.Data.SqlClient;

public partial class Register : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnreg_Click(object sender, EventArgs e)
    {
        
        registerUser reg = new registerUser();
       
        dbcon obj = new dbcon();
        string querycount = "Select Count(*) FROM users where UserName ='" + txtUserName.Text + "'";
        //string querycount = "Select Count(*) FROM users where UserName ='@UserName'";
        //SqlCommand cmd = new SqlCommand();
        
       // cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);


        int count = obj.ohh(querycount);
        if (count > 0)
        {
            lblreg.Text = "The User Already Exits";
        }
        else
        {

            //registerUser reg = new registerUser();
            reg.UserName = txtUserName.Text;
            reg.Password = txtPassword.Text;
            reg.FirstName = txtfirstname.Text;
            reg.LastName = txtlastname.Text;
            reg.Email = txtemail.Text;
            reg.MobileNo = txtmobileno.Text;

            int b = reg.insertUser(reg);
            if (b == 1)
            {
                //lblreg.Text = "User Registration Successful";
                //lblreg.Text = reg.result; 
            }
            else
            {
               // lblreg.Text = "Oh Their is Some Problem, Come back Lator";
                //lblreg.Text = reg.result;
            }
            

            ecprops _user = new ecprops();
            dbcon dbo = new dbcon();
            _user = dbo.CheckUser(txtUserName.Text);
            if (_user != null)
            {
                if (_user.Password == txtPassword.Text)
                {
                    FormsAuthenticationTicket Authticket = new FormsAuthenticationTicket(
                                                            1,
                                                            txtUserName.Text,
                                                            DateTime.Now,
                                                            DateTime.Now.AddMinutes(30),
                                                            CheckBox1.Checked,
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
                    lblreg.Text = "Password does'nt match.";
                }
            }
            else
            {
                lblreg.Text = "User not exists.";
            }

            




        }
    }
}
