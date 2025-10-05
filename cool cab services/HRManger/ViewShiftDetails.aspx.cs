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

public partial class HRManger_ViewShiftDetails : System.Web.UI.Page
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
        ShiftTimingBO Data = new ShiftTimingBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        GdV_ShiftDetails.DataSource = ds;
        GdV_ShiftDetails.DataBind();
    }
    protected void GdV_ShiftDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        ShiftTimingBO Data = new ShiftTimingBO();
        Data.ShiftID = GdV_ShiftDetails.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteShiftDet();
        if (i == 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

            GetData();
        }

    }
    protected void GdV_ShiftDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("ShiftTiming.aspx?Id=" + id);
        }
    }
    protected void GdV_ShiftDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdV_ShiftDetails.PageIndex = e.NewPageIndex;
        GetData();
    }
}
