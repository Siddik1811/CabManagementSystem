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

public partial class FinancialHomePage_VehicleBillingTransaction : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                Btn_Insert.Text = "Update";
                But_Back.Visible = true;
                GetData();
                Select();

            }
            else
            {
                But_Back.Visible = false;
                Btn_Insert.Text = "Submit";
                GetData();

            }
        }

    }
    private void Select()
    {
        VehicleBillingTransactionBO Data = new VehicleBillingTransactionBO();
        Data.BillNo = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.Select();
        //DropDownList1.ClearSelection();
        //DropDownList1.Items.FindByText(ds.Tables[0].Rows[0]["Department"].ToString().Trim()).Selected = true;
        DDLVehicleID.ClearSelection();
        DDLVehicleID.Items.FindByText(ds.Tables[0].Rows[0]["VehicleID"].ToString().Trim()).Selected = true;
        //DDLVehicleID.SelectedItem.Text = ds.Tables[0].Rows[0]["VehicleID"].ToString();
        DDLVendor.ClearSelection();
        DDLVendor.Items.FindByText(ds.Tables[0].Rows[0]["VenderID"].ToString().Trim()).Selected = true;
        //DDLVendor.SelectedItem.Text = ds.Tables[0].Rows[0]["VenderID"].ToString();
        TxtAmount.Text = ds.Tables[0].Rows[0]["Amount"].ToString();
        TxtDate.Text = ds.Tables[0].Rows[0]["DateOfBilling"].ToString();
        TxtDeduction.Value = ds.Tables[0].Rows[0]["Deduction"].ToString();
        TxtNet.Text = ds.Tables[0].Rows[0]["NetAmount"].ToString();
    }

    private void clear()
    {
        DDLVehicleID.SelectedIndex = 0;
        DDLVendor.SelectedIndex = 0;
        TxtAmount.Text = null;
        TxtDate.Text = null;
        TxtDeduction.Value = null;
    }

    private void GetData()
    {
        VehicleBO Datav = new VehicleBO();
        DataSet dsv = new DataSet();
        dsv = Datav.GetData();
        DDLVehicleID.DataSource = dsv;
        DDLVehicleID.DataTextField = "VehicleID";
        DDLVehicleID.DataValueField = "VehicleID";
        DDLVehicleID.DataBind();


        VendorBO Data = new VendorBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        DDLVendor.DataSource = ds;
        DDLVendor.DataTextField = "VenderID";
        DDLVendor.DataValueField = "VenderID";
        DDLVendor.DataBind();

    }
    protected void Btn_Insert_Click(object sender, EventArgs e)
    {
        button();
    }
    private void button()
    {
        if (Request.QueryString["id"] == null)
        {
            VehicleBillingTransactionBO Data = new VehicleBillingTransactionBO();
            Data.VehicleID = DDLVehicleID.SelectedItem.Text;
            Data.Amount = TxtAmount.Text;
            Data.DateOfBilling = TxtDate.Text;
            Data.VenderID = DDLVendor.SelectedItem.Text;
            Data.Deduction = TxtDeduction.Value;
            Data.NetAmount = int.Parse(TxtNet.Text);
            int i = Data.Insert();
            if (i == 1)
            {
                Page.RegisterStartupScript("kk", "<script>alert('VehicleBillingTransaction  Added Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('VehicleBillingTransaction is Already Exists')</script>");
            }
            clear();


        }
        else if (Request.QueryString["id"] != null)
        {
            VehicleBillingTransactionBO Data = new VehicleBillingTransactionBO();
            Data.BillNo = Request.QueryString["id"].ToString();
            Data.VehicleID = DDLVehicleID.SelectedItem.Text;
            Data.Amount = TxtAmount.Text;
            Data.DateOfBilling = TxtDate.Text;
            Data.VenderID = DDLVendor.SelectedItem.Text;
            Data.Deduction = TxtDeduction.Value;
            Data.NetAmount = int.Parse(TxtNet.Text);
            int i = Data.Update();
            if (i == 1)
            {
                Page.RegisterStartupScript("kk", "<script>alert('Updated Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('VehicleBillingTransaction is Already Exists')</script>");
            }

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
    protected void DDLVehicleID_SelectedIndexChanged(object sender, EventArgs e)
    {
        VehicleBillingTransactionBO Data = new VehicleBillingTransactionBO();
        Data.VehicleID = DDLVehicleID.SelectedItem.Text;
        DataSet ds = new DataSet();
        ds = Data.Vehicledata();
        TxtAmount.Text = ds.Tables[0].Rows[0]["TotalAmount"].ToString();
        TxtDeduction.Value = ds.Tables[1].Rows[0]["TotalAmount"].ToString();

    }


    protected void But_Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewVehicleBillingTransaction.aspx");
    }
}
