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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindGrid();

    }

    private void BindGrid()
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
            dTable = p.Load();
        }
        catch (Exception ee)
        {
            lblMessage.Text = ee.Message.ToString();
        }
        finally
        {
            p = null;
        }

        return dTable;
    }
    protected void _rowdeleting(object sender, GridViewDeleteEventArgs e)
    {
        //String Username = GridView1.DataKeys[e.RowIndex].Value.ToString();

        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        Label user = (Label)row.FindControl("lblusername");
        string Username = user.Text;

        
       
        

        // instantiate BAL
        Businesslayer pBAL = new Businesslayer();
        try
        {
            pBAL.Delete(Username);

            lblMessage.Text = "Record Deleted Successfully.";
        }
        catch (Exception ee)
        {
            lblMessage.Text = ee.Message.ToString();
        }
        finally
        {
            pBAL = null;
        }

       // GridView1.EditIndex = -1;
        // Refresh the list
        BindGrid();
    }

   
}
