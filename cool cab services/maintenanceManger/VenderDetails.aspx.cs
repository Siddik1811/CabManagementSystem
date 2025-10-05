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

public partial class maintenanceManger_VenderDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //string Id = Request.QueryString["Id"].ToString();
            if (Request.QueryString["ID"] != null)
            {
                Button1.Text = "Update";
                But_Back.Visible = true;
                GetData();
            }
            else
            {
                But_Back.Visible = false;
                Button1.Text = "Submit";
            }
        }
    }
    private void GetData()
    {
        VendorBO Data = new VendorBO();
        Data.VenderID = Request.QueryString["ID"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectVendor();
        TxtVenderName.Text = ds.Tables[0].Rows[0]["VenderName"].ToString();
        TxtvenderAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
        TxtPhoneeNo.Text = ds.Tables[0].Rows[0]["PhoneNo"].ToString();
        TxtEmailId.Text = ds.Tables[0].Rows[0]["EmailID"].ToString();
        TxtRemarks.Text = ds.Tables[0].Rows[0]["Remarks"].ToString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Button();
    }
    private void Button()
    {

        if (Request.QueryString["id"] == null)
        {
            VendorBO Data = new VendorBO();
            Data.VenderName = TxtVenderName.Text;
            Data.Address = TxtvenderAddress.Text;
            Data.PhoneNo = TxtPhoneeNo.Text;
            Data.EmailID = TxtEmailId.Text;
            Data.Remarks = TxtRemarks.Text;
            
            int i = Data.InsertVenDorDetails();
            if (i>0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('VendorDetails Added Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('VendorName is Already Exists')</script>");
            }
           

        }
        else if (Request.QueryString["id"] != null)
        {
            VendorBO Data = new VendorBO();
            Data.VenderID = Request.QueryString["id"].ToString();
            Data.VenderName = TxtVenderName.Text;
            Data.Address = TxtvenderAddress.Text;
            Data.PhoneNo = TxtPhoneeNo.Text;
            Data.EmailID = TxtEmailId.Text;
            Data.Remarks = TxtRemarks.Text;
            
            int i = Data.UpdateVenDorDetails();
            if (i > 0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('Updatee Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('VendorName is Already Exists')</script>");
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
    protected void But_Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewVendordetails.aspx");
    }
}
