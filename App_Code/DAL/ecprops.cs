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
/// Summary description for ecprops
/// </summary>
public class ecprops
{
	public ecprops()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private string catname;
    public string CatName
    {
        get { return catname; }
        set { catname = value; }
    }


    private string productname;
    public string ProductName
    {
        get { return productname; }
        set { productname = value; }
    }

    private string productprice;
    public string ProductPrice
    {
        get { return productprice; }
        set { productprice = value; }
    }

    private string productdescription;
    public string ProductDescription
    {
        get { return productdescription; }
        set { productdescription = value; }
    }

    private string productimage;
    public string Productimage
    {
        get { return productimage; }
        set { productimage = value; }
    }

    private string categoryid;
    public string CategoryId
    {
        get { return categoryid; }
        set { categoryid = value; }
    }


    //user login 

    private string _userID;
    private string _password;
    private string _role;

    public string UserName
    {
        get
        {
            return _userID;
        }
        set
        {
            _userID = value;
        }
    }
    public string Password
    {
        get
        {
            return _password;
        }
        set
        {
            _password = value;
        }
    }
    public string RoleName
    {
        get
        {
            return _role;
        }
        set
        {
            _role = value;
        }
    }
    private string _addcat;
    public string addcat
    {
        get
        {
            return _addcat;
        }
        set
        {
            _addcat = value;
        }
    }

    private string _rolename;
    public string rolename
    {
        get
        {
            return _rolename;
        }
        set
        {
            _rolename = value;
        }
    }
    private string _addrole;
    public string addrole
    {
        get
        {
            return _addrole;
        }
        set
        {
            _addrole = value;
        }
    }
    private string _myusername;

    public string myUserName
    {
        get
        {
            return _myusername;
        }
        set
        {
            _myusername = value;
        }
    }
    private string _myrolename;
    public string myrolename
    {
        get
        {
            return _myrolename;
        }
        set
        {
            _myrolename = value;
        }
    }
    private string _proid;
    public string proid
    {
        get
        {
            return _proid;
        }
        set
        {
            _proid = value;
        }
    }
    //products page
    private string _filename;
    public string filename
    {
        get
        {
            return _filename;
        }
        set
        {
            _filename = value;
        }
    }

    private string _procatname;
    public string procatname
    {
        get
        {
            return _procatname;
        }
        set
        {
            _procatname = value;
        }
    }


    private string _proproductname;
    public string proproductname
    {
        get
        {
            return _proproductname;
        }
        set
        {
            _proproductname = value;
        }
    }

    private string _unitcost;
    public string unitcost
    {
        get
        {
            return _unitcost;
        }
        set
        {
            _unitcost = value;
        }
    }

    private string _desc;
    public string desc
    {
        get
        {
            return _desc;
        }
        set
        {
            _desc = value;
        }
    }

    private string _oprice;
    public string oprice
    {
        get
        {
            return _oprice;
        }
        set
        {
            _oprice = value;
        }
    }

    private string _proquantity;
    public string proquantity
    {
        get
        {
            return _proquantity;
        }
        set
        {
            _proquantity = value;
        }
    }


    //profitloss page

    private string _strDate;
    public string strDate
    {
        get
        {
            return _strDate;
        }
        set
        {
            _strDate = value;
        }
    }

    private string _endDate;
    public string endDate
    {
        get
        {
            return _endDate;
        }
        set
        {
            _endDate = value;
        }
    }

    // admin orders

    private string _orderid;
    public string orderid
    {
        get
        {
            return _orderid;
        }
        set
        {
            _orderid = value;
        }
    }

    private string _orderidgrid;
    public string orderidgrid
    {
        get
        {
            return _orderidgrid;
        }
        set
        {
            _orderidgrid = value;
        }

    }

    private string _customerid;
    public string customerid
    {
        get
        {
            return _customerid;
        }
        set
        {
            _customerid = value;
        }

    }








    
}
