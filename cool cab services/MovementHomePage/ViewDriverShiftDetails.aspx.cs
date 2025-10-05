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

public partial class MovementHomePage_ViewDriverShiftDetails : System.Web.UI.Page
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
       
        DriverShiftdtBO Data = new DriverShiftdtBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        if (ds.Tables[0].Rows.Count > 0)
        {
            LblMSG.Visible = false;
            GdVDriverShiftDetails.DataSource = ds;
            GdVDriverShiftDetails.DataBind();

        }
        else
        {
            LblMSG.Visible = true;
            LblMSG.Text = "No Record Found";
            
        }

    }
    protected void GdVDriverShiftDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DriverShiftdtBO Data = new DriverShiftdtBO();
        Data.DriverShiftID = GdVDriverShiftDetails.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeletedriverShift();
        if (i == 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

            GetData();
        }
    }
    protected void GdVDriverShiftDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("DriverShiftDetails.aspx?Id=" + id);
        }
    }
    protected void GdVDriverShiftDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdVDriverShiftDetails.SelectedIndex = e.NewPageIndex;
        GetData();
    }
}
