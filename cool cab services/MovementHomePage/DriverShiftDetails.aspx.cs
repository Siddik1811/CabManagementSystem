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

public partial class MovementHomePage_DriverShiftDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {            
            if (Request.QueryString["id"] != null)
            {
                Btn_Insert.Text = "Update";
                But_Back.Visible = true;
                SelectRecord();
                GetData();

                
            }
            else
            {
                But_Back.Visible = false;
                Btn_Insert.Text = "Submit";
                GetData();
            }
        }

    }
    private void SelectRecord()
    {
        DriverShiftdtBO data = new DriverShiftdtBO();
        data.DriverShiftID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = data.Slerecord();
        DDL_ShiftID.ClearSelection();
        if (DDL_ShiftID.Items.FindByText(ds.Tables[0].Rows[0]["ShiftID"].ToString())!=null)
        DDL_ShiftID.Items.FindByText(ds.Tables[0].Rows[0]["ShiftID"].ToString()).Selected = true;
        //DDL_ShiftID.SelectedItem.Text = ds.Tables[0].Rows[0]["ShiftID"].ToString();
        DDLdriverID.ClearSelection();
        if( DDLdriverID.Items.FindByText(ds.Tables[0].Rows[0]["DriverID"].ToString())!=null)
        DDLdriverID.Items.FindByText(ds.Tables[0].Rows[0]["DriverID"].ToString()).Selected = true;
        //DDLdriverID.SelectedItem.Text = ds.Tables[0].Rows[0]["DriverID"].ToString();
        Txt_DOB.Text = ds.Tables[0].Rows[0]["ShiftDateFMT"].ToString();
        TxtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
        //RdBtLShift.SelectedItem.Text = ds.Tables[0].Rows[0]["Shifting"].ToString();

    }
    private void GetData()
    {
        DriverBO DataD = new DriverBO();
        DataSet dsD = new DataSet();
        dsD = DataD.GetData();
        DDLdriverID.DataSource = dsD;
        DDLdriverID.DataTextField = "DriverID";
        DDLdriverID.DataValueField = "DriverID";
        DDLdriverID.DataBind();

        ShiftTimingBO DataS = new ShiftTimingBO();
        DataSet dsS = new DataSet();
        dsS = DataS.GetData();
        DDL_ShiftID.DataSource = dsS;
        DDL_ShiftID.DataTextField = "ShiftID";
        DDL_ShiftID.DataValueField = "ShiftID";
        DDL_ShiftID.DataBind();

    }
    private void Clear()
    {
        DDL_ShiftID.SelectedIndex = 0;
        DDLdriverID.SelectedIndex = 0;
        Txt_DOB.Text = null;
        TxtName.Text = null;
        RdBtLShift.SelectedIndex = 0;

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
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == null)
        {
            DriverShiftdtBO Data = new DriverShiftdtBO();
            Data.DriverID = DDLdriverID.SelectedItem.Text;
            Data.Name = TxtName.Text;
            Data.ShiftID = DDL_ShiftID.SelectedItem.Text;
            Data.ShiftDate = Txt_DOB.Text;
            Data.Shifting = RdBtLShift.SelectedItem.Text;
            int i = Data.InsertDriverShift();

            if (i>0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('DriverShiftDetails Added Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('DriverShiftDetails is Already Exists')</script>");
            }
            //Clear();
 
        }
        else if (Request.QueryString["id"] != null)
        {
            DriverShiftdtBO Data = new DriverShiftdtBO();
            Data.DriverShiftID = Request.QueryString["id"].ToString();
            Data.DriverID = DDLdriverID.SelectedItem.Text;
            Data.Name = TxtName.Text;
            Data.ShiftID = DDL_ShiftID.SelectedItem.Text;
            Data.ShiftDate = Txt_DOB.Text;
            Data.Shifting = RdBtLShift.SelectedItem.Text;
            int i = Data.UpadteDriverShift();
            if (i >0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('Updated Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('DriverShiftDetails is Already Exists')</script>");
            }
 
        }
    }
    protected void But_Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewDriverShiftDetails.aspx");
    }
    protected void DDLdriverID_SelectedIndexChanged(object sender, EventArgs e)
    {
        DriverBO Data = new DriverBO();
        Data.DriverID = DDLdriverID.SelectedItem.Text;
        DataSet ds = new DataSet();
        ds = Data.SelectDriverDetails();
        TxtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
       
    }
}
