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

public partial class MovementHomePage_ViewTripSheet : System.Web.UI.Page
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
        TripBO Data = new TripBO();
        DataSet ds = new DataSet();
        ds = Data.Getdata();
        GdVTripSheet.DataSource = ds;
        GdVTripSheet.DataBind();
    }
    protected void GdVTripSheet_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        TripBO Data = new TripBO();
        Data.TripSheetID = GdVTripSheet.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteTrip();
        if (i > 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

            GetData();
        }
    }
    protected void GdVTripSheet_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("TripSheet.aspx?Id=" + id);
        }
    }
    protected void GdVTripSheet_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdVTripSheet.PageIndex = e.NewPageIndex;
        GetData();
    }
}
