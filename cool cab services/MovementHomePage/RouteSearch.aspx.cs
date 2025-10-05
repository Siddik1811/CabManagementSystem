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

public partial class MovementHomePage_RouteSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            RouteDetailsBO Data = new RouteDetailsBO();
            DataSet ds = new DataSet();
            ds = Data.GetData();
            DDLSeach.DataSource = ds;
            DDLSeach.DataTextField = "RouteID";
            DDLSeach.DataValueField = "RouteID";
            DDLSeach.DataBind();

            Label1.Visible = false;

        }

    }


    protected void Search_Click(object sender, EventArgs e)
    {
        button();
    }


    private void button()
    {
        RouteDetailsBO Data = new RouteDetailsBO();
        Data.RouteID = DDLSeach.SelectedItem.Text;
        DataSet ds = new DataSet();
        ds = Data.SeacrhRoute();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GdVSearch.DataSource = ds;
            GdVSearch.DataBind();
            Label1.Visible = false;
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "No Data Found";
            GdVSearch.DataSource = null;
            GdVSearch.DataBind();
        }
 
    }
    protected void GdVSearch_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdVSearch.PageIndex = e.NewPageIndex;
        button();
    }
}
