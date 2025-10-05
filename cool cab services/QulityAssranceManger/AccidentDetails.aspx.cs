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

public partial class FinancialHomePage_AccidentDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            VehicleBO Datav = new VehicleBO();
            DataSet dsv = new DataSet();
            dsv = Datav.GetData();
            DDLVehicleID.DataSource = dsv;
            DDLVehicleID.DataTextField = "VehicleID";
            DDLVehicleID.DataValueField = "VehicleID";
            DDLVehicleID.DataBind();

            DriverBO DataD = new DriverBO();
            DataSet dsD = new DataSet();
            dsD = DataD.GetData();
            DDLdriverID.DataSource = dsD;
            DDLdriverID.DataTextField = "DriverID";
            DDLdriverID.DataValueField = "DriverID";
            DDLdriverID.DataBind();

        }

    }
    protected void Clear_Click(object sender, EventArgs e)
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
    private void Clear1()
    {
        DDLdriverID.SelectedIndex = 0;
        DDLVehicleID.SelectedIndex = 0;
        TxtDate.Text = null;
        TextBox1.Text = null;
        TextBox2.Text = null;
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        VehicleBillingTransactionBO Data=new VehicleBillingTransactionBO();
        Data.VehicleID=DDLVehicleID.SelectedItem.Text;
        Data.DriverID=DDLdriverID.SelectedItem.Text;
        Data.ADate = TxtDate.Text;
        Data.ATime = TextBox1.Text;
        Data.Remarks = TextBox2.Text;
        int i = Data.InsertAccident();
        if (i > 1)
        {
            Page.RegisterStartupScript("kk", "<script>alert('Completed Successfully')</script>");
        }
        else
        {
            Page.RegisterStartupScript("ku", "<script>alert('Not Complieted')</script>");
        }
        Clear1();
    }
}
