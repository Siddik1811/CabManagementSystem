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

public partial class FinancialHomePage_View_AcciDentDetails : System.Web.UI.Page
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
        VehicleBillingTransactionBO Data = new VehicleBillingTransactionBO();
        DataSet ds = new DataSet();
        ds = Data.GetAccidentDetail();
        GrdVAccident.DataSource = ds;
        GrdVAccident.DataBind();
    }

    protected void GrdVAccident_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        VehicleBillingTransactionBO Data = new VehicleBillingTransactionBO();
        Data.AccidentID = GrdVAccident.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteAccdent();
        if (i == 1)
        {
            Page.RegisterStartupScript("kk", "<script>alert('Deleted Successfully')</script>");
        }
        GetData();
    }
    protected void GrdVAccident_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdVAccident.PageIndex = e.NewPageIndex;
        GetData();
    }
}
