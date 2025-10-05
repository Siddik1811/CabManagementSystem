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

public partial class MovementHomePage_SearchShiftID : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LblDriver.Visible = false;
            LblEmp.Visible = false;
            Label1.Visible = false;
            ShiftTimingBO Data = new ShiftTimingBO();
            DataSet ds = new DataSet();
            ds = Data.GetData();
            DDLSearchShift.DataSource = ds;
            DDLSearchShift.DataTextField = "ShiftID";
            DDLSearchShift.DataValueField = "ShiftID";
            DDLSearchShift.DataBind();

        }
    }
    protected void Search_Click(object sender, EventArgs e)
    {
        ShiftScheduleBO Data = new ShiftScheduleBO();
        Data.ShiftID = DDLSearchShift.SelectedItem.Text;
        DataSet ds = new DataSet();
        ds = Data.SearchShiftID();
        if (ds.Tables[0].Rows.Count > 0)
        {
            LblEmp.Visible = true;
            LblEmp.Text = "Employee Shift Details";
            GdVSearch.DataSource = ds.Tables[0];
            GdVSearch.DataBind();

            LblDriver.Visible = true;
            Label1.Visible = false;
            LblDriver.Text = "Driver Shift Details";
            GridView1.DataSource = ds.Tables[1];
            GridView1.DataBind();

        }
        else
        {
            GdVSearch.DataSource = null;
            GdVSearch.DataBind();
            GridView1.DataSource = null;
            GridView1.DataBind();
            LblEmp.Visible = false;
            LblDriver.Visible = false;
            Label1.Visible = true;
            Label1.Text = "No Data Found";
        }
        //DataTable Empdt = new DataTable();
        //DataColumn column;
        //DataRow row;
        //column = new DataColumn();
        //column.DataType = System.Type.GetType("System.String");
        //column.ColumnName = "EmpId";
        //Empdt.Columns.Add(column);//First Column

        //column = new DataColumn();
        //column.DataType = System.Type.GetType("System.String");
        //column.ColumnName = "EmpName";
        //Empdt.Columns.Add(column);//Second Column

        //column = new DataColumn();
        //column.DataType = System.Type.GetType("System.String");
        //column.ColumnName = "StartingTime";
        //Empdt.Columns.Add(column);//Third Column

        //column = new DataColumn();
        //column.DataType = System.Type.GetType("System.String");
        //column.ColumnName = "DispatchTime";
        //Empdt.Columns.Add(column);//Fourth Column

        //column = new DataColumn();
        //column.DataType = System.Type.GetType("System.String");
        //column.ColumnName = "DriverId";
        //Empdt.Columns.Add(column);//Fifth Column

        //column = new DataColumn();
        //column.DataType = System.Type.GetType("System.String");
        //column.ColumnName = "Name";
        //Empdt.Columns.Add(column);//Fifth Column

        //row = Empdt.NewRow();
        //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //{
        //    row = Empdt.NewRow();
        //    row["EmpId"] = ds.Tables[0].Rows[i]["EmpId"].ToString();
        //    row["EmpName"] = ds.Tables[0].Rows[i]["EmpName"].ToString();
        //    row["StartingTime"] = ds.Tables[0].Rows[i]["StartingTime"].ToString();
        //    row["DispatchTime"] = ds.Tables[0].Rows[i]["DispatchTime"].ToString();
        //    Empdt.Rows.Add(row);
        //}


        //GridView2.DataSource = Empdt;
        //GridView2.DataBind();



    }
  }
