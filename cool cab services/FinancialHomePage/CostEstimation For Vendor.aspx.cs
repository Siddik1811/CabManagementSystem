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

public partial class FinancialHomePage_CostEstimation_For_Vendor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            VendorBO Data = new VendorBO();
            DataSet ds = new DataSet();
            ds = Data.GetData();
            DDLVendor.DataSource = ds;
            DDLVendor.DataTextField = "VenderID";
            DDLVendor.DataValueField = "VenderID";
            DDLVendor.DataBind();
        }
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        VehicleBillingTransactionBO Data = new VehicleBillingTransactionBO();
        Data.VenderID = DDLVendor.SelectedItem.Text;
        DataSet ds = new DataSet();
        ds = Data.VendorData();
        GdVCostEstimation.DataSource = ds.Tables[0];
        GdVCostEstimation.DataBind();

        TxtTotal.Text = ds.Tables[1].Rows[0]["NetAmount"].ToString();
    }
    protected void GdVCostEstimation_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdVCostEstimation.PageIndex = e.NewPageIndex;
    }
    protected void GdVCostEstimation_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
