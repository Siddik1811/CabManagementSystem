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

public partial class maintenanceManger_ViewDriverDetail : System.Web.UI.Page
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
        DriverBO Data = new DriverBO();
        Data.DriverID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectDriverDetails();
        Lbl_Name.Text = ds.Tables[0].Rows[0]["Name"].ToString();
        Lbl_Address.Text = ds.Tables[0].Rows[0]["Address"].ToString();
        Lbl_PhoneNo.Text = ds.Tables[0].Rows[0]["PhoneNo"].ToString();
        Lbl_DOB.Text = ds.Tables[0].Rows[0]["DOB"].ToString();
        Lbl_DOJ.Text = ds.Tables[0].Rows[0]["DOJ"].ToString();
        Lbl_Exprience.Text = ds.Tables[0].Rows[0]["Experience"].ToString();
        Lbl_Lincence.Text = ds.Tables[0].Rows[0]["LicenceNo"].ToString();
        Lbl_Accident.Text = ds.Tables[0].Rows[0]["NoOfAccident"].ToString();
       
 
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewDriverDetails.aspx");
    }
}
