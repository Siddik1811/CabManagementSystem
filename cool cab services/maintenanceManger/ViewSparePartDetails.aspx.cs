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

public partial class maintenanceManger_ViewSparePartDetails : System.Web.UI.Page
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
        SparePartBO Data = new SparePartBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        if (ds.Tables[0].Rows.Count > 0)
        {
            LblMSg.Visible = false;
            GdV_SparePart.DataSource = ds;
            GdV_SparePart.DataBind();
        }
        else
        {
            GdV_SparePart.DataSource = null;
            GdV_SparePart.DataBind();
            LblMSg.Visible = true;
            LblMSg.Text = "No Records Found";
        }



    }
    protected void GdV_SparePart_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SparePartBO Data = new SparePartBO();
        Data.SparerPartID = GdV_SparePart.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteSparePart();
        if (i == 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

            GetData();
        }
    }
    protected void GdV_SparePart_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string ID = e.CommandArgument.ToString();
            Response.Redirect("SparePartsDetails.aspx?ID=" + ID);
        }
    }




    protected void GdV_SparePart_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdV_SparePart.PageIndex = e.NewPageIndex;
    }
}
