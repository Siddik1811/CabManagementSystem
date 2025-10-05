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

public partial class maintenanceManger_SparePartsBilling : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //string Id = Request.QueryString["Id"].ToString();
            if (Request.QueryString["id"] != null)
            {
                Button1.Text = "Update";
                Back.Visible = true;
                GetData();
                Data();
            }
            else
            {
                Back.Visible = false;
                Button1.Text = "Submit";
                GetData();
               // Data();
            }
        }

    }
    private void Data()
    {
        SparePartBillingBO Data = new SparePartBillingBO();
        DataSet ds = new DataSet();
        Data.BillNo = Request.QueryString["id"].ToString();
        ds = Data.SelectSparepart();
       
        DDLSparePart.ClearSelection();
        if (DDLSparePart.Items.FindByText(ds.Tables[0].Rows[0]["SparePart"].ToString().Trim())!=null)
        DDLSparePart.Items.FindByText(ds.Tables[0].Rows[0]["SparePart"].ToString().Trim()).Selected = true;
        //DDLSparePart.SelectedItem.Text = ds.Tables[0].Rows[0]["SparePart"].ToString();
        DDLSpareType.ClearSelection();
        if (DDLSpareType.Items.FindByText(ds.Tables[0].Rows[0]["SpareType"].ToString().Trim())!=null)
        DDLSpareType.Items.FindByText(ds.Tables[0].Rows[0]["SpareType"].ToString().Trim()).Selected = true;
        //DDLSpareType.SelectedItem.Text = ds.Tables[0].Rows[0]["SpareType"].ToString();
        DDLVehicleID.ClearSelection();
        if (DDLVehicleID.Items.FindByText(ds.Tables[0].Rows[0]["VehicleID"].ToString().Trim())!=null)
        DDLVehicleID.Items.FindByText(ds.Tables[0].Rows[0]["VehicleID"].ToString().Trim()).Selected = true;
        //DDLVehicleID.SelectedItem.Text = ds.Tables[0].Rows[0]["VehicleID"].ToString();
        TxtBillDate.Text = ds.Tables[0].Rows[0]["BillDateFMT"].ToString();
        TxtPrice.Value = ds.Tables[0].Rows[0]["Price"].ToString();
        TxtQuantity.Text = ds.Tables[0].Rows[0]["Quantity"].ToString();
        TxtTotalAmount.Text = ds.Tables[0].Rows[0]["TotalAmount"].ToString();

    }
    private void GetData()
    {
        SparePartBO Data = new SparePartBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        DDLSparePart.DataSource = ds;
        DDLSparePart.DataTextField = "SparePart";
        DDLSparePart.DataValueField = "SparePart";
        DDLSparePart.DataBind();

        SparePartBO Datas= new SparePartBO();
        DataSet dss = new DataSet();
        dss = Datas.GetData();
        DDLSpareType.DataSource = dss;
        DDLSpareType.DataTextField = "SparePartType";
        DDLSpareType.DataValueField = "SparePartType";
        DDLSpareType.DataBind();

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
        try
        {
            button();
            DDLSparePart.SelectedIndex = 0;
            DDLSpareType.SelectedIndex = 0;
            DDLVehicleID.SelectedIndex = 0;
            TxtBillDate.Text = null;
            TxtPrice.Value = null;
            TxtQuantity.Text = null;
            TxtTotalAmount.Text = null;

        }
        catch
        {
 
        }
   }
    private void button()
    {

        if (Request.QueryString["id"] == null)
        {
            SparePartBillingBO Data = new SparePartBillingBO();
            Data.VehicleID = DDLVehicleID.SelectedItem.Text;
            Data.SpareType = DDLSpareType.SelectedItem.Text;
            Data.Quantity = TxtQuantity.Text;
            Data.BillDate = TxtBillDate.Text;
            Data.SparePart = DDLSparePart.Text;
            Data.Price = TxtPrice.Value;
            Data.TotalAmount = int.Parse(TxtTotalAmount.Text);
            int i = Data.InsertSPBilling();

            if (i == 1)
            {
                Page.RegisterStartupScript("kk", "<script>alert('SparePartBillDetails Added Successfully')</script>");
               // table1.Visible = false;
               // table2.Visible = true;
            }
            else
            {
                //table1.Visible = true;
                //table2.Visible = false;
                Page.RegisterStartupScript("ku", "<script>alert('BiilNo is Already Exists')</script>");
            }
        }
        else if (Request.QueryString["id"] != null)
        {
            SparePartBillingBO Data = new SparePartBillingBO();
            Data.BillNo = Request.QueryString["id"].ToString();
            Data.VehicleID = DDLVehicleID.SelectedItem.Text;
            Data.SpareType = DDLSpareType.SelectedItem.Text;
            Data.Quantity = TxtQuantity.Text;
            Data.BillDate = TxtBillDate.Text;
            Data.SparePart = DDLSparePart.SelectedItem.Text;
            Data.Price = TxtPrice.Value;
            Data.TotalAmount =int.Parse(TxtTotalAmount.Text);
            int i = Data.UpdateSparePartBil();
            if (i == 1)
            {
                Page.RegisterStartupScript("kk", "<script>alert(' UpDated Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert(' Not UpDated Successfully')</script>");
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
    protected void DDLSpareType_SelectedIndexChanged(object sender, EventArgs e)
    {
        SparePartBO Data = new SparePartBO();
        Data.SparePartType=DDLSpareType.SelectedItem.Text;
        DataSet ds = new DataSet();
        ds = Data.SpareparttypeDetails();
        TxtPrice.Value = ds.Tables[0].Rows[0]["Price"].ToString();
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewSparePartBilling.aspx");
    }
}
