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
/// Summary description for ShiftTimingDAL
/// </summary>
public class ShiftTimingDAL
{
	public ShiftTimingDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    internal static int InsertShifttime(string ShiftName, string StartingTime, string DispatchTime, string NoBatches)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_ShiftTimeing", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ShiftName",ShiftName);
        cmd.Parameters.AddWithValue("@StartingTime",StartingTime);
        cmd.Parameters.AddWithValue("@DispatchTime",DispatchTime);
        cmd.Parameters.AddWithValue("@NoBatches",NoBatches);
        cmd.Parameters.AddWithValue("@Type", "i");
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
        //throw new Exception("The method or operation is not implemented.");
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_ShiftTimeing",cn);
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

    internal static int DeleteShift(string ShiftID)
    {
        //throw new Exception("The method or operation is not implemented.");
        try
        {
            cn.Close();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_Tbl_ShiftTimeing", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ShiftID", ShiftID);
            cmd.Parameters.AddWithValue("@Type", "d");
            return cmd.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }
        finally
        {
            cn.Close();
        
      }

    }

    internal static int Updateshiftdetails(string ShiftID, string ShiftName, string StartingTime, string DispatchTime, string NoBatches)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_ShiftTimeing", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ShiftID", ShiftID);
        cmd.Parameters.AddWithValue("@ShiftName", ShiftName);
        cmd.Parameters.AddWithValue("@StartingTime", StartingTime);
        cmd.Parameters.AddWithValue("@DispatchTime", DispatchTime);
        cmd.Parameters.AddWithValue("@NoBatches", NoBatches);
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

    internal static DataSet selectShift(string ShiftID)
    {
      //  throw new Exception("The method or operation is not implemented.");
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_ShiftTimeing", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ShiftID", ShiftID);
            da.SelectCommand.Parameters.AddWithValue("@Type", "ss");
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        catch
        {
            throw;

        }

    }

    internal static DataSet SearchShiftID(string ShiftID)
    {
        //throw new Exception("The method or operation is not implemented.");
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_ShiftTimeing", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ShiftID", ShiftID);
            da.SelectCommand.Parameters.AddWithValue("@Type", "ssf");
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
