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
/// Summary description for VehicleAllocationDetailsDAL
/// </summary>
///

public class VehicleAllocationDetailsDAL
{
    public VehicleAllocationDetailsDAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    internal static int InsertVehicle(string VehicleID, string EmployeeID, string DriverID, string PickupDrop, string RouteID, string VDate)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_VehicleAllocationDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter P = cmd.Parameters.Add("@Kumar", SqlDbType.Int, 5);
        P.Direction = ParameterDirection.Output;
        cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
        cmd.Parameters.AddWithValue("@DriverID", DriverID);
        cmd.Parameters.AddWithValue("@PickupDrop", PickupDrop);
        cmd.Parameters.AddWithValue("@RouteID", RouteID);
        cmd.Parameters.AddWithValue("@VDate", VDate);
        cmd.Parameters.AddWithValue("@Type", "i");
        try
        {
            cmd.ExecuteNonQuery();
            return int.Parse(P.Value.ToString());   
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
    internal static int UpdateVehicleAllocation(string VehicleAllocationID, string VehicleID, string EmployeeID, string DriverID, string PickupDrop, string RouteID, string VDate)
    {
        // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_VehicleAllocationDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@VehicleAllocationID", VehicleAllocationID);
        cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
        cmd.Parameters.AddWithValue("@DriverID", DriverID);
        cmd.Parameters.AddWithValue("@PickupDrop", PickupDrop);
        cmd.Parameters.AddWithValue("@RouteID", RouteID);
        cmd.Parameters.AddWithValue("@VDate", VDate);
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
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_VehicleAllocationDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Type", "s");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static int Delete(string VehicleAllocationID)
    {
        // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_VehicleAllocationDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@VehicleAllocationID", VehicleAllocationID);
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

    internal static DataSet Select(string VehicleAllocationID)
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_VehicleAllocationDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@VehicleAllocationID", VehicleAllocationID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "ss");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
}
