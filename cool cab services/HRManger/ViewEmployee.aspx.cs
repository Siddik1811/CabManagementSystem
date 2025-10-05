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

public partial class HRManger_ViewEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Id = Request.QueryString["Id"].ToString();
        if (Request.QueryString["id"] != null)
        {

            GetData();
        }


    }
    private void GetData()
    {
        string Id = Request.QueryString["Id"].ToString();
        EmployeeBO Data = new EmployeeBO();
        Data.EmpID = Id;
        DataSet ds = new DataSet();
        ds = Data.SelectEmp();
        Lbl_EmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
        Lbl_PAddress.Text = ds.Tables[0].Rows[0]["PAddress"].ToString();
        Lbl_CAddress.Text = ds.Tables[0].Rows[0]["CAddess"].ToString();
        Lbl_Qulification.Text = ds.Tables[0].Rows[0]["Qulification"].ToString();
        Lbl_DOB.Text = ds.Tables[0].Rows[0]["DOB"].ToString();
        Lbl_VehicleReq.Text = ds.Tables[0].Rows[0]["VehicleReqire"].ToString();
        Lbl_Gender.Text = ds.Tables[0].Rows[0]["Gender"].ToString();
        Lbl_PhoneNo.Text = ds.Tables[0].Rows[0]["PhoneNo"].ToString();
        Lbl_Designation.Text = ds.Tables[0].Rows[0]["Designation"].ToString();
        Lbl_Department.Text = ds.Tables[0].Rows[0]["Department"].ToString();
        Lbl_DOj.Text = ds.Tables[0].Rows[0]["DOJ"].ToString();
        Lbl_Status.Text = ds.Tables[0].Rows[0]["Status"].ToString();
        Lbl_Age.Text = ds.Tables[0].Rows[0]["Age"].ToString();
        Lbl_Timespan.Text = ds.Tables[0].Rows[0]["TimeSpan"].ToString();
        Image1.ImageUrl = "~/Images/" + ds.Tables[0].Rows[0]["ImagePath"].ToString();
            //Image1.ImageUrl = "~/Images/" + ds.Tables[0].Rows[0]["ImageName"].ToString();


 
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewEmployeeDetails.aspx");
    }
}
