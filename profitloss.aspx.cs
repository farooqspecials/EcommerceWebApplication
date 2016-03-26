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

public partial class profitloss : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
       

    }
    dbcon obj = new dbcon();
    /*public void bind()
    {
        //string query = "select * from ESK_Products";
        string query = "SELECT Products.ProductID,Products.ProductName, Products.origionalPrice, OrderDetails.Quantity,OrderDetails.UnitCost,OrderDetails.PurchaseDate FROM Products LEFT JOIN OrderDetails ON Products.ProductID=OrderDetails.ProductID where OrderDetails.PurchaseDate Between '" + txtstrdate.Text + "' and '" + txtenddate.Text + "'";
        DataSet ds = obj.fillgrid(query);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }*/
    protected void btnsbt_Click(object sender, EventArgs e)
    {
        bind();
    }
    ecprops prop = new ecprops();
    private void bind()
    {
        
            Businesslayer bus = new Businesslayer();
            prop.strDate = txtstrdate.Text;
            prop.endDate = txtenddate.Text;
            int count = bus.bll_salecount(prop);
            if (count > 0)
            {
                lblresult.Visible = false;
                GridView1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                lblsale.Visible = true;
                GridView1.DataSource = GridDataSource();
                GridView1.DataBind();
               // btnsbt.Attributes["onclick"] = "some problem";
            }
            else
            {
                GridView1.Visible = false;
                lblresult.Visible = true;
                Label2.Visible = false;
                Label3.Visible = false;
                lblsale.Visible = false;
                //Button1.Attributes["onclick"] = "AlertHello()";
                //btnsbt.Attributes["onclick"] = "show_alert()";



               lblresult.Text = "Sorry no Records found between these dates";
            
        }
    }

    private DataTable GridDataSource()
    {
                
                prop.strDate = txtstrdate.Text;
                prop.endDate = txtenddate.Text;
                Businesslayer p = new Businesslayer();
                DataTable dTable = new DataTable();
                try
                {
                    dTable = p.bllLoadProfit(prop);
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


   /* public Object Get_Amount(decimal Price, int Quantity)
    {
        Decimal Amount = (Price * Quantity);
        return string.Format("{0:N2}", Amount);
    }*/
    private decimal decTotal;
    private decimal mytotal;
    private decimal totalsale;
    private decimal totalbuy;

    protected void _row(object sender, GridViewRowEventArgs e)
    {
          if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //int prodid = int.Parse(e.Row.Cells[0].Text);
            int prodid=int.Parse(((Label)(e.Row.FindControl("lblproid"))).Text);
            int qty = int.Parse(((Label)(e.Row.FindControl("lblquantity"))).Text);
            Product p = Product.GetProduct(prodid);
            decTotal= qty * p.UnitCost;
            mytotal = qty * p.oprice;
            double a =(double)decTotal; //converting decTotal to double
            double b = (double)mytotal; //converting mytotal to double
            ((Label)(e.Row.FindControl("lbltotalsale"))).Text = a.ToString();// decTotal.ToString();
            ((Label)(e.Row.FindControl("lbltotalbuy"))).Text = b.ToString(); // mytotal.ToString();
            totalsale = totalsale + (qty * p.UnitCost);
            totalbuy = totalbuy + (qty *p.oprice);
            double grandsale = (double)totalsale; // converting total sale to double
            double grandbuy = (double)totalbuy;
            lblsale.Text = "Total Amount for which The Products are Sold is   :"+grandsale.ToString();
            Label2.Text = "Total Amount On which The Products are Brought is  :"+grandbuy.ToString();
            decimal total = totalsale - totalbuy;
            double grandtotal=(double)total;
            Label3.Text = "Total Profit  :"+grandtotal.ToString();

            
           // Session["totalAmount"] = decTotal;
        }
          if (e.Row.RowType == DataControlRowType.Footer)
          {
              
           //  ((Label)(e.Row.FindControl("lblfotter1"))).Text = "Total SalePrice :" + "Rs " + totalsale.ToString();
             // ((Label)(e.Row.FindControl("lblfotter2"))).Text = "Total BuyPrice :" + "Rs " + totalbuy.ToString();
          } 
    }
    protected void _pageindexchange(object sender, EventArgs e)
    {
        
    }
    protected void _indexchange(object sender, EventArgs e)
    {
       // GridView1.PageIndex = e.NewPageIndex;


        //bind();
    }
    protected void _pagechange(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;

        bind();
    }
}
