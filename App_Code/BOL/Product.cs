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

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
	public Product()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    private string strName;
    private string strImg;
    private decimal decCost;
    private decimal Oprice;

    private string strDesc;
    private int intCategoryID;
    private int intProductID;

    public string Name
    {
        get
        {
            return strName;
        }
        set
        {
            strName = value;
        }
    }

    public string ProductImage
    {
        get
        {
            return strImg;
        }
        set
        {
            strImg = value;
        }
    }

    public decimal UnitCost
    {
        get
        {
            return decCost;
        }
        set
        {
            decCost = value;
        }
    }

    public decimal oprice
    {
        get
        {
            return Oprice;
        }
        set
        {
            Oprice = value;
        }
    }

    public string Description
    {
        get
        {
            return strDesc;
        }
        set
        {
            strDesc = value;
        }
    }

    public int CategoryID
    {
        get
        {
            return intCategoryID;
        }
        set
        {
            intCategoryID = value;
        }
    }

    public int ProductID
    {
        get
        {
            return intProductID;
        }
        set
        {
            intProductID = value;
        }
    }


    public static Product GetProduct(int productID)
    {
        dbcon obj = new dbcon();
        SqlParameter[] objParams = new SqlParameter[1];
        objParams[0] = new SqlParameter("@ProductID", SqlDbType.Int, 4);
        objParams[0].Value = productID;
        SqlDataReader reader = obj.ExecuteReader("GetProduct", objParams);
        Product p = new Product();
        while (reader.Read())
        {
            p.ProductID = reader.GetInt32(reader.GetOrdinal("ProductID"));
            p.CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID"));
            p.Name = reader.GetString(reader.GetOrdinal("ProductName"));
            p.Description = reader.GetString(reader.GetOrdinal("Description"));
            p.UnitCost = reader.GetDecimal(reader.GetOrdinal("UnitCost"));
            p.ProductImage = reader.GetString(reader.GetOrdinal("ProductImage"));
            p.oprice = reader.GetDecimal(reader.GetOrdinal("origionalPrice"));
        }
        reader.Close();
        return p;
    }
}
