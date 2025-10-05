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

public partial class maintenanceManger_SparePartsDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //string Id = Request.QueryString["Id"].ToString();
            if (Request.QueryString["id"] != null)
            {
                Button1.Text = "Update";
                Back.Visible = true;
                GetData();
            }
            else
            {
                Back.Visible = false;
                Button1.Text = "Submit";
            }
        }
    }
    private void GetData()
    {
        SparePartBO Data = new SparePartBO();
        Data.SparerPartID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SeleSparePart();
        TxtSpName.Text = ds.Tables[0].Rows[0]["SparePart"].ToString();
        TxtDealerName.Text = ds.Tables[0].Rows[0]["DealerName"].ToString();
        TxtSparepartType.Text = ds.Tables[0].Rows[0]["SparePartType"].ToString();
        TxtQuantity.Text = ds.Tables[0].Rows[0]["Quantity"].ToString();
        TxtDOP.Text = ds.Tables[0].Rows[0]["DateOfPurchase"].ToString();
        TxtPrice.Text = ds.Tables[0].Rows[0]["Price"].ToString();
        TxtAmounpaid.Value = ds.Tables[0].Rows[0]["AmountPaid"].ToString();



    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        buuton();
    }

    private void buuton()
    {
        try
        {
            if (Request.QueryString["id"] == null)
            {
                SparePartBO Data = new SparePartBO();
                Data.SparePart = TxtSpName.Text;
                Data.DealerName = TxtDealerName.Text;
                Data.SparePartType=TxtSparepartType.Text;
                Data.Quantity = TxtQuantity.Text;
                Data.DateOfPurchase = TxtDOP.Text;
                Data.Price = TxtPrice.Text;
                Data.AmountPaid = TxtAmounpaid.Value;
                int i = Data.InsertSparePart();
                if (i >0)
                {
                    Page.RegisterStartupScript("kk", "<script>alert('SparePartDetails Added Successfully')</script>");
                }
                else
                {
                    Page.RegisterStartupScript("ku", "<script>alert('SparePart is Already Exists')</script>");
                }
                
            }
            else if (Request.QueryString["id"] != null)
            {
                SparePartBO Data = new SparePartBO();
                Data.SparerPartID = Request.QueryString["id"].ToString();
                Data.SparePart = TxtSpName.Text;
                Data.DealerName = TxtDealerName.Text;
                Data.SparePartType = TxtSparepartType.Text;
                Data.Quantity = TxtQuantity.Text;
                Data.DateOfPurchase = TxtDOP.Text;
                Data.Price = TxtPrice.Text;
                Data.AmountPaid = TxtAmounpaid.Value;
                int i = Data.UpDateSparePart();
                if (i > 0)
                {
                    Page.RegisterStartupScript("kk", "<script>alert('Updated Successfully')</script>");
                }
                else
                {
                    Page.RegisterStartupScript("ku", "<script>alert('SparePart is Already Exists')</script>");
                }
                
 
            }
        }
        catch
        {
 
        }
    }
    protected void Btn_clear_Click(object sender, EventArgs e)
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
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewSparePartDetails.aspx");
    }
}
