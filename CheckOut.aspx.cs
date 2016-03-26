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
using System.Collections.Generic;
using System.Data.SqlClient;

public partial class CheckOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Order o = new Order();
        o.TotaAmount = System.Convert.ToDecimal(Session["totalAmount"]);
        o.CustomerID = User.Identity.Name;
        Session["CustomerID"] = o.CustomerID;
        o.OrderDate = DateTime.Now;
        o.FirstName = firstnametxt.Text;
        Session["FirstName"] = o.FirstName;
        o.LastName = lastnametxt.Text;
        Session["LastName"] = o.LastName;
        o.Company = companytxt.Text;
        Session["Company"] = o.Company;
        o.Address = addresstxt.Text;
        Session["Address"] = o.Address;
        o.Country = dpcountry.Text;
        Session["Country"] = o.Country;
        o.City = citytxt.Text;
        Session["City"] = o.City;
        o.Province = provincetxt.Text;
        Session["Province"] = o.Province;
        o.ZipCode = zipcodetxt.Text;
        Session["ZipCode"] = o.ZipCode;
        o.Telephone = telephonetxt.Text;
        Session["Telephone"] = o.Telephone;
        o.Fax = faxtxt.Text;
        Session["Fax"] = o.Fax;
        o.status = "New";
        List<OrderItem> items = new List<OrderItem>();
        List<ShoppingCartItem> cartitems;
        cartitems = ShoppingCart.GetItems(User.Identity.Name);
        for (int i = 0; i < cartitems.Count; i++)
        {
            OrderItem item = new OrderItem();
            item.ProductName = cartitems[i].ProductName;
            item.ProductID = cartitems[i].ProductID;
            item.buyPrice = cartitems[i].buyPrice;
            item.Quantity = cartitems[i].Quantity;
            item.UnitCost = cartitems[i].UnitPrice;
            items.Add(item);
        }
        o.OrderID = Order.PlaceOrder(o, items);
        Session["OrderID"] = o.OrderID;
        ShoppingCart.RemoveAll(User.Identity.Name);
        //GridView1.Visible = false;
        Button1.Visible = false;
       // Button2.Visible = false;
        //lblMsg.Text = "Your order has been submitted successfully!";
        Response.Redirect("confirm.aspx");

     /*   dbcon db = new dbcon();
       // int orderedQuantity = System.Convert.ToInt32(lblorderedquantity.Text);
       // string status = "Successful";
        OrderItem it = new OrderItem();
        string a= System.Convert.ToString(Session["ProductID"]);
            string c=System.Convert.ToString(Session["quantity"]);
        string query = "update  products set productquantity=productquantity-'" +c+ "' where ProductID='"+a+"'";

        //string query1 = "update Products set productquantity=productquantity+'" + orderedQuantity + "' where ProductName='" + lblproname.Text + "'";
        //bool b = db.UDI(query);
        bool b = db.UDI(query);
        if (b == true)
        {

           // lblshow.Text = "Product Delivered and Added to DataBase Sucessfully";

        }

        else
        {
            //lblshow.Text = " Operation Not successful";

        }*/
    }
}
