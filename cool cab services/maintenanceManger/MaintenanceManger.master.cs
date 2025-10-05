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

public partial class maintenanceManger_MaintenanceManger : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] == null)
        {
            Response.Redirect("~/Admin/AdminLogin.aspx");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Session["UserId"].ToString().Trim() == "Admin")
        {
            //Session.Abandon();
            //Session.Clear();
            Response.Redirect("~/Admin/WelComeMainPage.aspx");
        }
        else
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("~/Admin/AdminLogin.aspx");
        }
    }
}
