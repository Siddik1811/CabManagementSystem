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
/// Summary description for TripSheetDAL
/// </summary>
public class TripSheetDAL
{
	public TripSheetDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());

    internal static int Insert(string AllocationID, string VehicleID, string RateKM, string KM, int TotalAmount, string Remark)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_TripSheet", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@AllocationID",AllocationID);
        cmd.Parameters.AddWithValue("@VehicleID",VehicleID);
        cmd.Parameters.AddWithValue("@RateKM",RateKM);
        cmd.Parameters.AddWithValue("@KM",KM);
        cmd.Parameters.AddWithValue("@TotalAmount",TotalAmount);
        cmd.Parameters.AddWithValue("@Remark",Remark);
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

    internal static int Upadate(string TripSheetID, string AllocationID, string VehicleID, string RateKM, string KM, int TotalAmount, string Remark)
    {
      //  throw new Exception("The method or operation is not implemented.");

        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_TripSheet", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@TripSheetID", TripSheetID);
        cmd.Parameters.AddWithValue("@AllocationID", AllocationID);
        cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
        cmd.Parameters.AddWithValue("@RateKM", RateKM);
        cmd.Parameters.AddWithValue("@KM", KM);
        cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
        cmd.Parameters.AddWithValue("@Remark", Remark);
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

    internal static DataSet GetData()
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_TripSheet", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Type", "s");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }

    internal static int delete(string TripSheetID)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_TripSheet", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@TripSheetID", TripSheetID);
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

    internal static DataSet Selete(string TripSheetID)
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_TripSheet", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@TripSheetID", TripSheetID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "ss");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;


    }
}
