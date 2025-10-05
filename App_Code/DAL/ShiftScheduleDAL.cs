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
/// Summary description for ShiftScheduleDAL
/// </summary>
public class ShiftScheduleDAL
{
	public ShiftScheduleDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());

    internal static int InsertShiftSchdule(string EmpID, string Department, string BatchID, string EmpName, string ShiftID, string RouteID)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_ShiftSchedule",cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@EmpID",EmpID);
        cmd.Parameters.AddWithValue("@Department",Department);
        cmd.Parameters.AddWithValue("@BatchID",BatchID);
        cmd.Parameters.AddWithValue("@EmpName",EmpName);
        cmd.Parameters.AddWithValue("@ShiftID",ShiftID);
        cmd.Parameters.AddWithValue("@RouteID",RouteID);
        cmd.Parameters.AddWithValue("@Type","i");
        try
        {
            return cmd.ExecuteNonQuery();

        }
        catch
        {
            throw;
        }

        finally
        {
            cn.Close();
            cmd.Dispose();
        }

    }

    internal static DataSet GetData()
    {
       // throw new Exception("The method or operation is not implemented.");
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_ShiftSchedule",cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Type", "s");
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        catch
        {
            throw;
        }
    }

    internal static int DeleteShiftSchedule(string ShiftSchduleID)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_ShiftSchedule",cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ShiftSchduleID", ShiftSchduleID);
        cmd.Parameters.AddWithValue("@Type", "d");
        try
        {
            return cmd.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }
        finally
        {
            cn.Close();
            cmd.Dispose();
        }
    }

    internal static int UpDateShiftschedule(string ShiftSchduleID, string EmpID, string Department, string BatchID, string EmpName, string ShiftID, string RouteID)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_ShiftSchedule", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ShiftSchduleID", ShiftSchduleID);
        cmd.Parameters.AddWithValue("@EmpID", EmpID);
        cmd.Parameters.AddWithValue("@Department", Department);
        cmd.Parameters.AddWithValue("@BatchID", BatchID);
        cmd.Parameters.AddWithValue("@EmpName", EmpName);
        cmd.Parameters.AddWithValue("@ShiftID", ShiftID);
        cmd.Parameters.AddWithValue("@RouteID", RouteID);
        cmd.Parameters.AddWithValue("@Type", "u");
        try
        {
            return cmd.ExecuteNonQuery();

        }
        catch
        {
            throw;
        }

        finally
        {
            cn.Close();
            cmd.Dispose();
        }
    }

    internal static DataSet Select(string ShiftSchduleID)
    {
        //throw new Exception("The method or operation is not implemented.");
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_ShiftSchedule", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ShiftSchduleID", ShiftSchduleID);
            da.SelectCommand.Parameters.AddWithValue("@Type", "s");
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        catch
        {
            throw;
        }
    }
}
