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

public partial class Admin_ViewMangerDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetData();
        }
    }
    private void GetData()
    {
        AdminBo Data = new AdminBo();
        DataSet ds = new DataSet();
        ds = Data.GetDataManger();
        GdVManger.DataSource = ds;
        GdVManger.DataBind();
    }
    protected void GdVManger_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        AdminBo Data = new AdminBo();
        Data.MangerID = GdVManger.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteManger();
        if (i == 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Deleted successfully')</script>");

            GetData();
        }
    }

    protected void GdVManger_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("ManagerNewCreation.aspx?Id=" + id);
        }
    }
}
