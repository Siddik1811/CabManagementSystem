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

public partial class FinancialHomePage_ViewVehicleBillingTransaction : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetData();
            Label1.Visible = false;
        }
    }

    private void GetData()
    {
        VehicleBillingTransactionBO Data = new VehicleBillingTransactionBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Edit")
            {
                string id = e.CommandArgument.ToString();
                Response.Redirect("VehicleBillingTransaction.aspx?Id=" + id);
            }

        }
        catch
        { }

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        VehicleBillingTransactionBO Data = new VehicleBillingTransactionBO();
        Data.BillNo = GridView1.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.Delete();
        if (i == 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

            GetData();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
    }
}
