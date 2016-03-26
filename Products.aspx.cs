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
using System.IO;

public partial class Admin_Products : System.Web.UI.Page
{
    

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
            dTable = p.bllloadproductstable();
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


    ecprops p = new ecprops();
    dbcon obj = new dbcon();
    Businesslayer bl = new Businesslayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        
       if (!IsPostBack)
        {
           
            loadcombdata();



        }
        
        if (!IsPostBack)
        {
            bind();
        }

       
        

    }


    private void loadcombdata()
    {
        
        DropDownList1.DataSource = loadcomb();
        DropDownList1.DataValueField = "CategoryName";
        DropDownList1.DataBind();
    }

    private SqlDataReader loadcomb()
    {
        Businesslayer p = new Businesslayer();
        SqlDataReader dr=null;
        try
        {
            dr = p.bllloadreader();
        }
        catch (Exception ee)
        {
            //lblMessage.Text = ee.Message.ToString();
        }
        finally
        {
            p = null;
        }

        return dr;
    }

   
    protected void btnaddproduct_Click(object sender, EventArgs e)
    {
        p.procatname = DropDownList1.Text;
        p.proproductname = txtproname.Text;
        p.unitcost = txtproprice.Text;
        p.desc = txtprodesc.Text;
        p.oprice = txtOrigional.Text;
        p.proquantity = dpquantity.Text;
       
        if (FileUpload1.HasFile)
        {
            //string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            p.filename=Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(Server.MapPath("Images/"+p.filename));

            bool b = bl.bll_insertproducts(p);

            if (b == true)

            { 
                lblresult.Text = "Insert Successfully";
                Response.Redirect("Products.aspx");
            
            }
            else
            { lblresult.Text = "not Insert Successfully"; }



          /* string query = "insert into Products(CategoryID,ProductName,ProductImage,UnitCost,Description,origionalPrice,productquantity) select CategoryID,'" + txtproname.Text + "','" + "Images/" + filename + "'," + txtproprice.Text + ",'" + txtprodesc.Text + "','"+txtOrigional.Text+"','"+dpquantity.Text+"' from Categories where CategoryName='" + DropDownList1.Text + "'";
           bool b = obj.UDI(query);
            
            if (b)
            {
                lblresult.Text = "Inserted";
           
                Response.Redirect("Products.aspx");
            }
            else
            {

                lblresult.Text = "Not Inserted";
            }*/
        }

        else
        {
           
            UploadStatusLabel.Text = "You did not specify a file to upload.";

        }
        
           
    }
    protected void _rowdeleting(object sender, GridViewDeleteEventArgs e)
    {
       /* GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
       
        Label lbldeleteid = (Label)row.FindControl("lblproid");
        
        string query="delete Products where ProductID='" + lbldeleteid.Text + "'";
        obj.UDI(query);*/
        string query = "delete Products where ProductID='" + Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0].ToString()) + "'";

        obj.UDI(query);

        bind();
        
       bind();


    }
    protected void _rowupdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        //Label lbl = (Label)row.FindControl("lblid");
        TextBox proid = (TextBox)row.FindControl("txtproid");
        TextBox proname = (TextBox)row.FindControl("txtproname");
        TextBox proprice = (TextBox)row.FindControl("txtproprice");
        GridView1.EditIndex = -1;
        //conn.Open();
       // SqlCommand cmd = new SqlCommand("update  ESK_Products set ProductName='" + proname.Text + "',UnitCost="+proprice.Text+" where ProductID=" + proid.Text + "", conn);
        string query = "update  Products set ProductName='" + proname.Text + "',UnitCost=" + proprice.Text + " where ProductID=" + proid.Text + "";
        obj.UDI(query);
        //cmd.ExecuteNonQuery();
        //conn.Close();
        bind();
    }
    protected void _rowediting(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();
    }
    protected void _rowcancel(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;

        bind();
    }
    protected void _pagechange(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;

        bind();

    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
    protected void lnkstock_Click(object sender, EventArgs e)
    {
       
    }
    protected void btnstock_Click(object sender, EventArgs e)
    {
       
    }
    protected void orderpro_Click(object sender, EventArgs e)
    {
        //Response.Redirect("stock.aspx?"+"ProductName="+Server.UrlEncode(this.txtproname.Text));
        Response.Redirect("stock.Aspx?" +
            "Name=" + Server.UrlEncode(txtproname.Text));
        //Response.Redirect("stock.aspx");
    }
    protected void _row(object sender, GridViewRowEventArgs e)
    {
        
     /*  if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string id = ((Label)(e.Row.FindControl("lblproname"))).Text;

            //cast the ShowDeleteButton link to linkbutton 

            
            LinkButton lb = (LinkButton)e.Row.Cells[4].Controls[0];
           

            if (lb != null)
            {

                //attach the JavaScript function with the ID as the paramter 

                lb.Attributes.Add("onclick", "return ConfirmOnDelete('" + id + "');");

            }
        }*/
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        
    }
}
