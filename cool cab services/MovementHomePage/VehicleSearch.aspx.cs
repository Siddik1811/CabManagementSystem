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

public partial class MovementHomePage_VehicleSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Visible = false;
            VehicleBO Datav = new VehicleBO();
            DataSet dsv = new DataSet();
            dsv = Datav.GetData();
            DDLVehicleID.DataSource = dsv;
            DDLVehicleID.DataTextField = "VehicleID";
            DDLVehicleID.DataValueField = "VehicleID";
            DDLVehicleID.DataBind();
        }
    }
    protected void Search_Click(object sender, EventArgs e)
    {
        VehicleBO Datav = new VehicleBO();
        Datav.VehicleID = DDLVehicleID.SelectedItem.Text;
        DataSet ds = new DataSet();
        ds = Datav.SearchVehicle();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else
        {

            Label1.Visible = true;
            Label1.Text = "No Records Found";
            GridView1.DataSource = null;
            GridView1.DataBind();
        }

    }
}
