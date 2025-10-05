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

public partial class HRManger_ShiftSchedule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                GetData();

                //string Id = Request.QueryString["Id"].ToString();
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
                }

            }
        }
        catch
        {
        }
    }

    private void Select()
    {
        ShiftScheduleBO Data = new ShiftScheduleBO();
        Data.ShiftSchduleID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectEmp();
        //DDL_ShiftID.ClearSelection();
        //if(DDL_ShiftID.Items.FindByText(ds.Tables[0].Rows[0]["ShiftID"].ToString().ToString())!=null)
        //DDL_ShiftID.Items.FindByText(ds.Tables[0].Rows[0]["ShiftID"].ToString().ToString()).Selected=true;
        DDL_EmployeeID.ClearSelection();
        if (DDL_EmployeeID.Items.FindByText(ds.Tables[0].Rows[0]["EmpID"].ToString())!=null)
        DDL_EmployeeID.Items.FindByText(ds.Tables[0].Rows[0]["EmpID"].ToString()).Selected=true;
        //DDL_EmployeeID.SelectedItem.Text = ds.Tables[0].Rows[0]["EmpID"].ToString();
        Txt_Department.Text = ds.Tables[0].Rows[0]["Department"].ToString();

        DDL_BatchID.ClearSelection();
        if (DDL_BatchID.Items.FindByText(ds.Tables[0].Rows[0]["BatchID"].ToString())!=null)
        DDL_BatchID.Items.FindByText(ds.Tables[0].Rows[0]["BatchID"].ToString()).Selected=true;
        //DDL_BatchID.SelectedItem.Text = ds.Tables[0].Rows[0]["BatchID"].ToString();
        Txt_EmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();

        DDL_ShiftID.ClearSelection();
        if (DDL_ShiftID.Items.FindByText(ds.Tables[0].Rows[0]["ShiftID"].ToString())!=null)

        DDL_ShiftID.Items.FindByText(ds.Tables[0].Rows[0]["ShiftID"].ToString()).Selected=true;
        //DDL_ShiftID.SelectedItem.Text = ds.Tables[0].Rows[0]["ShiftID"].ToString();
        DDLSeach.ClearSelection();

        if (DDLSeach.Items.FindByText(ds.Tables[0].Rows[0]["RouteID"].ToString())!=null)
            DDLSeach.Items.FindByText(ds.Tables[0].Rows[0]["RouteID"].ToString()).Selected=true;
        //DDLSeach.SelectedItem.Text = ds.Tables[0].Rows[0]["RouteID"].ToString();
    }

    private void GetData()
    {
        //Employee Details can be Get the data EmployeeBO class
        EmployeeBO Data = new EmployeeBO();
        DataSet ds = new DataSet();
        ds = Data.GetDataEmp();
        DDL_EmployeeID.DataSource = ds;
        DDL_EmployeeID.DataTextField = "EmpID";
        DDL_EmployeeID.DataValueField = "EmpID";
        DDL_EmployeeID.DataBind();

        //Batch Details get to BatchBO class
        BatchBO BData = new BatchBO();
        DataSet dsB = new DataSet();
        dsB = BData.GetData();
        DDL_BatchID.DataSource = dsB;
        DDL_BatchID.DataTextField = "BatchID";
        DDL_BatchID.DataValueField = "BatchID";
        DDL_BatchID.DataBind();

        ShiftTimingBO DataS = new ShiftTimingBO();
        DataSet dsS = new DataSet();
        dsS = DataS.GetData();
        DDL_ShiftID.DataSource = dsS;
        DDL_ShiftID.DataTextField = "ShiftID";
        DDL_ShiftID.DataValueField = "ShiftID";
        DDL_ShiftID.DataBind();

        RouteDetailsBO Datax = new RouteDetailsBO();
        DataSet dsx = new DataSet();
        dsx = Datax.GetData();
        DDLSeach.DataSource = dsx;
        DDLSeach.DataTextField = "RouteID";
        DDLSeach.DataValueField = "RouteID";
        DDLSeach.DataBind();


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Button();

    }

    private void Button()
    {
        if (Request.QueryString["id"] == null)
        {
            ShiftScheduleBO Data = new ShiftScheduleBO();
            Data.EmpID = DDL_EmployeeID.SelectedValue.ToString();
            Data.EmpName = Txt_EmpName.Text;
            Data.Department = Txt_Department.Text;
            Data.BatchID = DDL_BatchID.SelectedItem.Text;
            Data.ShiftID = DDL_ShiftID.SelectedItem.Text;
            Data.RouteID = DDLSeach.SelectedItem.Text;
            int i = Data.InsertShiftSchdule();
            if (i >0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('ShiftSchedul Details  Added Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('EmpName is Already Exists')</script>");
            }
 
        }
        else if (Request.QueryString["id"] != null)
        {
            ShiftScheduleBO Data = new ShiftScheduleBO();
            Data.ShiftSchduleID = Request.QueryString["id"].ToString();
            Data.EmpID = DDL_EmployeeID.SelectedValue.ToString();
            Data.EmpName = DDL_EmployeeID.SelectedItem.Text;
            Data.Department = Txt_Department.Text;
            Data.BatchID = DDL_BatchID.SelectedItem.Text;
            Data.ShiftID = DDL_ShiftID.SelectedItem.Text;
            Data.RouteID = DDLSeach.SelectedItem.Text;
            int i = Data.UpDateShiftSchdule();
            if (i>0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('Updated Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('Not Updated')</script>");
            }
        }
        }
    protected void DDL_EmployeeID_SelectedIndexChanged(object sender, EventArgs e)
    {
        EmployeeBO Data = new EmployeeBO();
        Data.EmpID = DDL_EmployeeID.SelectedValue.ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectEmp();
        Txt_Department.Text = ds.Tables[0].Rows[0]["Department"].ToString();
        Txt_EmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
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
    protected void But_Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("View ShiftSchedul.aspx");
    }
}
