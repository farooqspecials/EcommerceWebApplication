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
using System.Net.Mail;
using System.Data.SqlClient;
using System.Messaging;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using System.IO;


public partial class forget : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnEmail_Click(object sender, EventArgs e)
    {
        if (chkemail.Checked)
        {
            dbcon obj = new dbcon();
            try
            {

                MailMessage mail = new MailMessage();
                if (obj.getUserPassword(txtusername.Text))
                {
                    mail.To.Add(dbcon.email);

                    mail.From = new MailAddress("myaspproject@gmail.com");
                    mail.Subject = "Password Recovery";

                    string Body = dbcon.body;  //myclass.body;
                    //"using Gmail in ASP.NET";
                    mail.Body = Body;

                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential
                    ("myaspproject@gmail.com", "shoppingcart");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    lblemail.Text = "Dear User Your Password is Sent to your Email Address";
                }
            }
            catch (Exception ex)
            {
                lblemail.Text = "some Problem" + ex;
            }
        }
        if (chkmobile.Checked)
        {
            dbcon obj = new dbcon();

            try
            {


                if (obj.getUserPassword(txtusername.Text))
                {
                    
                    string MsgBody = dbcon.body;  //myclass.body;
                    //"using Gmail in ASP.NET";

                    int port = 8;
                    int baud = 9600;
                    int time = 300;
                    GsmCommMain Rate = new GsmCommMain(port, baud, time);
                    Rate.Open();

                    while (!Rate.IsConnected())
                    {
                        lblemail.Text = "Not Connected";
                    }
                    //MessageBox.Show("Connected");
                    // Rate.Close();
                    SmsSubmitPdu Msg;


                    Msg = new SmsSubmitPdu(MsgBody, dbcon.mobile);
                    Rate.SendMessage(Msg);
                    lblemail.Text = "Message sent to  " + dbcon.mobile + "";
                    Rate.Close();



                    // lblemail.Text = "Dear User Your Password is Sent to your Email Address";
                }
            }
            catch (Exception ex)
            {
                txtusername.Text = "some Problem" + ex;
            }
        }
    }
    protected void btnMobile_Click(object sender, EventArgs e)
    {
      /*dbcon obj = new dbcon();

        try
        {

           
            if (obj.getUserPasswordByMobile(txtmobile.Text))
            {
             
                string MsgBody = dbcon.msgbody;  //myclass.body;
                //"using Gmail in ASP.NET";

                int port = 8;
                int baud = 9600;
                int time = 300;
                GsmCommMain Rate = new GsmCommMain(port, baud, time);
                Rate.Open();

                while (!Rate.IsConnected())
                {
                    lblmobile.Text = "Not Connected";
                }
                //MessageBox.Show("Connected");
                // Rate.Close();
                SmsSubmitPdu Msg;


                Msg = new SmsSubmitPdu(MsgBody, txtmobile.Text);
                Rate.SendMessage(Msg);
                lblmobile.Text = "Message sent to  " + txtmobile.Text + "";
                Rate.Close();
            


              // lblemail.Text = "Dear User Your Password is Sent to your Email Address";
            }
        }
        catch (Exception ex)
        {
            lblmobile.Text = "some Problem" + ex;
        }

        */
       
    }
}
