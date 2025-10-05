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

public partial class maintenanceManger_ViewVehicleDetails : System.Web.UI.Page
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
        VehicleBO Data = new VehicleBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        if (ds.Tables[0].Rows.Count > 0)
        {
            Lbl_ds.Visible = false;
            GdV_Vehicle.DataSource = ds;
            GdV_Vehicle.DataBind();
        }
        else
        {
            Lbl_ds.Visible = true;
            Lbl_ds.Text = "No Records Found";
            GdV_Vehicle.DataSource = null;
            GdV_Vehicle.DataBind();
        }

    }

    protected void GdV_Vehicle_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            VehicleBO Data = new VehicleBO();
            Data.VehicleID = GdV_Vehicle.Rows[e.RowIndex].Cells[2].Text;
            int i = Data.DeleteVehicle();
            if (i >0)
            {
                Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

                GetData();
            }
        }
        catch
        {
 
        }
    }
    protected void GdV_Vehicle_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("Vehicledetails.aspx?Id=" + id);
        }
    }
    protected void GdV_Vehicle_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdV_Vehicle.PageIndex = e.NewPageIndex;
        GetData();
    }
}
