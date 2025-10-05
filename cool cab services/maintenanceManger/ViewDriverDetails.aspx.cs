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

public partial class maintenanceManger_ViewDriverDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Visible = false;
            GetData();

        }

    }
    private void GetData()
    {
       
        DriverBO Data = new DriverBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "No Records";

 
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DriverBO Data = new DriverBO();
        Data.DriverID = GridView1.Rows[e.RowIndex].Cells[3].Text;
        int i = Data.DeleteDriverDetails();
        if (i >0)
        {
            Page.RegisterStartupScript("ss", "<script>alert('Delete successfully')</script>");

            GetData();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName =="Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("DriverDetails.aspx?Id=" + id);
        }
        else if (e.CommandName =="View")
        {
            string ID = e.CommandArgument.ToString();
            Response.Redirect("ViewDriverDetail.aspx?id=" + ID);
 
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GetData();
    }
}
