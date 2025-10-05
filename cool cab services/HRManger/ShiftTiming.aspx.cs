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

public partial class HRManger_ShiftTiming : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                Btn_Submit.Text = "Update";
                GetData();

            }
            else if (Request.QueryString["id"] == null)
            {
                Button1.Visible = false;
                Btn_Submit.Text="Submit";
            }

        }

    }
    private void GetData()
    {
        ShiftTimingBO Data = new ShiftTimingBO();
        Data.ShiftID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectShiftDetail();
        TextBox1.Text = ds.Tables[0].Rows[0]["ShiftName"].ToString();
        Txt_startingTime.Text = ds.Tables[0].Rows[0]["StartingTime"].ToString();
        Txt_Dispatch.Text = ds.Tables[0].Rows[0]["DispatchTime"].ToString();
        Txt_tnoofbatch.Text = ds.Tables[0].Rows[0]["NoBatches"].ToString();

    }

    protected void Btn_Submit_Click(object sender, EventArgs e)
    {

        Button();
     
    }
    private void Button()
    {
        try
        {
            if (Request.QueryString["id"] == null)
            {
                ShiftTimingBO Data = new ShiftTimingBO();
                Data.ShiftName = TextBox1.Text;
                Data.StartingTime = Txt_startingTime.Text;
                Data.DispatchTime = Txt_Dispatch.Text;
                Data.NoBatches = Txt_tnoofbatch.Text;
                int i = Data.InsertShiftTime();
                if (i >0)
                {
                    Page.RegisterStartupScript("kk", "<script>alert('ShiftDetails Added Successfully')</script>");
                }
                else
                {
                    Page.RegisterStartupScript("ku", "<script>alert('ShiftName is Already Exists')</script>");
                }

 
            }
            else if (Request.QueryString["id"] != null)
            {
                ShiftTimingBO Data = new ShiftTimingBO();
                Data.ShiftID = Request.QueryString["id"].ToString();
                Data.ShiftName = TextBox1.Text;
                Data.StartingTime = Txt_startingTime.Text;
                Data.DispatchTime = Txt_Dispatch.Text;
                Data.NoBatches = Txt_tnoofbatch.Text;
                int i = Data.UpdateShiftDetails();
                if (i == 1)
                {
                    Page.RegisterStartupScript("kk", "<script>alert('Updated Successfully')</script>");
                }
                else
                {
                    Page.RegisterStartupScript("ku", "<script>alert('EmpName is Already Exists')</script>");
                }

 
            }

        }
        catch
        {
            throw;
        }
    }
    protected void Btn_Clear_Click(object sender, EventArgs e)
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
        Response.Redirect("ViewShiftDetails.aspx");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("ViewShiftDetails.aspx");
    }
}
