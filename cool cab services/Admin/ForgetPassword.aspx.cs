using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;

public partial class Admin_ForgetPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            AdminBo Data = new AdminBo();
            DataSet ds = new DataSet();
            ds = Data.AdminLogin(Txt_UserName.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblMessage.Text = "Hello <b>" + Txt_UserName.Text + "</b> Your Password is <b>" + ds.Tables[0].Rows[0][0] + "</b>";
            }
            else
            {
                //Page.RegisterStartupScript("ss", "<script>alert('Invalid UserName')</script>");
                lblMessage.Text = "Please Check Your UserName ";
            }


        }
        catch
        {

        }

    }
    private void SendMail(String Name, String Email, String Password)
    {
        try
        {
            MailMessage MailMsg = new MailMessage();
            MailMsg.From = new MailAddress("adabalaa.kumar@gmaul.com");
            MailMsg.To.Add(Email);
            MailMsg.Subject = "kumar Real Estate: Forgot Password";
            MailMsg.IsBodyHtml = true;
            MailMsg.Priority = MailPriority.Normal;
            String Bodytext = "";
            Bodytext = "<table cellpadding='0' cellspacing='0' width='100%' style='font-family:Verdana; font-size:12px'>";
            Bodytext += "<tr><td>Hi <b>" + Name + "</b>,</td></tr><tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>Thanks for your Account in our Bank</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>Following are the credentials of your account</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>Username: " + Email + "</td></tr>";
            Bodytext += "<tr><td>Password: " + Password + "</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr><tr><td>&nbsp;</td></tr><tr><td>Thanks & Regards<br />JanataSahakariBank Team</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr></table>";

            MailMsg.Body = Bodytext;

            SmtpClient SC = new SmtpClient("localhost");
            SC.Send(MailMsg);
        }
        catch { }
    }

}
