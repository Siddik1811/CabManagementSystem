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

public partial class HRManger_View_ShiftSchedul : System.Web.UI.Page
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
        try
        {
            ShiftScheduleBO Data = new ShiftScheduleBO();
            DataSet ds = new DataSet();
            ds = Data.Getdata();
            GdV_ShiftSchedul.DataSource = ds;
            GdV_ShiftSchedul.DataBind();
        }
        catch
        { }
    }
    protected void GdV_ShiftSchedul_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        ShiftScheduleBO Data = new ShiftScheduleBO();
        Data.ShiftSchduleID = GdV_ShiftSchedul.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteShiftSchedul();
        if (i == 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");
            GetData();
           
        }

    }
    protected void GdV_ShiftSchedul_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Edit")
            {
                string id = e.CommandArgument.ToString();
                Response.Redirect("ShiftSchedule.aspx?Id=" + id);
            }

        }
            catch
            {}
    }
    protected void GdV_ShiftSchedul_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdV_ShiftSchedul.PageIndex = e.NewPageIndex;
        GetData();

    }
}
