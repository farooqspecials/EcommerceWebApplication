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

/// <summary>
/// Summary description for ShoppingCartItem
/// </summary>
public class ShoppingCartItem
{
	public ShoppingCartItem()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private string strCustomerID;
    private int intProductID;
    private string strProductName;
    private decimal decUnitPrice;
    private int intQty;

    public string CustomerID
    {
        get
        {
            return strCustomerID;
        }
        set
        {
            strCustomerID = value;
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

    public string ProductName
    {
        get
        {
            return strProductName;
        }
        set
        {
            strProductName = value;
        }
    }

    public decimal UnitPrice
    {
        get
        {
            return decUnitPrice;
        }
        set
        {
            decUnitPrice = value;
        }
    }

    public int Quantity
    {
        get
        {
            return intQty;
        }
        set
        {
            intQty = value;
        }
    }
    private decimal intbuyprice;
    public decimal buyPrice
    {
        get
        {
            return intbuyprice;
        }
        set
        {
            intbuyprice = value;
        }
    }
}
