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

public partial class Admin_catad : System.Web.UI.Page
{
    //SqlConnection conn;
    dbcon db = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    {
        //conn = new SqlConnection("Data Source=FAROOQPC\\SQLEXPRESS; Initial Catalog=shop; Integrated Security=True");
        if (!IsPostBack)
        {
            bind();

        }

    }

    /*public void bind()
    {

        //conn.Open();

        string query="select * from Categories";

        //string query = "select * from Products";
        DataSet ds = db.fillgrid(query);
       // GridView1.DataSource = ds.Tables[0];
        //GridView1.DataBind();
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
        //conn.Close();
    }*/

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
            dTable = p.bllloadcatgrid();
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
    protected void _rowdeleting(object sender, GridViewDeleteEventArgs e)
    {
        /*GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        Label lbldeletename = (Label)row.FindControl("lblcatname");
       
        string query="delete Categories where CategoryName='" + lbldeletename.Text + "'";
        
        db.UDI(query);
        
        //conn.Close();
        bind();*/

        string query = "delete Categories where CategoryName='" + Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0].ToString()) + "'";

        db.UDI(query);

        bind();

       
    }
    protected void _rowediting(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();

    }
    protected void _rowupdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        //Label lbl = (Label)row.FindControl("lblid");
        TextBox catname = (TextBox)row.FindControl("txtcatname");
        TextBox catid = (TextBox)row.FindControl("txtid");
        //TextBox textaddress = (TextBox)row.FindControl("txtaddress");
        GridView1.EditIndex = -1;
        //conn.Open();
        string query="update  Categories set CategoryName='" + catname.Text + "' where CategoryID=" + catid.Text + "";
        //cmd.ExecuteNonQuery();
        db.UDI(query);
        //conn.Close();
        bind();
    }
    protected void _pagechange(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;

        bind();

    }
    protected void _rowcancel(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;

        bind();

    }
    dbcon obj1 = new dbcon();
    ecprops p = new ecprops();
    Businesslayer obj = new Businesslayer();
    protected void btnaddcat_Click(object sender, EventArgs e)
    {
        if (txtaddcat.Text == "")
        {
            showlbl.Text = "Please Enter Category Name";
        }
        else
        {
         

            p.addcat = txtaddcat.Text;
            int count = obj.count(p);



            if (count > 0)
            {
                showlbl.Text = "The Category Already Exits";

            }
            else
            {
                p.CatName = txtaddcat.Text;
                bool b = obj.bll_insert(p);

                if (b == true)

                { showlbl.Text = "Insert Successfully"; }
                else
                { showlbl.Text = "not Insert Successfully"; }
                // Response.Redirect(Request.Url.AbsoluteUri); // creating problem in ajax
            }

        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void _rowbound(object sender, GridViewRowEventArgs e)
    {
       /* if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string id = ((Label)(e.Row.FindControl("lblid"))).Text;

            //cast the ShowDeleteButton link to linkbutton 

            LinkButton lb = (LinkButton)e.Row.Cells[3].Controls[0];

            if (lb != null)
            {

                //attach the JavaScript function with the ID as the paramter 

                lb.Attributes.Add("onclick", "return ConfirmOnDelete('" + id + "');");

            }
        }*/
    }
}
