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

public partial class QulityAssranceManger_ChangePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("~/Admin/AdminLogin.aspx");
            }
        }


    }
    AdminBo Abo = new AdminBo();
    protected void changepwd_Click(object sender, EventArgs e)
    {
        Abo.UserId = Session["UserId"].ToString();
        Abo.OldPassword = TxtOldPassword.Text;
        Abo.Password = TxtNewpassword.Text;
        DataSet ds = new DataSet();
        ds = Abo.UpdatePassword();
        string Pwd = ds.Tables[0].Rows[0]["Password"].ToString().Trim();
        if (Pwd != "Password Not Exists")
        {
            Page.RegisterStartupScript("SS", "<script> alert('" + Pwd + "');</script>");
        }
        else
        {
            Page.RegisterStartupScript("SS", "<script> alert('" + Pwd + "');</script>");
        }
    }
}
