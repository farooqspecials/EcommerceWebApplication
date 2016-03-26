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
/// Summary description for dbcon
/// </summary>
public class dbcon
{
	public dbcon()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static string connectionString = "Data Source=Farooq\\SQLEXPRESS;AttachDbFilename=|DataDirectory|shop.mdf;Integrated Security=True;User Instance=True";
    //public static string connectionString = " Data Source=FAROOQPC\\SQLEXPRESS; Integrated Security=True; AttachDbFilename=|DataDirectory|shop.mdf;Initial Catalog=shop";
    // public static string connectionString = "Data Source=FAROOQPC\\SQLEXPRESS; Initial Catalog=shop; Integrated Security=True";
        SqlConnection MAconn;
        SqlCommand MAcmd;
        SqlDataReader dr;
        public bool UDI(String query)
        {
            int c = 0;
            try
            {
                MAconn = new SqlConnection();
                MAconn.ConnectionString = connectionString;
                MAconn.Open();

                MAcmd = MAconn.CreateCommand();
                MAcmd.CommandText = query;
                c = MAcmd.ExecuteNonQuery();
                MAconn.Close();


            }


            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            if (c > 0)

                return true;

            else

                return false;

        }



       
        


        public bool mdi(String query,String query1)
        {
            int c = 0;
            try
            {
                MAconn = new SqlConnection();
                MAconn.ConnectionString = connectionString;
                MAconn.Open();

                MAcmd = MAconn.CreateCommand();
                MAcmd.CommandText = query;
                MAcmd.ExecuteNonQuery();
                MAconn.Close();

                MAconn.Open();
                MAcmd.CommandText = query1;
                c = MAcmd.ExecuteNonQuery();
                MAconn.Close();


            }


            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            if (c > 0)

                return true;

            else

                return false;

        }


        public DataSet fillgrid(String query)
        {
            DataSet ds = null;
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionString);
                ds = new DataSet();
                dataAdapter.Fill(ds, "*.mdb");

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
            return ds;

        }

        public SqlDataReader fillcomb(String querydr)
        {
            SqlDataReader dr = null;
            try
            {
                MAconn = new SqlConnection();
                MAconn.ConnectionString = connectionString;
                MAconn.Open();

                MAcmd = MAconn.CreateCommand();
                MAcmd.CommandText = querydr;
                dr = MAcmd.ExecuteReader();

               // return dr;
               // MAconn.Close();

                //SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionString);
                //ds = new DataSet();
                //dataAdapter.Fill(ds, "*.mdb");

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
            return dr;

        }

    public SqlDataReader dllloadreader()
    {
    SqlConnection cnn = new SqlConnection(connectionString);
    string query = "Select * from Categories";
    SqlCommand cmd = new SqlCommand(query, cnn);
       
            cnn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
    }

        public int ohh(String query)
        {
            int c; 
           // try
           // {
                MAconn = new SqlConnection();
                MAconn.ConnectionString = connectionString;
                MAconn.Open();

                MAcmd = MAconn.CreateCommand();
                MAcmd.CommandText = query;
                c =(int)MAcmd.ExecuteScalar();


                MAconn.Close();

                return c;

          
            
            
        }


       
        public ecprops CheckUser(string UserName)
        {
            MAconn = new SqlConnection(connectionString);
            const string SP_CHECKUSER = "CheckUser";
            MAconn.Open();
            MAcmd = new SqlCommand(SP_CHECKUSER, MAconn);
            MAcmd.CommandType = CommandType.StoredProcedure;
            MAcmd.Parameters.Add("@UserName", DbType.String).Value = UserName;
            dr = MAcmd.ExecuteReader();
           ecprops _user = null;
            while (dr.Read())
            {
                _user = new ecprops();
                _user.Password = dr["Password"].ToString();
                _user.RoleName = dr["RoleName"].ToString();
            }
            return _user;
        }


        public int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, cnn);
           // if (query.StartsWith("INSERT") | query.StartsWith("insert") | query.StartsWith("UPDATE") | query.StartsWith("update") | query.StartsWith("DELETE") | query.StartsWith("delete"))
            //{
            //    cmd.CommandType = CommandType.Text;
           // }
           // else
          //  {
                cmd.CommandType = CommandType.StoredProcedure;
           // }
            for (int i = 0; i <= parameters.Length - 1; i++)
            {
                cmd.Parameters.Add(parameters[i]);
            }
            cnn.Open();
            int retval = cmd.ExecuteNonQuery();
            cnn.Close();
            return retval;
        }

        public SqlDataReader ExecuteReader(string query, params SqlParameter[] parameters)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i <= parameters.Length - 1; i++)
            {
                cmd.Parameters.Add(parameters[i]);
            }
            cnn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, cnn);
           // if (query.StartsWith("SELECT") | query.StartsWith("select"))
           // {
           //     cmd.CommandType = CommandType.Text;
           // }
           // else
           // {
                cmd.CommandType = CommandType.StoredProcedure;
           // }
            for (int i = 0; i <= parameters.Length - 1; i++)
            {
                cmd.Parameters.Add(parameters[i]);
            }
            cnn.Open();
            object retval = cmd.ExecuteScalar();
            cnn.Close();
            return retval;
        }

        public static string body;
        public static string email;
        public static string mobile;

        public bool getUserPassword(string UserName)
        {
            bool validEmail = false;

            SqlConnection con = new SqlConnection();    //Create an SqlConnection object.

            //Pass the connection string to the SqlConnection object 

            con.ConnectionString = connectionString;

            con.Open();  //Open the connection 

            string procedureText = "retriveUserPassword";

            SqlCommand cmd = new SqlCommand(procedureText, con); //Create an SqlCommand object.

            cmd.CommandType = CommandType.StoredProcedure; //Change the behaviour of command text to stored procedure.

            cmd.Parameters.Add(new SqlParameter("@UserName",UserName));  //Pass value to the parameter that you have created in procedure.

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                mobile = dr["MobileNo"].ToString();
                email = dr["Email"].ToString();
                body = "Welcome  "+dr["UserName"].ToString()+"Your Password is " + dr["Password"].ToString();
                validEmail = true;

            }

            else
            {

                HttpContext.Current.Response.Write("<script>alert('UserName does not exist')</script>");



            }

            con.Close();
            //return body;
            return validEmail;


        }

        public static string msgbody;
        public bool getUserPasswordByMobile(string MobileNo)
        {
            bool validEmail = false;

            SqlConnection con = new SqlConnection();    //Create an SqlConnection object.

            //Pass the connection string to the SqlConnection object 

            con.ConnectionString = connectionString;

            con.Open();  //Open the connection 

            string procedureText = "retriveUserPasswordByMobile";

            SqlCommand cmd = new SqlCommand(procedureText, con); //Create an SqlCommand object.

            cmd.CommandType = CommandType.StoredProcedure; //Change the behaviour of command text to stored procedure.

            cmd.Parameters.Add(new SqlParameter("@MobileNo", MobileNo));  //Pass value to the parameter that you have created in procedure.

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {


                msgbody = "Welcome  " + dr["UserName"].ToString() + "  Your Password is " + dr["Password"].ToString();
                validEmail = true;

            }

            else
            {

                HttpContext.Current.Response.Write("<script>alert('Email does not exist')</script>");



            }

            con.Close();
            //return body;
            return validEmail;


        }


        public static string mymsg;
        public static string phoneno;
        public void GetInvoice(object orderid)
        {
            

            SqlConnection con = new SqlConnection();    //Create an SqlConnection object.

            //Pass the connection string to the SqlConnection object 

            con.ConnectionString = connectionString;

            con.Open();  //Open the connection 

            string procedureText = "GetInvoice";

            SqlCommand cmd = new SqlCommand(procedureText, con); //Create an SqlCommand object.

            cmd.CommandType = CommandType.StoredProcedure; //Change the behaviour of command text to stored procedure.
            // HttpContext.Current.Session["OrderID"];
            //string b = (string)HttpContext.Current.Session["OrderID"];
            cmd.Parameters.Add(new SqlParameter("@OrderID", orderid));  //Pass value to the parameter that you have created in procedure.
            //cmd.Parameters.Add(new SqlParameter("@Telephone", Telephone));
            SqlDataReader dr = cmd.ExecuteReader();
            

            if (dr.Read())
            {
                phoneno = dr["Telephone"].ToString();
                mymsg = "Thankyou " + dr["FirstName"].ToString() + " For Shopping with us.Your Ordered No is: "+dr["OrderID"].ToString()+" Please keep it for Corresponding with Us. Your Order will be Delivered Soon to : "+dr["Address"].ToString();

                //Response.Write("<script>alert('Password is  :" + dr[0].ToString() + "')</script>");

            }

            else
            {

                //Response.Write("<script>alert('User Name does not exist')</script>");

            }

            con.Close();

        }

        public DataTable Load()
        {
           // using (SqlConnection conn = new SqlConnection(connectionString))
            SqlConnection conn = new SqlConnection(connectionString);
            //{
                //using (SqlDataAdapter dAd = new SqlDataAdapter("select * from users", conn))
            SqlDataAdapter dAd = new SqlDataAdapter("select * from users", conn);

               // {
                    DataTable dTable = new DataTable();
                    dAd.Fill(dTable);
                    return dTable;
               // }
           // }
        }

        public DataTable dll_catnav()
        {
            // using (SqlConnection conn = new SqlConnection(connectionString))
            SqlConnection conn = new SqlConnection(connectionString);
            //{
            //using (SqlDataAdapter dAd = new SqlDataAdapter("select * from users", conn))
            SqlDataAdapter dAd = new SqlDataAdapter("select * from categories", conn);

            // {
            DataTable dTable = new DataTable();
            dAd.Fill(dTable);
            return dTable;
            // }
            // }
        }


        public DataTable dllloadrolename()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter dAd = new SqlDataAdapter("select * from groups", conn);

           
            DataTable dTable = new DataTable();
            dAd.Fill(dTable);
            return dTable;
            
        }

        public DataTable dlluserinrole()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter dAd = new SqlDataAdapter("select users.UserName, groups.RoleName from users inner join roles on roles.userid=users.userid inner join groups on roles.groupid=groups.groupid", conn);


            DataTable dTable = new DataTable();
            dAd.Fill(dTable);
            return dTable;

        }

       

     public DataTable dllstockreport()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter dAd = new SqlDataAdapter("select * from Products", conn);


            DataTable dTable = new DataTable();
            dAd.Fill(dTable);
            return dTable;

        }

     public DataTable dllstockhistory(ecprops p)
     {
         SqlConnection conn = new SqlConnection(connectionString);
         SqlDataAdapter dAd = new SqlDataAdapter("Select * from stock where ProductId='" + p.proid+ "'", conn);


         DataTable dTable = new DataTable();
         dAd.Fill(dTable);
         return dTable;

     }

     public DataTable dllloadcatgrid()
     {
         SqlConnection conn = new SqlConnection(connectionString);
         SqlDataAdapter dAd = new SqlDataAdapter("select * from Categories", conn);


         DataTable dTable = new DataTable();
         dAd.Fill(dTable);
         return dTable;

     }

    //admin orders

     public DataTable dllorderreader(ecprops p)
     {
         SqlConnection conn = new SqlConnection(connectionString);
         SqlDataAdapter dAd = new SqlDataAdapter("select customerID,FirstName,LastName,Company,Address,Country,Province,ZipCode,Telephone,Fax,City,Status,totalAmount from Orders where OrderID='" +p.orderid+ "'", conn);


         DataTable dTable = new DataTable();
         dAd.Fill(dTable);
         return dTable;

     }

     public DataTable dllgridorder(ecprops p)
     {
         SqlConnection conn = new SqlConnection(connectionString);
         //SqlDataAdapter dAd = new SqlDataAdapter("select Products.ProductID,Products.ProductName,OrderDetails.UnitCost,OrderDetails.Quantity from Products RIGHT JOIN OrderDetails on Products.ProductID=OrderDetails.ProductID where OrderID='" +p.orderidgrid+ "'", conn);

         SqlDataAdapter dAd = new SqlDataAdapter("select ProductID,ProductName,UnitCost,Quantity from OrderDetails where OrderID='" + p.orderidgrid + "'", conn);


         DataTable dTable = new DataTable();
         dAd.Fill(dTable);
         return dTable;

     }

     public DataTable dlladminorders()
     {
         SqlConnection conn = new SqlConnection(connectionString);
         SqlDataAdapter dAd = new SqlDataAdapter("select OrderID,CustomerID,OrderDate,totalAmount,Status From Orders order by OrderID desc ", conn);


         DataTable dTable = new DataTable();
         dAd.Fill(dTable);
         return dTable;

     }



     public DataSet dllLoadDt()
     {
         SqlConnection conn = new SqlConnection(connectionString);
         SqlDataAdapter dAd = new SqlDataAdapter("select * from Products", conn);
         

         DataSet dTable = new DataSet();
         dAd.Fill(dTable);
         return dTable;

     }

     public DataTable dllLoadProfit(ecprops p)
     {
         string status = "Completed";
         SqlConnection conn = new SqlConnection(connectionString);
         //SqlDataAdapter dAd = new SqlDataAdapter("SELECT Products.ProductID,Products.ProductName, Products.origionalPrice, OrderDetails.Quantity,OrderDetails.UnitCost,OrderDetails.PurchaseDate FROM Products LEFT JOIN OrderDetails ON Products.ProductID=OrderDetails.ProductID where OrderDetails.PurchaseDate Between '" + p.strDate  + "' and '" + p.endDate + "'", conn);

         string query="select * from OrderDetails Left Join Orders On OrderDetails.OrderID=Orders.OrderID where OrderDetails.PurchaseDate Between '"+p.strDate+"' and '"+p.endDate+"' and Orders.Status='"+status+"'";
         SqlDataAdapter dAd = new SqlDataAdapter(query, conn);

         DataTable dTable = new DataTable();
         dAd.Fill(dTable);
         return dTable;

     }

     public DataTable dllloadproductstable()
     {
         SqlConnection conn = new SqlConnection(connectionString);
         SqlDataAdapter dAd = new SqlDataAdapter("select * from Products", conn);


         DataTable dTable = new DataTable();
         dAd.Fill(dTable);
         return dTable;

     }

     public DataTable dllStockAlert()
     {
         SqlConnection conn = new SqlConnection(connectionString);
         SqlDataAdapter dAd = new SqlDataAdapter("select * from products where productquantity<10", conn);


         DataTable dTable = new DataTable();
         dAd.Fill(dTable);
         return dTable;

     }




        public int checkcount(ecprops p)
        {
           
           // SqlConnection conn = new SqlConnection(connectionString);
            
           // SqlDataAdapter dAd = new SqlDataAdapter("Select Count(*) FROM Categories where CategoryName ='" + txtaddcat.Text + "'", conn);

            
           // DataTable dTable = new DataTable();
           // dAd.Fill(dTable);
           // return dTable;
            //ecprops p=new ecprops();
            string query = "Select Count(*) FROM Categories where CategoryName ='" + p.addcat + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand dCmd = new SqlCommand(query, conn);
            //dCmd.CommandType = CommandType.StoredProcedure;
           // try
           // {
              //  dCmd.Parameters.AddWithValue("@UserName", Username);
            return (int)dCmd.ExecuteScalar();
            /*}
            catch
            {
                throw;
            }
            finally
            {
                dCmd.Dispose();
                conn.Close();
                conn.Dispose();
            }*/
            
        }

        public int dll_salecount(ecprops p)
        {
            string query = "select count(*) from Orders where OrderDate between '"+p.strDate+"' and '"+p.endDate+"'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand dCmd = new SqlCommand(query, conn);
            return (int)dCmd.ExecuteScalar();
            
        }

        public int dll_viewcart(ecprops p)
        {
            string query = "select count(*) from ShoppingCart where CustomerID='"+p.customerid+"'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand dCmd = new SqlCommand(query, conn);
            return (int)dCmd.ExecuteScalar();

        }
        
        public int checkcountrole(ecprops p)
        {

            string query = "Select Count(*) FROM Groups where RoleName ='" + p.rolename + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand dCmd = new SqlCommand(query, conn);
            return (int)dCmd.ExecuteScalar();
        }

        public int checkassingrolecount(ecprops p)
        {

            string query = "Select Count(*) FROM roles inner join users on roles.UserID=users.UserID inner join groups on roles.GroupID =groups.GroupID where username ='" + p.myUserName + "' AND RoleName = '" + p.myrolename + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand dCmd = new SqlCommand(query, conn);
            return (int)dCmd.ExecuteScalar();
        }







        public int Delete(string Username)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand dCmd = new SqlCommand("DeleteUser", conn);
            dCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                dCmd.Parameters.AddWithValue("@UserName", Username);
                return dCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                dCmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }
    

}
