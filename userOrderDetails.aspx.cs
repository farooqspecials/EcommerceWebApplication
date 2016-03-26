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

public partial class userOrderDetails : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string query = "select customerID,FirstName,LastName,Address,totalAmount,OrderID from Orders where OrderID='" + Request.QueryString["ID"] + "'";
            DataSet ds = obj.fillgrid(query);
            DataTable dt = ds.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                lblcustomerID.Text = dr["CustomerID"].ToString();

               // lblfirstname.Text = dr["FirstName"].ToString();
                //lbllastname.Text = dr["LastName"].ToString();
                double dues = System.Convert.ToDouble(dr["totalamount"]);

                //lbladdress.Text = dr["Address"].ToString();
                lblDues.Text = "Total Rs:" + dues.ToString();// dr["totalAmount"].ToString();


            }
        }
        bind();


    }
    
    public void bind()
    {
        //string query = "select p.productname,p.productid,od.quantity,od.unitcost,o.customerid,o.firstname from Products p, OrderDetails od, Orders o where p.productid=od.productid and od.OrderID=o.OrderID and customerID='"+ User.Identity.Name +"'";
        //string query = "select p.productname,p.productid,od.quantity,od.unitcost,o.customerid,o.firstname from Products p, OrderDetails od, Orders o where p.productid=od.productid and od.OrderID=o.OrderID where OrderID='" + Request.QueryString["ID"] + "'";
        //string query= "select users.UserName, groups.RoleName from users inner join roles on roles.userid=users.userid inner join groups on roles.groupid=groups.groupid";
        ///string query = "select Products.productname,Products.Productid,OrderDetails.Quantity,OrderDetails.unitcost,Orders.OrderId,Orders.FirstName from Products inner join OrderDetails on Orderdetails.productid=Products.productid inner join Orders on Orders.OrderID=OrderDetails.OrderID where Orders.OrderID='" + Request.QueryString["ID"] + "'";
        
       // string query = "select * from OrderDetails Left JOIN Orders on Orders.OrderID=OrderDetails.OrderID where OrderID='" + Request.QueryString["ID"] + "'";
        string query = "select * from OrderDetails Left JOIN Orders on OrderDetails.OrderID=Orders.OrderID where OrderDetails.OrderID='" + Request.QueryString["ID"] + "'";
        DataSet ds = obj.fillgrid(query);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }

    private decimal decTotal;
    protected void _rowbound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            int prodid = int.Parse(((Label)(e.Row.FindControl("lblProductid"))).Text);
            
            int qty = int.Parse(((Label)(e.Row.FindControl("lblQuantity"))).Text);
            
            Product p = Product.GetProduct(prodid);
            decTotal = qty * p.UnitCost;
            double a = (double)decTotal;

            ((Label)(e.Row.FindControl("lbltotal"))).Text = a.ToString(); //decTotal.ToString();
        }
        
    }
}
