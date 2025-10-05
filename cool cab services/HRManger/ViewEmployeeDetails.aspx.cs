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

public partial class HRManger_ViewEmployeeDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetData();
        }


    }
    private void GetData()
    {
        EmployeeBO Data = new EmployeeBO();
        DataSet ds = new DataSet();
        ds = Data.GetDataEmp();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "View")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("ViewEmployee.aspx?Id=" + id);
        }
        else if (e.CommandName == "Edit")
        {
            string ID = e.CommandArgument.ToString();
            Response.Redirect("AddEmployeeDetails.aspx?Id=" + ID);


        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        EmployeeBO Data = new EmployeeBO();
        Data.EmpID = GridView1.Rows[e.RowIndex].Cells[3].Text;
        int i = Data.DeleteEmp();
        if (i == 1)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

            GetData();
        }

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GetData();

    }
}
