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

public partial class maintenanceManger_DriverDetails : System.Web.UI.Page
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
            }
            else
            {
                But_Back.Visible = false;
                Btn_Click.Text = "Submit";
            }
        }
    }
    private void GetData()
    {
        DriverBO Data = new DriverBO();
        Data.DriverID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectDriverDetails();
        TxtDriverName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
        TxtAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
        TxtPhoneNo.Text = ds.Tables[0].Rows[0]["PhoneNo"].ToString();
        Txt_DOB.Text = ds.Tables[0].Rows[0]["DOB"].ToString();
        Txt_DOJ.Text = ds.Tables[0].Rows[0]["DOJ"].ToString();
        TxtExprince.Text = ds.Tables[0].Rows[0]["Experience"].ToString();
        TxtLicence.Text = ds.Tables[0].Rows[0]["LicenceNo"].ToString();
        TxtAccident.Text = ds.Tables[0].Rows[0]["NoOfAccident"].ToString();
    }
    protected void Btn_Click_Click(object sender, EventArgs e)
    {
        try
        {
            ButtonClick();
        }
        catch
        { 

        }


    }
    private void ButtonClick()
    {
        if (Request.QueryString["id"] == null)
        {
            DriverBO Data = new DriverBO();
            Data.Name = TxtDriverName.Text;
            Data.Address = TxtAddress.Text;
            Data.PhoneNo = TxtPhoneNo.Text;
            Data.DOB = DateTime.Parse(Txt_DOB.Text);
            Data.DOJ = DateTime.Parse(Txt_DOJ.Text);
            Data.Experience = TxtExprince.Text;
            Data.LicenceNo = TxtLicence.Text;
            Data.NoOfAccident = TxtAccident.Text;
            
            int i = Data.InsertDriverDetails();
            if (i >0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('DriverDetails Added Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('DriverDetails is Already Exists')</script>");
            }
        }
        else if (Request.QueryString != null)
        {
            DriverBO Data = new DriverBO();
            Data.DriverID = Request.QueryString["id"].ToString();
            Data.Name = TxtDriverName.Text;
            Data.Address = TxtAddress.Text;
            Data.PhoneNo = TxtPhoneNo.Text;
            Data.DOB = DateTime.Parse(Txt_DOB.Text);
            Data.DOJ = DateTime.Parse(Txt_DOJ.Text);
            Data.Experience = TxtExprince.Text;
            Data.LicenceNo = TxtLicence.Text;
            Data.NoOfAccident = TxtAccident.Text;
           
           
            int i = Data.UpDateDriverDetails();
            if (i == 1)
            {
                Page.RegisterStartupScript("kk", "<script>alert('DriverDetails Updated Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('EmpName is Already Exists')</script>");
            }
 
        }
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
    protected void But_Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewDriverDetails.aspx");
    }
}
