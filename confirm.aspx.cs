using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Messaging;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using System.IO;

public partial class confirm : System.Web.UI.Page
{
    dbcon obj = new dbcon();
    protected void Page_Load(object sender, EventArgs e)
    {
      /*  if (!IsPostBack)
        {
            string query = "select * from Orders";
            DataSet ds = obj.fillgrid(query);
            DataTable dt = ds.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                lblfirstname.Text = dr["FirstName"].ToString();
                //lblfirstname = a;
                lbllastname.Text = dr["LastName"].ToString();
                lbladdress.Text = dr["Address"].ToString();
                lblphoneno.Text = dr["Telephone"].ToString();
                lblcity.Text = dr["City"].ToString();
                lblpostalcode.Text = dr["ZipCode"].ToString();
                lblprovince.Text = dr["Province"].ToString();
                

            }
            


            //string querydr = "select * from Orders";
            //SqlDataReader dr = obj.fillcomb(querydr);
            //DropDownList1.DataSource = dr;
            //DropDownList1.DataValueField = "RoleName";
            //DropDownList1.DataBind();
            /*while (dr.Read())
            {

                string a = dr["FirstName"].ToString();
                lblfirstname = a;
                lbllastname = dr["LastName"].ToString();
                lbladdress = dr["Address"].ToString();
                lblphoneno = dr["Telephone"].ToString();
                lblcity = dr["City"].ToString();
                lblpostalcode = dr["ZipCode"].ToString();
                lblprovince= dr["Province"].ToString();
                
            }*/



           // } 
        try
        {

            lblfirstname.Text = Session["FirstName"].ToString();

            lbllastname.Text = Session["LastName"].ToString();
            lbladdress.Text = Session["Address"].ToString();
            lblphoneno.Text = Session["Telephone"].ToString();
            lblprovince.Text = Session["Province"].ToString();
            lblcity.Text = Session["City"].ToString();
            lblpostalcode.Text = Session["ZipCode"].ToString();
            lblorder.Text = "Your Order Number is " + Session["OrderID"];
            lbltotal.Text = System.Convert.ToString(Convert.ToDouble(Session["totalAmount"]));
        } catch(Exception ex)
        
        {
            lblexp.Text = "Load this Page After Checkout.aspx  " + ex;
        }
        bind();

    }

    public void bind()
    {
        string query = "select * from OrderDetails inner join Products on OrderDetails.ProductID=Products.ProductID where OrderID='" + Session["OrderID"] + "'";
        DataSet ds = obj.fillgrid(query);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
    protected void btnprint_Click(object sender, EventArgs e)
    {
        Session["ctrl"] = Panel1;
        // Session["lbl"] = Label1;

        ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=300px,width=300px,scrollbars=1');</script>");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbcon obj = new dbcon();
        obj.GetInvoice(Session["OrderID"].ToString());
        try
        {

            
          //  if (obj.GetInvoice())
           // {

                string MsgBody = dbcon.mymsg;  //myclass.body;
                //"using Gmail in ASP.NET";

                int port = 8;
                int baud = 9600;
                int time = 300;
                GsmCommMain Rate = new GsmCommMain(port, baud, time);
                Rate.Open();

                while (!Rate.IsConnected())
                {
                    lblexp.Text = "Not Connected";
                }
                //MessageBox.Show("Connected");
                // Rate.Close();
                SmsSubmitPdu Msg;
                
                

                Msg = new SmsSubmitPdu(MsgBody, dbcon.phoneno);
                Rate.SendMessage(Msg);
                //lblmobile.Text = "Message sent to  " + txtmobile.Text + "";
                Rate.Close();



                lblexp.Text = "Dear User Your Ordered Information is Sent";
           // }
        }
        catch (Exception ex)
        {
           lblexp.Text = "some Problem" + ex;
        }


           
    }
    protected void _Rowbound(object sender, GridViewRowEventArgs e)
    {
        
    }
}
    
