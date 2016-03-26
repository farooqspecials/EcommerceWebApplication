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
/// Summary description for dblayer
/// </summary>
public class dblayer
{
	public dblayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    bool b = false;
    dbcon obj = new dbcon();
    //ecprops prop = new ecprops();


    public bool dal_insert(ecprops p)
    {

        String query = "INSERT INTO Categories VALUES('" + p.CatName + "')";

        b = obj.UDI(query);




        if (b)

            return true;

        else

            return false;
    }

    public bool dal_insertproducts(ecprops p)
    {

        String query = "insert into Products(CategoryID,ProductName,ProductImage,UnitCost,Description,origionalPrice,productquantity) select CategoryID,'" + p.proproductname + "','" + "Images/" + p.filename + "'," + p.unitcost + ",'" + p.desc + "','"+ p.oprice+"','"+p.proquantity+"' from Categories where CategoryName='" + p.procatname + "'";

        b = obj.UDI(query);




        if (b)

            return true;

        else

            return false;
    }




    public bool daladdrole(ecprops p)
    {

        String query = "insert into groups values ('" + p.addrole + "')";

        b = obj.UDI(query);




        if (b)

            return true;

        else

            return false;
    }

    public bool dllassignrole(ecprops p)
    {

        String query = "INSERT INTO ROLES (UserId,GroupId) SELECT UserId,GroupId FROM Users, Groups WHERE username= '" + p.UserName + "' AND RoleName='" + p.rolename + "'";;

        b = obj.UDI(query);




        if (b)

            return true;

        else

            return false;
    }



   
    }
