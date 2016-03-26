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
/// Summary description for Global
/// </summary>
public class Global
{
	public Global()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    static int _currentpage;
    public static int currentpage
    {
        get { return _currentpage; }
        set { _currentpage = value; }
    }
}
