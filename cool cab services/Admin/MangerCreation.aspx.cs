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

public partial class Admin_MangersAllocation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblMessage.Visible = false;
           
            //string Id = Request.QueryString["Id"].ToString();
            if (Request.QueryString["id"] != null)
            {
                Btn_Insert.Text = "Update";
                But_Back.Visible = true;
                GetData();
                TxtUserName.Visible = false;
                TxtPassword.Visible = false;
                tblLogin.Visible = false;
                
            }
            else
            {
                But_Back.Visible = false;
                Btn_Insert.Text = "Submit";
            }
        }
    }

    private void GetData()
    {
        string Id = Request.QueryString["Id"].ToString();
        AdminBo Data = new AdminBo();

        Data.MangerID = Id;
        DataSet ds = new DataSet();
        ds = Data.SelectMang();
        Txt_EmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
        Txt_ParmanentAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();       
        Txt_Qulification.Text = ds.Tables[0].Rows[0]["Qulification"].ToString();
        Txt_DOB.Text = ds.Tables[0].Rows[0]["DOB"].ToString();
        TxtEmailID.Text = ds.Tables[0].Rows[0]["EmailID"].ToString();
        RadioButtonList1.SelectedItem.Text = ds.Tables[0].Rows[0]["Gender"].ToString();
        Txt_PhoneNo.Text = ds.Tables[0].Rows[0]["PhoneNo"].ToString();
        Txt_Designation.Text = ds.Tables[0].Rows[0]["Designation"].ToString();
         DropDownList1.SelectedItem.Text = ds.Tables[0].Rows[0]["Department"].ToString();
        Txt_DOJ.Text = ds.Tables[0].Rows[0]["DOJ"].ToString();
      
        Txt_Age.Text = ds.Tables[0].Rows[0]["Age"].ToString();
        
    }
  
    private void insertdata()
    {
        if (Request.QueryString["id"] == null)
        {
            lblMessage.Visible = true;
            AdminBo Data = new AdminBo();
            Data.EmpName = Txt_EmpName.Text;
            Data.PAddress = Txt_ParmanentAddress.Text;
            Data.UserName = TxtUserName.Text;
            Data.Password = TxtPassword.Text;
            Data.Qulification = Txt_Qulification.Text;
            Data.DOB =Txt_DOB.Text;
            Data.Gender = RadioButtonList1.SelectedItem.Text;
            Data.PhoneNo = Txt_PhoneNo.Text;
            Data.EmailId = TxtEmailID.Text;
            Data.Designation = Txt_Designation.Text;
            Data.Department = DropDownList1.SelectedItem.Text;
            Data.DOJ = Txt_DOJ.Text;
            Data.Age = Txt_Age.Text;
            int i = Data.Insert();
            if (i >0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('MangerDetails  Added  Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('MangerDetails is Already Exists')</script>");
            }
        }
        else if (Request.QueryString["id"] != null)
        {
            AdminBo Data = new AdminBo();
            Data.MangerID = Request.QueryString["id"].ToString();
            Data.EmpName = Txt_EmpName.Text;
            Data.PAddress = Txt_ParmanentAddress.Text;
            //Data.UserName = TxtUserName.Text;
            //Data.Password = TxtPassword.Text;
            Data.PAddress = Txt_ParmanentAddress.Text;
            Data.Qulification = Txt_Qulification.Text;
            Data.DOB = Txt_DOB.Text;
            Data.Gender = RadioButtonList1.SelectedItem.Text;
            Data.PhoneNo = Txt_PhoneNo.Text;
            Data.EmpID = TxtEmailID.Text;
            Data.Designation = Txt_Designation.Text;
            Data.Department = DropDownList1.SelectedItem.Text;
            Data.DOJ = Txt_DOJ.Text;
            Data.Age = Txt_Age.Text;
            //int i = Data.UpdateManger();

            //if (i == 1)
            //{
            //    Page.RegisterStartupScript("kk", "<script>alert('MangerDetails Updated Successfully')</script>");
            //}
            //else
            //{
            //    Page.RegisterStartupScript("ku", "<script>alert('MangerDetails is Already Exists')</script>");
            //}

        }

    }

    protected void Btn_Insert_Click(object sender, EventArgs e)
    {
        try
        {
            insertdata();
            lblMessage.Text = "UserName :" + TxtUserName.Text +" And Password :" + TxtPassword.Text; 
        }
        catch
        {
            throw;
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
}
