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
using System.Collections.Generic;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
	public Order()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private int intOrderID;
    private string strCustomerID;
    private DateTime dtOrderDate;
    private decimal decTotalAmt;
    private string strFirstName;
    private string strLastName;
    private string strCompany;
    private string strAddress;
    private string strCountry;
    private string strCity;
    private string strProvince;
    private string strZipCode;
    private string strTelephone;
    private string strFax;
    private int userid;

    public int UserID
    {
        get
        {
            return userid;
        }
        set
        {
            userid = value;
        }
    }


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

    public DateTime OrderDate
    {
        get
        {
            return dtOrderDate;
        }
        set
        {
            dtOrderDate = value;
        }
    }

    public decimal TotaAmount
    {
        get
        {
            return decTotalAmt;
        }
        set
        {
            decTotalAmt = value;
        }


   }

    public string FirstName
    {
        get
        {
            return strFirstName;
        }
        set
        {
            strFirstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return strLastName;
        }
        set
        {
            strLastName = value;
        }
    }

    public string Company
    {
        get
        {
            return strCompany;
        }
        set
        {
            strCompany = value;
        }
    }

    public string Address
    {
        get
        {
            return strAddress;
        }
        set
        {
            strAddress = value;
        }
    }

    public string Country
    {
        get
        {
            return strCountry;
        }
        set
        {
            strCountry = value;
        }
    }

    public string City
    {
        get
        {
            return strCity;
        }
        set
        {
            strCity = value;
        }
    }


    public string Province
    {
        get
        {
            return strProvince;
        }
        set
        {
            strProvince = value;
        }
    }

    public string ZipCode
    {
        get
        {
            return strZipCode;
        }
        set
        {
            strZipCode = value;
        }
    }

    public string Telephone
    {
        get
        {
            return strTelephone;
        }
        set
        {
            strTelephone = value;
        }
    }

    public string Fax
    {
        get
        {
            return strFax;
        }
        set
        {
            strFax = value;
        }
    }
    private string _status;
    public string status
    {
        get
        {
            return _status;
        }
        set
        {
            _status = value;
        }
    }
    public static int PlaceOrder(Order o, List<OrderItem> listOI)
    {
        dbcon obj = new dbcon();
        SqlParameter[] objParams = new SqlParameter[14];

        objParams[0] = new SqlParameter("@CustomerID", o.CustomerID);
        objParams[1] = new SqlParameter("@OrderDate", o.OrderDate);
        objParams[2] = new SqlParameter("@FirstName", o.FirstName);
        objParams[3] = new SqlParameter("@LastName", o.LastName);
        objParams[4] = new SqlParameter("@Company", o.Company);
        objParams[5] = new SqlParameter("@Address", o.Address);
        objParams[6] = new SqlParameter("@Country", o.Country);
        objParams[7] = new SqlParameter("@City", o.City);
        objParams[8] = new SqlParameter("@Province", o.Province);
        objParams[9] = new SqlParameter("@ZipCode", o.ZipCode);
        objParams[10] = new SqlParameter("@Telephone", o.Telephone);
        objParams[11] = new SqlParameter("@Fax", o.Fax);
        objParams[12] = new SqlParameter("@totalAmount", o.TotaAmount);
        objParams[13] = new SqlParameter("@Status", o.status);

        o.OrderID = int.Parse(obj.ExecuteScalar("InsertOrder", objParams).ToString());
        foreach (OrderItem item in listOI)
        {
            SqlParameter[] objParams2 = new SqlParameter[7];
            objParams2[0] = new SqlParameter("@OrderID", o.OrderID);
            objParams2[1] = new SqlParameter("@ProductID", item.ProductID);
            objParams2[2] = new SqlParameter("@Quantity", item.Quantity);
            
            objParams2[3] = new SqlParameter("@UnitCost", item.UnitCost);
            objParams2[4] = new SqlParameter("@PurchaseDate", DateTime.Now);
            objParams2[5] = new SqlParameter("@ProductName", item.ProductName);
            objParams2[6] = new SqlParameter("@buyprice", item.buyPrice);

            obj.ExecuteNonQuery("InsertOrderItem", objParams2);
        }
        return o.OrderID;
    }


}
