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

public partial class Admin_RoleManagement : System.Web.UI.Page
{
    ecprops p = new ecprops();
    dbcon obj = new dbcon();
    Businesslayer bus = new Businesslayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }

        if (!IsPostBack)
        {
            userinrole();
        }

        if (!IsPostBack)
        {
            string querydr = "select * from groups";
            SqlDataReader dr = obj.fillcomb(querydr);
            DropDownList1.DataSource = dr;
            DropDownList1.DataValueField = "RoleName";
            DropDownList1.DataBind();



        }
        
        
    }
    protected void btnaddrole_Click(object sender, EventArgs e)
    {
        if (txtaddrole.Text == "")
        {
            lblresult.Text = "Please Enter Role Name";
        }
        else
        {
            p.rolename = txtaddrole.Text;  
          
        int count = bus.countrole(p);
        if (count > 0)
        {
            lblresult.Text = "The Role is Already Exists";
        }
        else
        {
            p.addrole = txtaddrole.Text;
            
            bool b = bus.blladdrole(p);


            if (b)
            {
                lblresult.Text = "Inserted";
                //Response.Redirect("Products.aspx");
            }
            else
            {

                lblresult.Text = "Not Inserted";
            }
        }
        }
    }
    
    private void bind()
    {
        GridView1.DataSource = Loadrolename();
        GridView1.DataBind();
    }
    private DataTable Loadrolename()
    {
        
        DataTable dTable = new DataTable();
        try
        {
            dTable = bus.bllloadrolename();
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

   /* public void userinrole()
    {
        string query = "select users.UserName, groups.RoleName from users inner join roles on roles.userid=users.userid inner join groups on roles.groupid=groups.groupid";
        DataSet ds = obj.fillgrid(query);
        GridView2.DataSource = ds.Tables[0];
        GridView2.DataBind();
    }*/


    private void userinrole()
    {
        GridView2.DataSource = loaduserinrole();
        GridView2.DataBind();
    }
    private DataTable loaduserinrole()
    {

        DataTable dTable = new DataTable();
        try
        {
            dTable = bus.blluserinrole();
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

    protected void btnassignrole_Click(object sender, EventArgs e)
    {
        p.myUserName = txtusername.Text;
        p.myrolename = DropDownList1.Text;

       
        int count = bus.assingrolecount(p);
        if (count > 0)
        {
            lblasign.Text = "The Role is Already Assigned to that User";
        }
        else
        {
            p.UserName = txtusername.Text;
            p.rolename = DropDownList1.Text;

           
            bool b = bus.bllassignrole(p);
            
            if (b)
            {
               lblasign.Text = "The Role is Successfully Assigned to Selected User";
                
            }
            else
            {

                lblasign.Text = "Not Inserted";
            }
        }
   
    }
   
    protected void _rowdel(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView2.Rows[e.RowIndex];
        Label lbldeletename = (Label)row.FindControl("lblusername");
        Label lblmyrolename= (Label)row.FindControl("lblrolename");

        //MAconn.Open();
        //string query = "Delete FROM roles WHERE UserID = (SELECT UserID FROM users WHERE UserName= '" + lbldeletename.Text + "')";
       string query = "Delete FROM roles WHERE UserID = (SELECT UserID FROM users WHERE UserName= '"+lbldeletename.Text+"') and GroupID=(SELECT GroupID FROM groups WHERE RoleName= '"+lblmyrolename.Text+"')";
        obj.UDI(query);
        userinrole();

    }


  
}
