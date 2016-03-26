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

public partial class search : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Search();

        }
        if (GridView1.Rows.Count == 0)
        {
            lblsearch.Text = "No Records Found";
        }
    }

     private void Search()
      {
          //conn.Open();
          string query = "Select * from Products where ProductName Like '" + Request.QueryString["Name"] + "%'";
          //DataSet ds = new DataSet();
          DataSet ds = obj.fillgrid(query);
          GridView1.DataSource = ds.Tables[0];
          GridView1.DataBind(); ;
          //conn.Close();
      }

     protected string GetShortDescription(string longdesc)
     {
         if (longdesc.Length <= 255)
         {
             return longdesc;
         }
         else
         {
             return longdesc.Substring(0, 255) + "...";
         }
     }




     protected void _rowcommand(object sender, GridViewCommandEventArgs e)
     {
         if (!(User.Identity.IsAuthenticated))
         {
             Response.Redirect("~/login.aspx");
         }

         string querycount = "Select Count(*) FROM Products where productid ='" + System.Convert.ToInt32(e.CommandArgument) + "' and productquantity='" + 0 + "'";
         int count = obj.ohh(querycount);
         if (count > 0)
         {

             for (int i = 0; i < GridView1.Rows.Count; i++)
             {
                 Button btn = (Button)GridView1.Rows[i].FindControl("btnaddcart");
                 //Change the property settings for the button in your TemplateField
                 btn.Attributes["onclick"] = "showstock()";
             }





         }
         else
         {

             ShoppingCartItem item = new ShoppingCartItem();
             item.CustomerID = User.Identity.Name;
             item.ProductID = System.Convert.ToInt32(e.CommandArgument);
             item.Quantity = 1;
             int b = ShoppingCart.AddItem(item);
             if (b == 1)
             {
                 lblsearch.Text = "The Product is Added to Cart Successfully";
             }
         }


     }
}
