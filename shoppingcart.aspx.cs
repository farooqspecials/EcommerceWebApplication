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

public partial class shoppingcart : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            bind();

        }

        if (!(User.Identity.IsAuthenticated))
        {
            Response.Redirect("~/login.aspx");
        }
        if (ShoppingCart.GetItems(User.Identity.Name).Count > 0)
        {
            btnupdatecart.Visible = true;
            btnplaceorder.Visible = true;
        }
       // if (ShoppingCart.GetItems(User.Identity.Name).Count == 0)
       // {
        //    btnupdatecart.Visible = false;
         //   btnplaceorder.Visible = false;
        //}
        
        //ObjectDataSource1.DataBind();
       if (GridView1.Rows.Count == 0 )
        {
            Labelinfo.Visible = true;
            //btnupdatecart.Visible = false;
            //btnplaceorder.Visible = false;
           Panel1.Visible=false;
            
        }
        else
        {
            Labelinfo.Visible = false;
        }
       /* if (GridView1.DataSource == String.Empty || GridView1.DataSource == null)
        {
            //label1.Text = "Your Message";
            Labelinfo.Visible = true;
            btnupdatecart.Visible = false;
            btnplaceorder.Visible = false;
        } */



    }
    public void bind()
    {
        string query = "select Products.ProductID,Products.ProductName,Products.UnitCost,ShoppingCart.Quantity from Products RIGHT JOIN ShoppingCart on Products.ProductID=ShoppingCart.ProductID where CustomerID='"+User.Identity.Name+"'"; 
        DataSet ds = obj.fillgrid(query);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
    protected void btnupdatecart_Click(object sender, EventArgs e)
    {
        try
        {
            for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
            {
                GridViewRow row = GridView1.Rows[i];
                if (row.RowType == DataControlRowType.DataRow)
                {
                    ShoppingCartItem item = new ShoppingCartItem();
                    item.CustomerID = User.Identity.Name;
                    item.ProductID = (int)GridView1.DataKeys[i].Value;
                   // item.ProductID = int.Parse(((Label)(row.FindControl("lblproid"))).Text);
                    item.Quantity = int.Parse(((TextBox)(row.FindControl("txtmainqty"))).Text);
                    
                    if (item.Quantity <= 0)
                    {
                        throw new Exception("Invalid Quantity");
                    }
                    ShoppingCart.UpdateItem(item);
                }
            }
            GridView1.DataBind();
            bind();
            btnplaceorder.Enabled = true;
            //lblMsg.Text = "";
        }
        catch (Exception ex)
        {
            btnplaceorder.Enabled = false;
            lblmsg.Text = ex.Message;
        }
    }

    private decimal decTotal;
    protected void _rowdatabound(object sender, GridViewRowEventArgs e)
    {
          if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //int prodid = int.Parse(e.Row.Cells[0].Text);
            int prodid=int.Parse(((Label)(e.Row.FindControl("lblproid"))).Text);
            int qty = int.Parse(((TextBox)(e.Row.FindControl("txtmainqty"))).Text);
            Product p = Product.GetProduct(prodid);
            decTotal = decTotal + (qty * p.UnitCost);
            Session["totalAmount"] = decTotal;

            //string id = e.Row.Cells[0].Text; // Get the id to be deleted
            string id = ((Label)(e.Row.FindControl("lblproname"))).Text;

            //cast the ShowDeleteButton link to linkbutton 

            LinkButton lb = (LinkButton)e.Row.Cells[4].Controls[0];

            if (lb != null)
            {

                //attach the JavaScript function with the ID as the paramter 

                lb.Attributes.Add("onclick", "return ConfirmOnDelete('" + id + "');");

            }       

        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {
            ((Label)(e.Row.FindControl("lbltotal"))).Text = "Total :"+"Rs " + decTotal.ToString();
        } 

    }


    protected void btnplaceorder_Click(object sender, EventArgs e)
    {
       /*for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
            {
               GridViewRow row = GridView1.Rows[i];
                if (row.RowType == DataControlRowType.DataRow)
                {
                    ShoppingCartItem item = new ShoppingCartItem();
                    
                    item.ProductID = (int)GridView1.DataKeys[i].Value;
                    item.Quantity = int.Parse(((TextBox)(row.FindControl("txtmainqty"))).Text);
                    
                  
                   /* dbcon db = new dbcon();
                    int orderedQuantity = System.Convert.ToInt32(item.Quantity);
                   
                    string query1 = "update Products set productquantity=productquantity-'" + orderedQuantity + "' where ProductID='" + item.ProductID + "'";
                    //bool b = db.UDI(query);
                    bool b = db.UDI(query1);
                    if (b == true)
                    {

                       // lblshow.Text = "Product Delivered and Added to DataBase Sucessfully";

                    }

                    else
                    {
                        //lblshow.Text = " Operation Not successful";

                    }
                }
            }*/
        
            Response.Redirect("CheckOut.aspx");
        
    }
    protected void _rowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        dbcon db = new dbcon();
         GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        Label lblproid = (Label)row.FindControl("lblproid");
       
        string query="delete ShoppingCart where ProductID='" + lblproid.Text + "'";
        
        db.UDI(query);
        
       
        bind();
        Response.Redirect("shoppingcart.aspx");
    }
}
