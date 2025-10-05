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

public partial class maintenanceManger_ViewVendordetails : System.Web.UI.Page
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
        VendorBO Data = new VendorBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        GdV_Vendor.DataSource = ds;
        GdV_Vendor.DataBind();
    }
    protected void GdV_Vendor_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdV_Vendor.PageIndex = e.NewPageIndex;
        GetData();
    }
    protected void GdV_Vendor_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string ID = e.CommandArgument.ToString();
            Response.Redirect("VenderDetails.aspx?ID=" + ID);
        }
    }
    protected void GdV_Vendor_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        VendorBO Data = new VendorBO();
        Data.VenderID = GdV_Vendor.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteVendor();
        if (i == 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

            GetData();
        }
    }
}
