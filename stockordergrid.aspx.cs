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

public partial class stockordergrid : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblproname.Text = Request.QueryString["ID"];

       
            
        


        /* if (!IsPostBack)
        {
            string query = "select * from Supplier ";
            DataSet ds = obj.fillgrid(query);
            DataTable dt = ds.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                lblcustomerID.Text = dr["CustomerID"].ToString();

                lblfirstname.Text = dr["FirstName"].ToString();
                lbllastname.Text = dr["LastName"].ToString();
                lblcompany.Text = dr["Company"].ToString();
                


            }
         */
       

        if (!IsPostBack)
        {
            string querydr = "select SupplierName from Supplier";
            SqlDataReader dr1 = obj.fillcomb(querydr);
            DropDownList1.DataSource = dr1;
            DropDownList1.DataValueField = "SupplierName";
            DropDownList1.DataBind();



        }

    }
    protected void btnOrder_Click(object sender, EventArgs e)
    {
        string status = "Pending";
        string query1 = "insert into stock(productid,productname,supplierName,SupplierCell,SupplierAddress,OrderDate,OrderedQuantity,DelivaryStatus)select productID,'" + lblproname.Text + "','" + DropDownList1.Text + "','" + lblcell.Text + "','" + lbladdress.Text + "','" + DateTime.Now + "','" + txtOrderedQuantity.Text + "','"+status+"' from Products where ProductName='" + lblproname.Text + "'";
       // string query1 = "insert into stock(productid,productname,OrderDate,OrderedQuantity,DelivaryStatus)select productID,'" + lblproname.Text + "','" + DateTime.Now + "','" + txtOrderedQuantity.Text + "','" + status + "' from Products where ProductName='" + lblproname.Text + "'";
       // string query2 = "Select (StockId,supplierName,SupplierCell,SupplierAddress)select stockID,'" + lblproname.Text + "','" + txtsuppliername.Text + "','" + txtsuppliercell.Text + "','" + txtSupplierAddress.Text + "','" + DateTime.Now + "','" + txtOrderedQuantity.Text + "','" + status + "' from Products where ProductName='" + lblproname.Text + "'";
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
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
            string query = "select * from Supplier where SupplierName='" + DropDownList1.Text + "' ";
            DataSet ds = obj.fillgrid(query);
            DataTable dt = ds.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                //lblcustomerID.Text = dr["SupplierName"].ToString();

                lblcell.Text = dr["SupplierCell"].ToString();
                lbladdress.Text = dr["SupplierAddress"].ToString();
                //lblcompany.Text = dr["Company"].ToString();

            }
        
       // Response.Redirect("stockordergrid.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("stockreport.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("stockalerts.aspx");
    }
}
