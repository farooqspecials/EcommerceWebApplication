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

public partial class adminOrdersDetails : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    { 
        
        if (!IsPostBack)
        {
           // string query = "select customerID,FirstName,LastName,Company,Address,Country,Province,ZipCode,Telephone,Fax,City,Status,totalAmount from Orders where OrderID='" + Request.QueryString["ID"] + "'";
            //DataSet ds = obj.fillgrid(query);
           // DataTable dt = ds.Tables[0];
            props.orderid = Request.QueryString["ID"];
            DataTable dt = GridDataSource();
            foreach (DataRow dr in dt.Rows)
            {
                lblcustomerID.Text = dr["CustomerID"].ToString();

                lblfirstname.Text = dr["FirstName"].ToString();
                lbllastname.Text = dr["LastName"].ToString();
                lblcompany.Text = dr["Company"].ToString();
                lbladdress.Text = dr["Address"].ToString();
                lblcountry.Text = dr["Country"].ToString();
                lblzipcode.Text = dr["ZipCode"].ToString();
                lbltelephone.Text = dr["Telephone"].ToString();
                lblfax.Text = dr["Fax"].ToString();
                lblcity.Text = dr["City"].ToString();
                lblstatus.Text = dr["Status"].ToString();
                double amount = System.Convert.ToDouble(dr["totalAmount"]);
                lblDues.Text = amount.ToString();
                lblprovince.Text = dr["Province"].ToString();


            }
         


        }
        if (lblstatus.Text == "Completed")
        {
            DropDownList1.Visible = false;
            lblcombo.Visible = true;

        }
        else
        {
            DropDownList1.Visible = true;
            lblcombo.Visible = false;
        }
        bind();
    }

   
    ecprops props = new ecprops();
    private DataTable GridDataSource()
    {
        Businesslayer p = new Businesslayer();
        DataTable dTable = new DataTable();
        try
        {
            dTable = p.bllorderreader(props);
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

    

   /* public void bind()
    {
        string query = "select Products.ProductID,Products.ProductName,OrderDetails.UnitCost,OrderDetails.Quantity from Products RIGHT JOIN OrderDetails on Products.ProductID=OrderDetails.ProductID where OrderID='" + Request.QueryString["ID"] + "'";
        DataSet ds = obj.fillgrid(query);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }*/
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbcon db = new dbcon();
        

        string query = "update  Orders set Status='" + DropDownList1.Text + "' where OrderID='" +Request.QueryString["ID"] +"'";
        
       bool b= db.UDI(query);
       if (b == true)
       {
           lblshow.Text = "OrderInformation Updated Successfully";

       }
       else
       {
           lblshow.Text = " Operation Not successful";
       }

       if (DropDownList1.Text == "Completed")
       {
           for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
           {
               GridViewRow row = GridView1.Rows[i];
               if (row.RowType == DataControlRowType.DataRow)
               {
                   ShoppingCartItem item = new ShoppingCartItem();

                   item.ProductID = (int)GridView1.DataKeys[i].Value;
                   item.Quantity = int.Parse(((Label)(row.FindControl("lblqty"))).Text);
                 //  Label lbldeleteid = (Label)row.FindControl("lblproid");
               


                   

                   dbcon db1 = new dbcon();
                    int orderedQuantity = System.Convert.ToInt32(item.Quantity);
                   
                    string query1 = "update Products set productquantity=productquantity-'" + orderedQuantity + "' where ProductID='" + item.ProductID + "'";
                    //bool b = db.UDI(query);
                    bool c = db1.UDI(query1);
                    if (c == true)
                    {

                       // lblshow.Text = "Product Delivered and Added to DataBase Sucessfully";

                    }

                    else
                    {
                        //lblshow.Text = " Operation Not successful";

                    }
               }
           }
        
                 
       }


    }


    private void bind()
    {
        GridView1.DataSource = gridorder();
        GridView1.DataBind();
    }

    private DataTable gridorder()
    {
        Businesslayer p = new Businesslayer();
        DataTable dTable = new DataTable();
        props.orderidgrid = Request.QueryString["ID"];
        try
        {
            dTable = p.bllgridorder(props);
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


    private decimal decTotal;
    protected void _dtabound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            int prodid = int.Parse(((Label)(e.Row.FindControl("lblproid"))).Text);
           // int prodid = int.Parse(((Label)(e.Row.FindControl("lblproid"))).Text);
            int qty = int.Parse(((Label)(e.Row.FindControl("lblqty"))).Text);
            //int qty = int.Parse(((Label)(e.Row.FindControl("lblQuantity"))).Text);
            Product p = Product.GetProduct(prodid);
            decTotal = qty * p.UnitCost;
            double gridtotal = (double)decTotal;

            ((Label)(e.Row.FindControl("lbltotal"))).Text = gridtotal.ToString();
        }
        

            
    }
   
}
