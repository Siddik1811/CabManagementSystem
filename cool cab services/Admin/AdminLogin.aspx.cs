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

public partial class Admin_AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    AdminBo Data = new AdminBo();
    protected void But_Login_Click(object sender, EventArgs e)
    {
        string Dept = string.Empty;
        Data.UserId = Txt_UserName.Text;
        Data.Password = Txt_Password.Text;
        DataSet ds = new DataSet();
        ds = Data.AdminLogin();
        Dept = ds.Tables[0].Rows[0]["Department"].ToString().Trim();
        if (Dept != "User NotExists")
        {
            Session["UserId"] = Txt_UserName.Text;
            if (Dept == "Admin")
            {
                Response.Redirect("~/Admin/WelComeMainPage.aspx");
            }
            else if (Dept == "HRManager")
            {
                Response.Redirect("~/HRManger/HRManger.aspx");
            }
            else if (Dept == "MaintainenceManager")
            {
                Response.Redirect("~/maintenanceManger/WelComeMaintenancePage.aspx");
            }
            else if (Dept == "Movementmanager")
            {
                Response.Redirect("~/MovementHomePage/MovementHomePage.aspx");
            }
            else if (Dept == "FinanceManager")
            {
                Response.Redirect("~/FinancialHomePage/WelcomePage.aspx");
            }
            else if (Dept == "QualityManager")
            {
                Response.Redirect("~/QulityAssranceManger/WelComepage.aspx");
            }
        }
        else
        {
            Page.RegisterStartupScript("SS", "<script> alert('" + Dept + "');</script>");
        }

    }
}
