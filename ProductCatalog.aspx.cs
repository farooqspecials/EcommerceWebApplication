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

public partial class ProductCatalog : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    public string proid;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            
            //LoadGridView();
            
            mycatdata();

            if (Request.QueryString["LoadGridView"] != null)
            {
                if (Convert.ToBoolean(Request.QueryString["LoadGridView"]))
                {
                    LoadGridView();
                }

            }

            if (Request.QueryString["method2"] != null)
            {
                if (Convert.ToBoolean(Request.QueryString["method2"]))
                {
                    method2();
                }

            }

            if (Request.QueryString["method3"] != null)
            {
                if (Convert.ToBoolean(Request.QueryString["method3"]))
                {
                    method3();
                }

            }


            if (Request.QueryString["method4"] != null)
            {
                if (Convert.ToBoolean(Request.QueryString["method4"]))
                {
                    method4();
                }

            }
       
            

        }

      /* if (!IsPostBack)
        {



            Search();

        }
        */
        

                    
                   



    }
    private void LoadGridView()
    {
        
       // string query = "Select * from Products where CategoryID='" + Request.QueryString["ID"] + "' Or ProductID ='" + Request.QueryString["ID"] + "'or '"+int.TryParse(Request.QueryString["PriceID"]<5000)+"'";// or ProductName='"+Request.QueryString["Name"]+"'";
       
            
          

        if (Request.QueryString["ID"] != null && Request.QueryString["ID"].ToString() != "")
        {
           
            string query = "Select * from Products where ProductID in (" + Request.QueryString["ID"].ToString().Substring(1) + ") AND UnitCost < 5000" ;
            
           
            
            DataSet dss = obj.fillgrid(query);
            
            GridView1.DataSource = dss.Tables[0];
            GridView1.DataBind();
        }
        //}
        //conn.Close();
    }

    public void method2()
        {
        
        if (Request.QueryString["ID"] != null && Request.QueryString["ID"].ToString() != "")
        {
           
            string query = "Select * from Products where ProductID in (" + Request.QueryString["ID"].ToString().Substring(1) + ") AND UnitCost between 5000 and 9999" ;
            
           
            
            DataSet dss = obj.fillgrid(query);
            
            GridView1.DataSource = dss.Tables[0];
            GridView1.DataBind();
        }
        
    }

    public void method3()
    {

        if (Request.QueryString["ID"] != null && Request.QueryString["ID"].ToString() != "")
        {

            string query = "Select * from Products where ProductID in (" + Request.QueryString["ID"].ToString().Substring(1) + ") AND UnitCost between 10000 and 20000";



            DataSet dss = obj.fillgrid(query);

            GridView1.DataSource = dss.Tables[0];
            GridView1.DataBind();
        }

    }

    public void method4()
    {

        if (Request.QueryString["ID"] != null && Request.QueryString["ID"].ToString() != "")
        {

            string query = "Select * from Products where ProductID in (" + Request.QueryString["ID"].ToString().Substring(1) + ") AND UnitCost >20000";



            DataSet dss = obj.fillgrid(query);

            GridView1.DataSource = dss.Tables[0];
            GridView1.DataBind();
        }

    }

    private void mycatdata()
    {
        
            string query = "Select * from Products where CategoryID='" + Request.QueryString["ID"] + "' Or ProductID ='" + Request.QueryString["ID"] + "'";



            DataSet dss = obj.fillgrid(query);

            GridView1.DataSource = dss.Tables[0];
            GridView1.DataBind();
        
        
        
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
   
    protected void _RowCammand(object sender, GridViewCommandEventArgs e)
    {
        if (!(User.Identity.IsAuthenticated))
        {
            Response.Redirect("~/login.aspx");
        }

        string querycount= "Select Count(*) FROM Products where productid ='" +System.Convert.ToInt32(e.CommandArgument) + "' and productquantity='"+0+"'";
        int count = obj.ohh(querycount);
        if (count >0)
        {
          
           for (int i = 0; i < GridView1.Rows.Count; i++)
           {
               Button btn = (Button)GridView1.Rows[i].FindControl("btnaddcart");
               //Change the property settings for the button in your TemplateField
               btn.Attributes.Add("onclick","showstock()");
           }
 

            


        }
        else
        {
            
            ShoppingCartItem item = new ShoppingCartItem();
            item.CustomerID = User.Identity.Name;
            item.ProductID = System.Convert.ToInt32(e.CommandArgument);
            item.Quantity = 1;
           int b= ShoppingCart.AddItem(item);
           if (b == 1)
           {
               lblshow.Text = "The Product is Added to Cart Successfully";
           }
           else
           {
               lblshow.Text = " The Product is Already in Cart";
           }
        }
        
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    

}
