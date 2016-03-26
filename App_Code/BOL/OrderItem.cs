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
/// Summary description for OrderItem
/// </summary>
public class OrderItem
{
	public OrderItem()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private int intOrderID;
    private int intProductID;
    private int intQty;
    private decimal decCost;
    private string strName;

    public int OrderID
    {
        get
        {
            return intOrderID;
        }
        set
        {
            intOrderID = value;
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
            return strName;
        }
        set
        {
            strName = value;
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
            intbuyprice= value;
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

}
