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
/// Summary description for registerUser
/// </summary>
public class registerUser
{
	public registerUser()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private string strFirstName;
    private string strLastName;
    private string strUserName;
    private string strPassword;
    private string strEmail;
    private string strMobileNo;
    /*private string strresult;
    
    public string result
    {
        get
        {
            return strresult;
        }
        set
        {
            strresult = value;
        }
    }
    */



   
    public string UserName
    {
        get
        {
            return strUserName;
        }
        set
        {
            strUserName = value;
        }
    }

    public string Password
    {
        get
        {
            return strPassword;
        }
        set
        {
            strPassword = value;
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

    public string Email
    {
        get
        {
            return strEmail;
        }
        set
        {
            strEmail = value;
        }
    }

    public string MobileNo
    {
        get
        {
            return strMobileNo;
        }
        set
        {
            strMobileNo = value;
        }
    }

    public int insertUser(registerUser reg)
    {
        dbcon obj = new dbcon();
        SqlParameter[] objParams = new SqlParameter[6];


        objParams[0] = new SqlParameter("@UserName", reg.UserName);
        objParams[1] = new SqlParameter("@Password", reg.Password);
        objParams[2] = new SqlParameter("@FirstName", reg.FirstName);
        objParams[3] = new SqlParameter("@LastName", reg.LastName);
        objParams[4] = new SqlParameter("@Email", reg.Email);
        objParams[5] = new SqlParameter("@Mobile", reg.MobileNo);
        //objParams[6] = new SqlParameter("@Result", reg.result);

        int b=obj.ExecuteNonQuery("insertUser", objParams);
        return b;
    }

   

   


   

    

   
}
