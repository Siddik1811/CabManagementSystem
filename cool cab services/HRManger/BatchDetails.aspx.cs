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

public partial class HRManger_BatchDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    Btn_Submit.Text = "Update";
                    GetData();
                    Select();

                }
                else if (Request.QueryString["id"] == null)
                {
                    Button1.Visible = false;
                    Btn_Submit.Text = "Submit";
                }

            }

            GetData();
        }

    }
    private void Select()
    {
        BatchBO Data = new BatchBO();
        DataSet ds = new DataSet();
        Data.BatchID = Request.QueryString["id"].ToString();
        ds = Data.SelectBatch();
        Txt_TNoOFEmployee.Text = ds.Tables[0].Rows[0]["TotalNoOfEmployees"].ToString();
        DDL_ShiftID.ClearSelection();
        if(DDL_ShiftID.Items.FindByText(ds.Tables[0].Rows[0]["ShiftID"].ToString().ToString())!=null)
        DDL_ShiftID.Items.FindByText(ds.Tables[0].Rows[0]["ShiftID"].ToString().ToString()).Selected=true;

    }

    private void GetData()
    {
        ShiftTimingBO Data = new ShiftTimingBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        DDL_ShiftID.DataSource = ds;
        DDL_ShiftID.DataTextField = "ShiftID";
        DDL_ShiftID.DataValueField = "ShiftID";
        DDL_ShiftID.DataBind();
    }
    protected void Btn_Submit_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == null)
        {
            BatchBO Data = new BatchBO();
            Data.TotalNoOfEmployees = Txt_TNoOFEmployee.Text;
            Data.ShiftID = DDL_ShiftID.SelectedItem.Text;
            int i = Data.Insertbatch();
            if (i >0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('BatchDetails  Added Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('EmpName is Already Exists')</script>");
            }
        }
        else if(Request.QueryString["id"] != null)
        {
            BatchBO Data = new BatchBO();
            Data.BatchID = Request.QueryString["id"].ToString();
            Data.TotalNoOfEmployees = Txt_TNoOFEmployee.Text;
            Data.ShiftID = DDL_ShiftID.SelectedItem.Text;
            int i = Data.Update();
            if (i > 0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('Updated Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('Not Updated')</script>");
            }
 
        }

       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewBatchDetails.aspx");
    }
}
