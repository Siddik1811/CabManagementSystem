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

public partial class MovementHomePage_ViewRouteDetails : System.Web.UI.Page
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
        RouteDetailsBO Data = new RouteDetailsBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        if (ds.Tables[0].Rows.Count > 0)
        {
            LblMSG.Visible = false;
            GdVRoute.DataSource = ds;
            GdVRoute.DataBind();
        }
        else
        {
            LblMSG.Visible = true;
            LblMSG.Text = "No Data Found";
 
        }
    }
    protected void GdVRoute_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        RouteDetailsBO Data = new RouteDetailsBO();
        Data.RouteID = GdVRoute.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteRoute();
        if (i == 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

            GetData();
        }
    }
    protected void GdVRoute_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("RouteDetails.aspx?Id=" + id);
        }
    }
    protected void GdVRoute_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdVRoute.SelectedIndex = e.NewPageIndex;
        GetData();
    }
    protected void GdVRoute_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
