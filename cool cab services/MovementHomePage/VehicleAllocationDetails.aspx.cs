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

public partial class MovementHomePage_VehicleAllocationDetails : System.Web.UI.Page
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
        VehicleAllocationDetailsBO Data = new VehicleAllocationDetailsBO();
        Data.VehicleAllocationID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.Select();
        DDLVehicleID.ClearSelection();
        if( DDLVehicleID.Items.FindByText(ds.Tables[0].Rows[0]["VehicleID"].ToString())!=null)
        DDLVehicleID.Items.FindByText(ds.Tables[0].Rows[0]["VehicleID"].ToString()).Selected = true;
        DDL_EmployeeID.ClearSelection();
        if(DDL_EmployeeID.Items.FindByText(ds.Tables[0].Rows[0]["EmployeeID"].ToString())!=null)
        DDL_EmployeeID.Items.FindByText(ds.Tables[0].Rows[0]["EmployeeID"].ToString()).Selected = true;
        DDLdriverID.ClearSelection();
        if (DDLdriverID.Items.FindByText(ds.Tables[0].Rows[0]["DriverID"].ToString())!=null)
        DDLdriverID.Items.FindByText(ds.Tables[0].Rows[0]["DriverID"].ToString()).Selected = true;
        DDLSeach.ClearSelection();
        if (DDLSeach.Items.FindByText(ds.Tables[0].Rows[0]["RouteID"].ToString())!=null)
        DDLSeach.Items.FindByText(ds.Tables[0].Rows[0]["RouteID"].ToString()).Selected = true;
        TxtDate.Text = ds.Tables[0].Rows[0]["VDate"].ToString();
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

        EmployeeBO Data = new EmployeeBO();
        DataSet ds = new DataSet();
        ds = Data.GetDataEmp();
        DDL_EmployeeID.DataSource = ds;
        DDL_EmployeeID.DataTextField = "EmpID";
        DDL_EmployeeID.DataValueField = "EmpID";
        DDL_EmployeeID.DataBind();

        DriverBO DataD = new DriverBO();
        DataSet dsD = new DataSet();
        dsD = DataD.GetData();
        DDLdriverID.DataSource = dsD;
        DDLdriverID.DataTextField = "DriverID";
        DDLdriverID.DataValueField = "DriverID";
        DDLdriverID.DataBind();

        RouteDetailsBO Datar = new RouteDetailsBO();
        DataSet dsr = new DataSet();
        dsr = Datar.GetData();
        DDLSeach.DataSource = dsr;
        DDLSeach.DataTextField = "RouteID";
        DDLSeach.DataValueField = "RouteID";
        DDLSeach.DataBind();
 
    }
    protected void Button1_Click(object sender, EventArgs e)
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
    protected void Btn_Click_Click(object sender, EventArgs e)
    {
        try
        {
            button();
        }
        catch
        { 
        }
    }
    private void Clear()
    {
        DDL_EmployeeID.SelectedIndex = 0;
        DDLdriverID.SelectedIndex = 0;
        DDLSeach.SelectedIndex = 0;
        DDLVehicleID.SelectedIndex = 0;
        TxtDate.Text = null;

    }
    private void button()
    {

        if (Request.QueryString["id"] == null)
        {
            VehicleAllocationDetailsBO Data = new VehicleAllocationDetailsBO();
            Data.VehicleID = DDLVehicleID.SelectedItem.Text.Trim();
            Data.EmployeeID = DDL_EmployeeID.SelectedItem.Text.Trim();
            Data.DriverID = DDLdriverID.SelectedItem.Text.Trim();
            Data.PickupDrop = RadioButtonList1.SelectedItem.Text.Trim();
            Data.RouteID = DDLSeach.SelectedItem.Text.Trim();
            Data.VDate = TxtDate.Text.Trim();
            int i = Data.InsertVehicleAllocation();
           // Clear();
            if (i == 1)
            {
                Page.RegisterStartupScript("kk", "<script>alert('Vehicle Allocation Details was Add Successfully')</script>");
            }
            else if (i == 5)
            {
                Page.RegisterStartupScript("ku", "<script>alert('Vehicle Full')</script>");
            }
            else if (i == 3)
            {
                Page.RegisterStartupScript("ku", "<script>alert('Employee is Already Exists')</script>");
            }
            else if (i == 4)
            {
                Page.RegisterStartupScript("ku", "<script>alert('Driver Already  Exists')</script>");
            }
 
        }
        else if (Request.QueryString["id"] != null)
        {

            VehicleAllocationDetailsBO Data = new VehicleAllocationDetailsBO();
            Data.VehicleAllocationID = Request.QueryString["id"].ToString();
            Data.VehicleID = DDLVehicleID.SelectedItem.Text;
            Data.EmployeeID = DDL_EmployeeID.SelectedItem.Text;
            Data.DriverID = DDLdriverID.SelectedItem.Text;
            Data.PickupDrop = RadioButtonList1.SelectedItem.Text;
            Data.RouteID = DDLSeach.SelectedItem.Text;
            Data.VDate = TxtDate.Text;
            int i = Data.UpadteVehicleAllocation();
            if (i == 1)
            {
                Page.RegisterStartupScript("kk", "<script>alert('Updated Successfully')</script>");
            }
            else if (i == 2)
            {
                Page.RegisterStartupScript("ku", "<script>alert('Vehicle Full')</script>");
            }
            else if (i == 3)
            {
                Page.RegisterStartupScript("ku", "<script>alert('Employee is Already Exists')</script>");
            }
            else if (i == 3)
            {
                Page.RegisterStartupScript("ku", "<script>alert('Driver Already  Exists')</script>");
            }
 
        }
    }
   
    protected void But_Back_Click1(object sender, EventArgs e)
    {
        Response.Redirect("ViewVehicleAllocation.aspx");

    }
}
