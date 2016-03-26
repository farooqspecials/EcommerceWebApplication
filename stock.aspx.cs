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

public partial class stock : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    public void orderbind()
    {
        string querypro = "select productname from products";
        SqlDataReader dpros = obj.fillcomb(querypro);
        //DropDownList1.DataSource = dr;
        dpproductname.DataSource = dpros;
        //DropDownList1.DataValueField = "CategoryName";
        dpproductname.DataValueField = "ProductName";
        dpproductname.DataBind();
        //DropDownList1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            orderbind();
        }

        lblproname.Text = Request.QueryString["Name"];


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
    }
    protected void btnOrder_Click(object sender, EventArgs e)
    {
        //string query = "insert into Products(CategoryID,ProductName,ProductImage,UnitCost,Description,origionalPrice,StockQuantity)select CategoryID,'" + txtproname.Text + "','" + "Images/" + filename + "'," + txtproprice.Text + ",'" + txtprodesc.Text + "','" + txtOrigional.Text + "','" + dpquantity.Text + "' from Categories where CategoryName='" + DropDownList1.Text + "'";
       // string query1 = "insert into stock(productid,productname,supplierName,SupplierCell,SupplierAddress,OrderDate,OrderedQuantity)select productID,'" + dpproductname.Text + "','" + txtsuppliername.Text + "','" + txtsuppliercell.Text + "','" + txtSupplierAddress.Text + "','" + DateTime.Now + "','" + txtOrderedQuantity.Text + "' from Products where ProductName='" + dpproductname.Text + "'";
        
        string query1 = "insert into stock(productid,productname,supplierName,SupplierCell,SupplierAddress,OrderDate,OrderedQuantity)select productID,'" + dpproductname.Text + "','" + txtsuppliername.Text + "','" + txtsuppliercell.Text + "','" + txtSupplierAddress.Text + "','" + DateTime.Now + "','" + txtOrderedQuantity.Text + "' from Products where ProductName='" + lblproname.Text+"'";
        bool b = obj.UDI(query1);
        //bool b = obj.mdi(query, query1);

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
    protected void lnkorderpage_Click(object sender, EventArgs e)
    {
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Products.aspx");
    }
}
