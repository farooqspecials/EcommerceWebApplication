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
/// Summary description for Businesslayer
/// </summary>
public class Businesslayer
{
	public Businesslayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    dblayer d = new dblayer();
       
        public bool bll_insert(ecprops p)
        {

            bool b = d.dal_insert(p);
            return b;

            //return true;
        }

        public bool bll_insertproducts(ecprops p)
        {

            bool b = d.dal_insertproducts(p);
            return b;

            //return true;
        }

        public DataTable Load()
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.Load();
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }

        public DataTable bll_catnav()
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dll_catnav();
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }

        public DataTable bllloadrolename()
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dllloadrolename();
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }

        public DataTable blluserinrole()
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dlluserinrole();
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }

        public DataTable bllstockreport()
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dllstockreport();
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }

        public DataTable bllstockhistory(ecprops pro)
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dllstockhistory(pro);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }

        
        public DataTable bllloadcatgrid()
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dllloadcatgrid();
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }

    // admin orders

        public DataTable bllorderreader(ecprops p)
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dllorderreader(p);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }


        public DataTable bllgridorder(ecprops p)
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dllgridorder(p);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }

        public DataTable blladminorders()
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dlladminorders();
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }


        public DataSet bllLoadDt()
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dllLoadDt();
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }


        public DataTable bllLoadProfit(ecprops p)
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dllLoadProfit(p);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }

        public DataTable bllloadproductstable()
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dllloadproductstable();
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }

        public DataTable bllStockAlert()
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dllStockAlert();
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }



        public SqlDataReader bllloadreader()
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dllloadreader();
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }







        public int Delete(string Username)
        {
            dbcon pDAL = new dbcon();
            try
            {
                return pDAL.Delete(Username);
            }
            catch
            {
                throw;
            }
            finally
            {
                pDAL = null;
            }
        }


        public int count(ecprops p)
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.checkcount(p);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }
        public int bll_viewcart(ecprops p)
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dll_viewcart(p);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }


     public int bll_salecount(ecprops p)
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.dll_salecount(p);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }


        public int countrole(ecprops p)
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.checkcountrole(p);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }

        public int assingrolecount(ecprops p)
        {
            dbcon obj = new dbcon();
            try
            {
                return obj.checkassingrolecount(p);
            }
            catch
            {
                throw;
            }
            finally
            {
                obj = null;
            }
        }

        public bool blladdrole(ecprops p)
        {

            bool b = d.daladdrole(p);
            return b;

            //return true;
        }

        public bool bllassignrole(ecprops p)
        {

            bool b = d.dllassignrole(p);
            return b;

            
        }


       
}
