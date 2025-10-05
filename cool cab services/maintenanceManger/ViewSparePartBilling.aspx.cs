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

public partial class maintenanceManger_ViewSparePartBilling : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GetData();

    }
    private void GetData()
    {
        SparePartBillingBO Data = new SparePartBillingBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        if (ds.Tables[0].Rows.Count > 0)
        {
            Label1.Visible = false;

            GdV_sparePart.DataSource = ds;
            GdV_sparePart.DataBind();
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "No Data Found";
            GdV_sparePart.DataSource = null;
            GdV_sparePart.DataBind();
         
        }
    }
    protected void GdV_sparePart_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SparePartBillingBO Data = new SparePartBillingBO();
        Data.BillNo = GdV_sparePart.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteSparePart();
        if (i == 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

            GetData();
        }
    }
    protected void GdV_sparePart_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("SparePartsBilling.aspx?Id=" + id);
        }
    }
    protected void GdV_sparePart_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdV_sparePart.PageIndex = e.NewPageIndex;
    }
}
