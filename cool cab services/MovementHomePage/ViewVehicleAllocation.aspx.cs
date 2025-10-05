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

public partial class MovementHomePage_ViewVehicleAllocation : System.Web.UI.Page
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
        VehicleAllocationDetailsBO Data = new VehicleAllocationDetailsBO();
        DataSet ds = new DataSet();
        ds = Data.GetadatVehicleAllocation();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        VehicleAllocationDetailsBO Data = new VehicleAllocationDetailsBO();
        Data.VehicleAllocationID = GridView1.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteVehicleAlloction();
        if (i == 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

            GetData();
        }
       
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("VehicleAllocationDetails.aspx?Id=" + id);
        }

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
    }
   

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("PrintVehicleDetail.aspx");
    }
}
