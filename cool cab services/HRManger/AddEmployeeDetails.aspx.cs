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

public partial class HRManger_AddEmployeeDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //string Id = Request.QueryString["Id"].ToString();
            if (Request.QueryString["id"] != null)
            {
                Btn_Insert.Text = "Update";
                But_Back.Visible = true;
                GetData();
                Label1.Visible = false;
                Image1.Visible = true;
            }
            else
            {
                But_Back.Visible = false;
                Btn_Insert.Text = "Submit";
                Label1.Visible = false;
                Image1.Visible = false;
            }
        }


    }

    private void GetData()
    {
        string Id = Request.QueryString["Id"].ToString();
        EmployeeBO Data = new EmployeeBO();
        Data.EmpID = Id;
        DataSet ds = new DataSet();
        ds = Data.SelectEmp();
        Txt_EmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
        Txt_ParmanentAddress.Text = ds.Tables[0].Rows[0]["PAddress"].ToString();
        Txt_CommAddress.Text = ds.Tables[0].Rows[0]["CAddess"].ToString();
        Txt_Qulification.Text = ds.Tables[0].Rows[0]["Qulification"].ToString();
        Txt_DOB.Value = ds.Tables[0].Rows[0]["DOB"].ToString();
        Txt_VehicleRequire.Text = ds.Tables[0].Rows[0]["VehicleReqire"].ToString();
        //RadioButtonList1.SelectedItem.Text = ds.Tables[0].Rows[0]["Gender"].ToString();
        Txt_PhoneNo.Text = ds.Tables[0].Rows[0]["PhoneNo"].ToString();
        Txt_Designation.Text = ds.Tables[0].Rows[0]["Designation"].ToString();
        Txt_Department.Text = ds.Tables[0].Rows[0]["Department"].ToString();
        Txt_DOJ.Value = ds.Tables[0].Rows[0]["DOJ"].ToString();
        Txt_Status.Text = ds.Tables[0].Rows[0]["Status"].ToString();
        Txt_Age.Text = ds.Tables[0].Rows[0]["Age"].ToString();
        Txt_Timespan.Text = ds.Tables[0].Rows[0]["TimeSpan"].ToString();
        Label1.Text = ds.Tables[0].Rows[0]["ImagePath"].ToString();
        //Data.ImagePath = FUl_UploadImage.FileName;
        Image1.ImageUrl = "~/Images/" + ds.Tables[0].Rows[0]["ImagePath"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            insertdata();
        }
        catch
        {
            throw;
        }
    }
    private void insertdata()
    {
        if (Request.QueryString["id"] == null)
        {

            EmployeeBO Data = new EmployeeBO();
            Data.EmpName = Txt_EmpName.Text;
            Data.PAddress = Txt_ParmanentAddress.Text;
            Data.CAddess = Txt_CommAddress.Text;
            Data.Qulification = Txt_Qulification.Text;
            Data.DOB = DateTime.Parse(Txt_DOB.Value);
            Data.VehicleReqire = Txt_VehicleRequire.Text;
            Data.Gender = RadioButtonList1.SelectedItem.Text;
            Data.PhoneNo = Txt_PhoneNo.Text;
            Data.Designation = Txt_Designation.Text;
            Data.Department = Txt_Department.Text;
            Data.DOJ = DateTime.Parse(Txt_DOJ.Value);
            Data.Status = Txt_Status.Text;
            Data.Age = Txt_Age.Text;
            Data.TimeSpan = Txt_Timespan.Text;
            if (FUl_UploadImage.FileName != "")
            {
                Data.ImagePath = FUl_UploadImage.FileName;
                FUl_UploadImage.SaveAs(Server.MapPath("../Images/" + FUl_UploadImage.FileName));
            }
            int i = Data.InsertEmpDetails();

            if (i > 0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('EmployeeDetails Added Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('EmpName is Already Exists')</script>");
            }
        }
        else if (Request.QueryString["id"] != null)
        {
            //Label1.Visible = false;
            EmployeeBO Data = new EmployeeBO();
            Data.EmpID = Request.QueryString["id"].ToString();
            Data.EmpName = Txt_EmpName.Text;
            Data.PAddress = Txt_ParmanentAddress.Text;
            Data.CAddess = Txt_CommAddress.Text;
            Data.Qulification = Txt_Qulification.Text;
            Data.DOB = DateTime.Parse(Txt_DOB.Value);
            Data.VehicleReqire = Txt_VehicleRequire.Text;
            Data.Gender = RadioButtonList1.SelectedItem.Text;
            Data.PhoneNo = Txt_PhoneNo.Text;
            Data.Designation = Txt_Designation.Text;
            Data.Department = Txt_Department.Text;
            Data.DOJ = DateTime.Parse(Txt_DOJ.Value);
            Data.Status = Txt_Status.Text;
            Data.Age = Txt_Age.Text;
            Data.TimeSpan = Txt_Timespan.Text;
            if (FUl_UploadImage.FileName != "")
            {

                Data.ImagePath = Label1.Text;
                FUl_UploadImage.SaveAs(Server.MapPath("../Images/" + FUl_UploadImage.FileName));
            }

            int i = Data.UpdateEmpDetails();

            if (i == 1)
            {
                Page.RegisterStartupScript("kk", "<script>alert('EmployeeDetails Updated Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('EmpName is Already Exists')</script>");
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
        Response.Redirect("ViewEmployeeDetails.aspx");
    }
}
