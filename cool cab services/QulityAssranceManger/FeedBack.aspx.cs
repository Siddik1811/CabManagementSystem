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

public partial class FinancialHomePage_FeedBack : System.Web.UI.Page
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
        EmployeeBO Data = new EmployeeBO();
        DataSet ds = new DataSet();
        ds = Data.GetDataEmp();
        DDL_EmployeeID.DataSource = ds;
        DDL_EmployeeID.DataTextField = "EmpID";
        DDL_EmployeeID.DataValueField = "EmpID";
        DDL_EmployeeID.DataBind();

        VendorBO Datai = new VendorBO();
        DataSet dsi = new DataSet();
        dsi = Datai.GetData();
        DDLVendor.DataSource = dsi;
        DDLVendor.DataTextField = "VenderID";
        DDLVendor.DataValueField = "VenderID";
        DDLVendor.DataBind();

        VehicleBO Datav = new VehicleBO();
        DataSet dsv = new DataSet();
        dsv = Datav.GetData();
        DDLVehicleID.DataSource = dsv;
        DDLVehicleID.DataTextField = "VehicleID";
        DDLVehicleID.DataValueField = "VehicleID";
        DDLVehicleID.DataBind();

 
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        VehicleBillingTransactionBO Data = new VehicleBillingTransactionBO();
        Data.EmpID=DDL_EmployeeID.SelectedItem.Text;
        Data.VehicleID=DDLVehicleID.SelectedItem.Text;
        Data.DriverID=DDLVendor.SelectedItem.Text;
        Data.Remarks=TextBox1.Text;
        int i=Data.insertFeedBack();
        if (i >0)
        {
            Page.RegisterStartupScript("kk", "<script>alert('Completed Successfully')</script>");
        }
        else
        {
            Page.RegisterStartupScript("ku", "<script>alert('Not Complieted')</script>");
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (Control ctrl in ((ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1")).Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctrl).Text = string.Empty;
                }
                if (ctrl.GetType() == typeof(DropDownList))
                {
                    ((DropDownList)ctrl).SelectedIndex = 0;
                }
            }
        }
        catch
        {
            throw;
        }
    }
}
