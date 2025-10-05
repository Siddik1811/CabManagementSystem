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

public partial class Admin_LoginDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            AdminBo Data = new AdminBo();
            DataSet ds = new DataSet();
            ds = Data.GetLoginDetails();
            GdVLogin.DataSource = ds;
            GdVLogin.DataBind();
        }
    }
    protected void GdVLogin_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdVLogin.PageIndex = e.NewPageIndex;
        AdminBo Data = new AdminBo();
        DataSet ds = new DataSet();
        ds = Data.GetLoginDetails();
        GdVLogin.DataSource = ds;
        GdVLogin.DataBind();

    }
    protected void GdVLogin_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
