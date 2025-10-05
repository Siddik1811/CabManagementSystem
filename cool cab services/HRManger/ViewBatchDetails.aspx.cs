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

public partial class HRManger_ViewBatchDetails : System.Web.UI.Page
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
        BatchBO Data = new BatchBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        GridView1.DataSource = ds;
        GridView1.DataBind();
 
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("BatchDetails.aspx?Id=" + id);
        }

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        BatchBO Data = new BatchBO();
        Data.BatchID = GridView1.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteBatchID();
        if (i == 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

            GetData();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GetData();
    }
}
