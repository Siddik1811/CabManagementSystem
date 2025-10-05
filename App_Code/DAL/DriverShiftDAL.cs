using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DriverShiftDAL
/// </summary>
public class DriverShiftDAL
{
	public DriverShiftDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());

    internal static int InsertDriverShift(string DriverID, string Name, string ShiftID, string ShiftDate, string Shifting)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_DriverShiftDetails",cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@DriverID",DriverID);
        cmd.Parameters.AddWithValue("@Name",Name);
        cmd.Parameters.AddWithValue("@ShiftID",ShiftID);
        cmd.Parameters.AddWithValue("@ShiftDate",ShiftDate);
        cmd.Parameters.AddWithValue("@Shifting",Shifting);
        cmd.Parameters.AddWithValue("@Type","i");
        try
        {
            return cmd.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }
    }

    internal static int UpdateDriverShift(string DriverShiftID, string DriverID, string Name, string ShiftID, string ShiftDate, string Shifting)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_DriverShiftDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@DriverShiftID", DriverShiftID);
        cmd.Parameters.AddWithValue("@DriverID", DriverID);
        cmd.Parameters.AddWithValue("@Name", Name);
        cmd.Parameters.AddWithValue("@ShiftID", ShiftID);
        cmd.Parameters.AddWithValue("@ShiftDate", ShiftDate);
        cmd.Parameters.AddWithValue("@Shifting", Shifting);
        cmd.Parameters.AddWithValue("@Type", "u");
        try
        {
            return cmd.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }
    }

    internal static DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_DriverShiftDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Type", "s");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static int DeleteDriverShift(string DriverShiftID)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_DriverShiftDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@DriverShiftID", DriverShiftID);
        cmd.Parameters.AddWithValue("@Type", "d");
        try
        {
            return cmd.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }

    }

    internal static DataSet Selectrecords(string DriverShiftID)
    {
       // throw new Exception("The method or operation is not implemented.");

        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_DriverShiftDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@DriverShiftID", DriverShiftID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "ss");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
}
