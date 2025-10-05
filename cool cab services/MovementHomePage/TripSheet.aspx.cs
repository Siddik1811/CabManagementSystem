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

public partial class MovementHomePage_TripSheet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //string Id = Request.QueryString["Id"].ToString();
            if (Request.QueryString["id"] != null)
            {
                Btn_Click.Text = "Update";
                But_Back.Visible = true;
                GetData();
                Select();
            }
            else
            {
                But_Back.Visible = false;
                Btn_Click.Text = "Submit";
                GetData();
            }
        }
    }
    private void Select()
    {
        TripBO Data = new TripBO();
        Data.TripSheetID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.Select();
        DDLAllocatioID.ClearSelection();
        if (DDLAllocatioID.Items.FindByText(ds.Tables[0].Rows[0]["AllocationID"].ToString())!=null)
        DDLAllocatioID.Items.FindByText(ds.Tables[0].Rows[0]["AllocationID"].ToString()).Selected = true;
        //DDLAllocatioID.SelectedItem.Text = ds.Tables[0].Rows[0]["AllocationID"].ToString();
        DDLVehicleID.ClearSelection();
        if (DDLVehicleID.Items.FindByText(ds.Tables[0].Rows[0]["VehicleID"].ToString())!=null)
        DDLVehicleID.Items.FindByText(ds.Tables[0].Rows[0]["VehicleID"].ToString()).Selected = true;
        //DDLVehicleID.SelectedItem.Text = ds.Tables[0].Rows[0]["VehicleID"].ToString();
        Txtkm.Text = ds.Tables[0].Rows[0]["KM"].ToString();
        TxtReatekm.Text = ds.Tables[0].Rows[0]["RateKM"].ToString();
        TxtRemark.Text = ds.Tables[0].Rows[0]["Remark"].ToString();
        Txttotalamout.Value = ds.Tables[0].Rows[0]["TotalAmount"].ToString();
        
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


        VehicleAllocationDetailsBO Dataa = new VehicleAllocationDetailsBO();
        DataSet dsa = new DataSet();
        dsa = Dataa.GetadatVehicleAllocation();
        DDLAllocatioID.DataSource = dsa;
        DDLAllocatioID.DataTextField = "VehicleAllocationID";
        DDLAllocatioID.DataValueField = "VehicleAllocationID";
        DDLAllocatioID.DataBind();

    }
    private void Clear1()
    {
        DDLAllocatioID.SelectedIndex = 0;
        DDLVehicleID.SelectedIndex = 0;
        Txtkm.Text = null;
        TxtReatekm.Text = null;
        TxtRemark.Text = null;
        Txttotalamout.Value = null;

    }

    protected void Btn_Click_Click(object sender, EventArgs e)
    {
        button();
    }
    private void button()
    {
        if (Request.QueryString["id"] == null)
        {
            TripBO Data = new TripBO();
            Data.AllocationID = DDLAllocatioID.SelectedItem.Text;
            Data.VehicleID = DDLVehicleID.SelectedItem.Text;
            Data.RateKM = TxtReatekm.Text;
            Data.KM = Txtkm.Text;
            Data.TotalAmount = int.Parse(Txttotalamout.Value);
            Data.Remark = TxtRemark.Text;
            int i = Data.Insert();
            if (i >0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('TripSheet Details was Add Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('TripSheet Details is Already Exists')</script>");
            }
            Clear1();

        }
        else if (Request.QueryString["id"] != null)
        {
            TripBO Data = new TripBO();
            Data.TripSheetID = Request.QueryString["id"].ToString();
            Data.AllocationID = DDLAllocatioID.SelectedItem.Text;
            Data.VehicleID = DDLVehicleID.SelectedItem.Text;
            Data.RateKM = TxtReatekm.Text;
            Data.KM = Txtkm.Text;
          
            Data.TotalAmount =int.Parse(Txttotalamout.Value);
            Data.Remark = TxtRemark.Text;
            int i = Data.UpDate();
            if (i == 1)
            {
                Page.RegisterStartupScript("kk", "<script>alert('Updated was Add Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('TripSheet Details is Already Exists')</script>");
            }



        }
    }
    protected void Clear_Click1(object sender, EventArgs e)
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
    protected void But_Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewTripSheet.aspx");
    }
}
