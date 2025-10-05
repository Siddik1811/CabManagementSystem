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

public partial class MovementHomePage_RouteDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //string Id = Request.QueryString["Id"].ToString();
            if (Request.QueryString["id"] != null)
            {
                BtnSubmit.Text = "Update";
                BtnBack.Visible = true;
                SelectData();
            }
            else
            {
                BtnBack.Visible = false;
                BtnSubmit.Text = "Submit";
            }
        }
    }
    private void SelectData()
    {
        RouteDetailsBO Data = new RouteDetailsBO();
        Data.RouteID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectData();
        TxtDestination.Text = ds.Tables[0].Rows[0]["Destination"].ToString();
        TxtRoutedesc.Text = ds.Tables[0].Rows[0]["RouteDescription"].ToString();
        TxtSource.Text = ds.Tables[0].Rows[0]["Source"].ToString();

    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        button();

    }
    private void button()
    {
        if (Request.QueryString["id"] == null)
        {
            RouteDetailsBO Data = new RouteDetailsBO();
            Data.RouteDescription = TxtRoutedesc.Text;
            Data.Source = TxtSource.Text;
            Data.Destination = TxtDestination.Text;
            int i = Data.insertRoute();

            if (i >0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('RouteDetails Added Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('RoteDetails is Already Exists')</script>");
            }
        }
        else if (Request.QueryString["id"] != null)
        {
            RouteDetailsBO Data = new RouteDetailsBO();
            Data.RouteID = Request.QueryString["id"].ToString();
            Data.RouteDescription = TxtRoutedesc.Text;
            Data.Source = TxtSource.Text;
            Data.Destination = TxtDestination.Text;
            int i = Data.UpdateRoute();

            if (i >0)
            {
                Page.RegisterStartupScript("kk", "<script>alert('updated Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('RoteDetails is Already Exists')</script>");
            }
        }

    }
    protected void BtnClear_Click(object sender, EventArgs e)
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
    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewRouteDetails.aspx");
    }
}
