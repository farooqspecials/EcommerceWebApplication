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

public partial class acknowledge : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblstockid.Text = Request.QueryString["ID"];
        if (!IsPostBack)
        {
            //string query = "select SupplierName,SupplierCell,SupplierAddress,SupplierQuantity,OrderDate from Stock where ProductName='" + Request.QueryString["ID"] + "'";
            string query = "select * from Stock where StockId='" + Request.QueryString["ID"] + "'";
            DataSet ds = obj.fillgrid(query);
            DataTable dt = ds.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                lblproname.Text = dr["ProductName"].ToString();
                lblsuppliername.Text = dr["SupplierName"].ToString();

                lblsuppliercell.Text = dr["SupplierCell"].ToString();
                lblsupplieradress.Text = dr["SupplierAddress"].ToString();
                lblorderedquantity.Text = dr["OrderedQuantity"].ToString();
                lblorderingdate.Text = dr["OrderDate"].ToString();
                

            }

        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbcon db = new dbcon();
        int orderedQuantity = System.Convert.ToInt32(lblorderedquantity.Text);
        string status = "Successful";
       // string query = "update  Stock set OrderedQuantity=OrderedQuantity-'" + orderedQuantity + "',DelivaryStatus='" + status + "',DelivaryDate='" + DateTime.Now + "' where StockId='" + Request.QueryString["ID"] + "'";
        string query = "update  Stock set DelivaryStatus='" + status + "',DelivaryDate='" + DateTime.Now + "' where StockId='" + Request.QueryString["ID"] + "'";
        string query1="update Products set productquantity=productquantity+'"+orderedQuantity+"' where ProductName='"+lblproname.Text+"'";
        //bool b = db.UDI(query);
        bool b = db.mdi(query,query1);
        if (b == true)
        {

            lblshow.Text = "Product Delivered and Added to DataBase Sucessfully";

        }

        else
        {
            lblshow.Text = " Operation Not successful";

        }
    }


    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        Response.Redirect("stockreport.aspx");
    }
    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        Response.Redirect("stockalerts.aspx");
    }
}
