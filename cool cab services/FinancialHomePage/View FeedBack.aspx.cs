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

public partial class FinancialHomePage_View_FeedBack : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void GetData()
    {
        VehicleBillingTransactionBO data = new VehicleBillingTransactionBO();
        DataSet ds=new DataSet();
        ds=data.GetDataFeedBack();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        VehicleBillingTransactionBO Data = new VehicleBillingTransactionBO();
        Data.FeedBackID = GridView1.Rows[e.RowIndex].Cells[1].Text;
        int i = Data.DeleteFeedBack();
        if (i == 1)
        {
            Page.RegisterStartupScript("kk", "<script>alert('Deleted Successfully')</script>");
        }
      
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
    }
}
