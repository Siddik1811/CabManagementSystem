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

public partial class maintenanceManger_Vehicledetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
           if (!IsPostBack)
        {
            //string Id = Request.QueryString["Id"].ToString();
            if (Request.QueryString["id"] != null)
            {
                Button1.Text = "Update";
                But_Back.Visible = true;
                GetData();
                Update();
            }
            else
            {
                But_Back.Visible = false;
                Button1.Text = "Submit";
                GetData();
            }
        }

    }
    private void Update()
    {
        VehicleBO Data = new VehicleBO();
        Data.VehicleID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds= Data.SelectVehicle();
        TxtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
        DDLVendor.ClearSelection();

        if (DDLVendor.Items.FindByText(ds.Tables[0].Rows[0]["VenderID"].ToString().Trim())!=null)
        DDLVendor.Items.FindByText(ds.Tables[0].Rows[0]["VenderID"].ToString().Trim()).Selected = true;
        //DDLVendor.SelectedItem.Text = ds.Tables[0].Rows[0]["VenderID"].ToString();
        DDLdriverID.ClearSelection();

        if (DDLdriverID.Items.FindByText(ds.Tables[0].Rows[0]["DriverID"].ToString().Trim())!=null)
        DDLdriverID.Items.FindByText(ds.Tables[0].Rows[0]["DriverID"].ToString().Trim()).Selected = true;
        //DDLdriverID.SelectedItem.Text = ds.Tables[0].Rows[0]["DriverID"].ToString();
        TxtVehicle.Text = ds.Tables[0].Rows[0]["VehicleType"].ToString();
        TxtRegister.Text = ds.Tables[0].Rows[0]["RegistorNo"].ToString();
        TxtRatekm.Text = ds.Tables[0].Rows[0]["RateKm"].ToString();
        TxtCapacity.Text = ds.Tables[0].Rows[0]["Capacity"].ToString();

        DDLRouteID.ClearSelection();

        if (DDLRouteID.Items.FindByText(ds.Tables[0].Rows[0]["RouteID"].ToString())!=null)
        DDLRouteID.Items.FindByText(ds.Tables[0].Rows[0]["RouteID"].ToString()).Selected=true;
        //DDLRouteID.SelectedItem.Text = ds.Tables[0].Rows[0]["RouteID"].ToString();
       

    }
    private void GetData()
    {
        VendorBO Data = new VendorBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        DDLVendor.DataSource = ds;
        DDLVendor.DataTextField = "VenderID";
        DDLVendor.DataValueField = "VenderID";
        DDLVendor.DataBind();

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
       
        DDLRouteID.DataSource = dsr;
        DDLRouteID.DataTextField = "RouteID";
        DDLRouteID.DataValueField = "RouteID";
        DDLRouteID.DataBind();
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        button();

    }
    private void button()
    {
        if (Request.QueryString["id"] == null)
        {
            VehicleBO Data = new VehicleBO();
            Data.Name = TxtName.Text;
            Data.VenderID = DDLVendor.SelectedItem.Text;
            Data.DriverID = DDLdriverID.SelectedItem.Text;
            Data.VehicleType = TxtVehicle.Text;
            Data.RegistorNo = TxtRegister.Text;
            Data.RateKm = TxtRatekm.Text;
            Data.Capacity = TxtCapacity.Text;
            Data.RouteID = DDLRouteID.SelectedItem.Text;
            int i = Data.InsertVehile();
            if (i >0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('VehicleDetails Added Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('VehicleID is Already Exists')</script>");
            }
 
        }
        else if (Request.QueryString["id"] != null)
        {
            VehicleBO Data = new VehicleBO();
            Data.VehicleID = Request.QueryString["id"].ToString();
            Data.Name = TxtName.Text;
            Data.VenderID = DDLVendor.SelectedItem.Text;
            Data.DriverID = DDLdriverID.SelectedItem.Text;
            Data.VehicleType = TxtVehicle.Text;
            Data.RegistorNo = TxtRegister.Text;
            Data.RateKm = TxtRatekm.Text;
            Data.Capacity = TxtCapacity.Text;
            Data.RouteID = DDLRouteID.SelectedItem.Text;
            int i = Data.UpDateVehile();
            if (i >0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('Updated Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('VehicleDetails Not Updated')</script>");
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
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewVehicleDetails.aspx");
    }
}
