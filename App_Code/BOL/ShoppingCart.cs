using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

/// <summary>
/// Summary description for ShoppingCart
/// </summary>
public class ShoppingCart
{
	public ShoppingCart()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static int AddItem(ShoppingCartItem item)
    {
        dbcon obj = new dbcon();
        SqlParameter[] objParams = new SqlParameter[3];
        objParams[0] = new SqlParameter("@CustomerID", item.CustomerID);
        objParams[1] = new SqlParameter("@Quantity", item.Quantity);
        objParams[2] = new SqlParameter("@ProductID", item.ProductID);
        return obj.ExecuteNonQuery("AddToCart", objParams);
    }

    public static int UpdateItem(ShoppingCartItem item)
    {
        dbcon obj = new dbcon();
        SqlParameter[] objParams = new SqlParameter[3];
        objParams[0] = new SqlParameter("@Quantity", item.Quantity);
        objParams[1] = new SqlParameter("@CustomerID", item.CustomerID);
        objParams[2] = new SqlParameter("@ProductID", item.ProductID);
        return obj.ExecuteNonQuery("UpdateCart", objParams);
    }

    public static List<ShoppingCartItem> GetItems(string customerID)
    {
        dbcon obj = new dbcon();
        SqlParameter[] objParams = new SqlParameter[1];
        objParams[0] = new SqlParameter("@CustomerID", customerID);
        SqlDataReader reader = obj.ExecuteReader("GetCartForCustomer", objParams);
        List<ShoppingCartItem> objList = new List<ShoppingCartItem>();
        while (reader.Read())
        {
            ShoppingCartItem item = new ShoppingCartItem();
            item.CustomerID = reader.GetString(reader.GetOrdinal("CustomerID"));
            item.ProductID = reader.GetInt32(reader.GetOrdinal("ProductID"));
            item.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
            item.buyPrice=reader.GetDecimal(reader.GetOrdinal("origionalPrice"));
            item.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
            item.UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitCost"));
            objList.Add(item);
        }
        reader.Close();
        return objList;
    }

    public static int RemoveAll(string customerID)
    {
        dbcon obj = new dbcon();
        SqlParameter[] objParams = new SqlParameter[1];
        objParams[0] = new SqlParameter("@CustomerID", customerID);
        return obj.ExecuteNonQuery("EmptyCart", objParams);
    }


}
